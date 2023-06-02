using System;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace miHoYoGameDownload
{
    public partial class Form1 : Form
    {
        string data;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            diffsButton.Visible = false;
            getNextDownload.Visible = false;
            UseWaitCursor = true;
            voiceLinks.Text = "";
            mainLink.Text = "";
            version.Text = "";
            string apiUrl;
            string choice = (string)gameChooseBox.SelectedItem;
            switch (choice)
            {
                case "原神（天空岛，国服）":
                    apiUrl = Properties.Resources.genshin_china;
                    break;
                case "原神（国际服）":
                    apiUrl = Properties.Resources.genshin_global;
                    break;
                case "崩坏：星穹铁道（星穹列车，国服）":
                    apiUrl = Properties.Resources.starrail_china;
                    break;
                case "崩坏：星穹铁道（国际服）":
                    apiUrl = Properties.Resources.starrail_global;
                    break;
                case "Debug (only for development test)":
                    if (MessageBox.Show("该选项仅限于开发测试\n在点击“是”之前，请确保该URL http://127.0.0.1:5000/api?from=debug 能正常访问并返回符合规范的Json文本\n若点击“否”，将会默认获取 “原神（天空岛，国服）” 相应的资源\n要继续吗？", "警告", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        gameChooseBox.SelectedIndex = 0;
                        apiUrl = Properties.Resources.genshin_china;
                    }
                    else
                    {
                        apiUrl = Properties.Resources.debug;
                    }
                    break;
                case "崩坏3（国服）":
                    apiUrl = Properties.Resources.honkai3_china;
                    break;
                case "崩坏3（国际服）":
                    apiUrl = Properties.Resources.honkai3_global;
                    break;
                default:
                    apiUrl = Properties.Resources.genshin_china;
                    break;
            }


            using (var client = new WebClient())
            {

                client.Encoding = Encoding.UTF8;
                try
                {
                    data = client.DownloadString(apiUrl);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "错误");
                    this.Close();
                    System.Environment.Exit(0);
                }
                Console.WriteLine(data);
                try
                {
                    ApiAnalyze analyze = new ApiAnalyze(data, false);
                    version.Text = analyze.getCurrentVersion();
                    mainLink.Text = analyze.getMainLink();
                    if (analyze.haveVoice())
                    {
                        string[] voices = analyze.getLauguageExists();
                        foreach (string voice in voices)
                        {
                            voiceLinks.Text += voice + ": " + analyze.getVoiceLink(voice) + "\n";
                        }
                    }
                    else
                    {
                        voiceLinks.Text = "暂无该项";
                    }
                    diffsButton.Visible = analyze.haveDiffPacks();
                    getNextDownload.Visible = analyze.havePreDownload();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "错误");
                    this.Close();
                    System.Environment.Exit(0);
                }
                finally
                {

                    UseWaitCursor = false;
                }
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(data, (string)gameChooseBox.SelectedItem);
            form2.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void getNextDownload_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(data, (string)gameChooseBox.SelectedItem);
            form3.ShowDialog();
        }
    }
}
