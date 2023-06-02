using Newtonsoft.Json.Linq;
using System;
using System.Windows.Forms;

namespace miHoYoGameDownload
{
    public partial class Form3 : Form
    {
        private string apiJson;
        private ApiAnalyze analyze;
        public Form3(string apiJson, string gameName_input)
        {
            InitializeComponent();
            analyze = new ApiAnalyze(apiJson, true);
            Text += ": " + gameName_input; 
            gameName.Text = gameName_input;
            version.Text = this.analyze.getCurrentVersion();
            mainLink.Text = this.analyze.getMainLink();
            if (analyze.haveVoice())
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
            String[] versions = analyze.getExistVersionInDiffs();
            foreach (string version in versions)
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
