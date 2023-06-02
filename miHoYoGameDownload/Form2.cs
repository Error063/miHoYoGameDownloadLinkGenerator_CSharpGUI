using System;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace miHoYoGameDownload
{
    public partial class Form2 : Form
    {
        private ApiAnalyze analyze;
        public Form2(string apiJson, string gameName)
        {
            InitializeComponent();
            this.analyze = new ApiAnalyze(apiJson,false);
            Text += ": " + gameName;
            gameName_show.Text = gameName.ToString();

            gameVersion_now.Text = analyze.getCurrentVersion();
            String[] versions = analyze.getExistVersionInDiffs();
            foreach(string version in versions)
            {
                versions_choice.Items.Add(version);
            }
            versions_choice.SelectedIndex = 0;
            button1_Click(null, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            diffPackageLink_voices.Text = "";
            diffPackageLink_main.Text = "";
            string choice = (string)versions_choice.SelectedItem;

            diffPackageLink_main.Text = this.analyze.getMainLinkInDiffs(choice);
            if (this.analyze.haveVoiceInDiffs(choice))
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
