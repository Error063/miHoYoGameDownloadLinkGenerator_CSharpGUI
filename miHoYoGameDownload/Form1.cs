using System;
using System.Net;
using System.Text;
using System.Windows.Forms;

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
            switch (choice) //根据用户选择来选择api链接
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
                try //从米哈游服务器获取游戏资源
                {
                    data = client.DownloadString(apiUrl);
                }
                catch (Exception ex) //如果出现访问错误，则报错并退出程序
                {
                    MessageBox.Show(ex.Message, "错误");
                    this.Close();
                    System.Environment.Exit(0);
                }
                //Console.WriteLine(data);
                try
                {
                    ApiAnalyze analyze = new ApiAnalyze(data, false); //新建一个ApiAnalyze对象
                    version.Text = analyze.getCurrentVersion(); //获取当前版本
                    mainLink.Text = analyze.getMainLink(); //获取当前版本的下载链接
                    if (analyze.haveVoice()) //如果当前游戏资源中包含语音包，则输出相应的语音包
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
                    diffsButton.Visible = analyze.haveDiffPacks();  //如果当前游戏资源包含增量更新包，则显示该按钮
                    getNextDownload.Visible = analyze.havePreDownload(); //如果当前游戏资源包含预更新资源包，则显示该按钮
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "错误");
                }
                finally
                {

                    UseWaitCursor = false;
                }
                
            }
        }

        private void button2_Click(object sender, EventArgs e) //打开增量更新页面
        {
            Form2 form2 = new Form2(data, (string)gameChooseBox.SelectedItem);
            form2.ShowDialog();
        }

        private void getNextDownload_Click(object sender, EventArgs e) //打开预更新界面
        {
            Form3 form3 = new Form3(data, (string)gameChooseBox.SelectedItem);
            form3.ShowDialog();
        }
    }
}
