using System;
using System.Windows.Forms;

namespace miHoYoGameDownload
{
    public partial class Form2 : Form
    {
        private ApiAnalyze analyze;
        public Form2(string apiJson, string gameName)
        {
            InitializeComponent();
            this.analyze = new ApiAnalyze(apiJson,false); //新建一个ApiAnalyze对象
            Text += ": " + gameName; //在程序标题栏内显示游戏名称
            gameName_show.Text = gameName.ToString(); 

            gameVersion_now.Text = analyze.getCurrentVersion(); //获取当前游戏版本
            String[] versions = analyze.getExistVersionInDiffs(); //获取当前游戏可用的增量更新包的目标版本
            foreach(string version in versions)
            {
                versions_choice.Items.Add(version); //向选择栏中添加对应的版本号
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
                foreach (var lauguage in lauguages)
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
