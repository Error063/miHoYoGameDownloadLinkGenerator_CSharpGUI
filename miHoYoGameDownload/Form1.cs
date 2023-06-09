﻿using System;
using System.Net;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace miHoYoGameDownload
{
    public partial class Form1 : Form
    {
        string data;
        public Form1()
        {
            InitializeComponent();
            if (Properties.Settings.Default.DebugMode)
            {
                gameChooseBox.Items.Add("Debug");
                Text += "  （开发模式）";
            }
            //button1_Click(null, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            diffsButton.Visible = false;
            getNextDownload.Visible = false;
            UseWaitCursor = true;
            voiceLinks.Text = "";
            mainLink.Text = "";
            version.Text = "";
            bool notFull = true;
            string apiUrl;
            string choice = (string)gameChooseBox.SelectedItem;
            switch (choice) //根据用户选择来选择api链接
            {
                case "原神":
                    apiUrl = !isGlobal.Checked ? Properties.Resources.genshin_china : Properties.Resources.genshin_global;
                    break;
                case "崩坏：星穹铁道":
                    apiUrl = !isGlobal.Checked ? Properties.Resources.starrail_china : Properties.Resources.starrail_global;
                    break;
                case "崩坏3":
                    apiUrl = !isGlobal.Checked ? Properties.Resources.honkai3_china : Properties.Resources.honkai3_global;
                    break;
                case "自定义来源":
                    do { apiUrl = Interaction.InputBox("请输入URL链接", "请输入URL链接", "http://sdk-static.mihoyo.com/hk4e_cn/mdk/launcher/api/resource?key=eYd89JmJ&launcher_id=18", -1, -1); }
                    while (!apiUrl.ToLower().StartsWith("http://") && !apiUrl.ToLower().StartsWith("https://"));
                    break;
                case "Debug":
                    if (MessageBox.Show("该选项仅限于开发测试\n在点击“是”之前，请确保该URL http://127.0.0.1:5000/api?from=debug 能正常访问并返回符合规范的Json文本\n若点击“否”，将会默认获取 “原神（天空岛，国服）” 相应的资源\n要继续吗？", "警告", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        gameChooseBox.SelectedIndex = 0;
                        isGlobal.Checked = false;
                        apiUrl = Properties.Resources.genshin_china;
                    }else apiUrl = Properties.Resources.debug;
                    break;
                default:
                    gameChooseBox.SelectedIndex = 0;
                    isGlobal.Checked = false;
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
                try
                {
                    ApiAnalyze analyze = new ApiAnalyze(data, false); //新建一个ApiAnalyze对象
                    version.Text = analyze.getCurrentVersion(); //获取当前版本
                    mainLink.Text = analyze.getMainLink(); //获取当前版本的下载链接
                    if (analyze.haveVoice()) //如果当前游戏资源中包含语音包，则输出相应的语音包
                    {
                        string[] voices = analyze.getLauguageExists();
                        foreach (string voice in voices) {voiceLinks.Text += voice + ": " + analyze.getVoiceLink(voice) + "\n";}
                    }
                    else
                    {
                        voiceLinks.Text = "暂无该项";
                    }
                    diffsButton.Visible = analyze.haveDiffPacks();  //如果当前游戏资源包含增量更新包，则显示该按钮
                    getNextDownload.Visible = analyze.havePreDownload(); //如果当前游戏资源包含预更新资源包，则显示该按钮
                    if (analyze.havePreDownload()) MessageBox.Show("检测到预更新资源，请点击“获取预更新资源”以查看详情","有可用的预更新资源");
                    if (notFull) MessageBox.Show("受当前技术限制，当前游戏并非完整包，游戏启动后可能会继续要求下载资源包或进行游戏热更新","提示");
                }
                catch (Exception ex) { MessageBox.Show(ex.Message, "错误"); }
                finally { UseWaitCursor = false; }
                
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

        private void gameChooseBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(gameChooseBox.SelectedItem == "Debug" || gameChooseBox.SelectedItem == "自定义来源")
            {
                isGlobal.Checked = false;
                isGlobal.Visible = false;
            }
            button1_Click(sender, e);
        }
    }
}
