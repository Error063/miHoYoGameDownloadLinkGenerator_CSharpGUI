using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miHoYoGameDownload
{
    public partial class Form3 : Form
    {
        private string apiJson;
        public Form3(string apiJson, string gameName_input)
        {
            InitializeComponent();
            this.apiJson = apiJson;
            Text += ": " + gameName_input; 
            gameName.Text = gameName_input;
            JObject res = JObject.Parse(apiJson);
            JObject links = (JObject)res["data"];
            JObject nowGame = (JObject)links["pre_download_game"]["latest"];
            version.Text = (string)nowGame["version"];
            string path;
            if ((string)nowGame["path"] != String.Empty)
            {
                path = (string)nowGame["path"];
            }
            else
            {
                string segpath = (string)nowGame["segments"][0]["path"];
                path = segpath.Substring(0, segpath.Length - 4);
            }
            mainLink.Text = path;
            int i = 0;
            JArray voices = (JArray)nowGame["voice_packs"];
            if (voices.Count > 0)
            {
                for (i = 0; i < voices.Count; i++)
                {
                    voiceLinks.Text += (string)voices[i]["language"] + ": " + (string)voices[i]["path"] + "\n";
                }
            }
            else
            {
                voiceLinks.Text = "暂无该项";
            }
            JArray diffs = (JArray)links["pre_download_game"]["diffs"];
            for (i = 0; i < diffs.Count; i++)
            {
                versions_choice.Items.Add(diffs[i]["version"].ToString());
            }
            versions_choice.SelectedIndex = 0;
            button1_Click(null, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            diffPackageLink_voices.Text = "";
            diffPackageLink_main.Text = "";
            JObject res = JObject.Parse(apiJson);
            JObject links = (JObject)res["data"];
            JArray diffs = (JArray)links["pre_download_game"]["diffs"];
            string choice = (string)versions_choice.SelectedItem;
            for (int i = 0; i < diffs.Count; i++)
            {
                if ((diffs[i]["version"].ToString()).Equals(choice))
                {
                    diffPackageLink_main.Text = diffs[i]["path"].ToString();
                    JArray voices = (JArray)diffs[i]["voice_packs"];
                    if (voices.Count > 0)
                    {
                        for (int j = 0; j < voices.Count; j++)
                        {
                            diffPackageLink_voices.Text += voices[j]["language"].ToString() + ": " + voices[j]["path"].ToString() + "\n";
                        }
                    }
                    else
                    {
                        diffPackageLink_voices.Text = "暂无该项";
                    }
                    break;
                }
            }
        }
    }
}
