using System;
using System.Windows.Forms;

namespace miHoYoGameDownload
{
    public partial class Form3 : Form
    {
        private ApiAnalyze analyze;
        public Form3(string apiJson, string gameName_input)
        {
            InitializeComponent();
            this.analyze = new ApiAnalyze(apiJson, true); //新建一个ApiAnalyze对象
            Text += ": " + gameName_input; //在程序标题栏内显示游戏名称
            gameName.Text = gameName_input;

            version.Text = this.analyze.getCurrentVersion(); //在程序标题栏内显示游戏名称
            mainLink.Text = this.analyze.getMainLink(); //获取预更新资源包本体链接
            if (analyze.haveVoice()) //如果预更新资源中包含语音，则返回语音包链接
            {
                string[] voice_list = analyze.getLauguageExists();
                foreach (string voice in voice_list)
                {
                    voiceLinks.Text += voice + ": " + analyze.getVoiceLink(voice) + "\n";
                }
            }
            else
            {
                voiceLinks.Text = "暂无该项";
            }

            String[] versions = analyze.getExistVersionInDiffs(); //获取预更新包中存在的增量更新资源
            foreach (string version in versions)
            {
                versions_choice.Items.Add(version); //获取当前游戏可用的增量更新包的目标版本
            }
            versions_choice.SelectedIndex = 0; //在选择栏中自动选择第一项
            button1_Click(null, null); //模拟触发按钮点击事件
        }

        private void button1_Click(object sender, EventArgs e)
        {
            diffPackageLink_voices.Text = "";
            diffPackageLink_main.Text = ""; //重置文本框内的内容
            string choice = (string)versions_choice.SelectedItem; //获取用户所指定的版本

            diffPackageLink_main.Text = this.analyze.getMainLinkInDiffs(choice); //获取增量更新包本体链接
            if (this.analyze.haveVoiceInDiffs(choice)) //如果增量更新中含有语音更新，则输出语音更新包链接
            {
                string[] lauguages = this.analyze.getLauguageExistsInDiffs(choice);
                foreach (string lauguage in lauguages)
                {
                    diffPackageLink_voices.Text += lauguage + ": " + this.analyze.getVoiceInDiffs(choice, lauguage) + "\n";
                }
            }
            else
            {
                diffPackageLink_voices.Text = "暂无该项";
            }
        }
    }
}
