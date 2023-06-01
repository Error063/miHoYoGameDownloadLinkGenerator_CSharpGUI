using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace miHoYoGameDownload
{
    public partial class Form2 : Form
    {
        string apiJson;
        public Form2(string apiJson, string gameName)
        {
            InitializeComponent();
            Text += ": " + gameName;
            gameName_show.Text = gameName.ToString();
            this.apiJson = apiJson;
            JObject res = JObject.Parse(apiJson);
            if ((int)res["retcode"] == 0)
            {
                JObject links = (JObject)res["data"];
                gameVersion_now.Text = (string)links["game"]["latest"]["version"];
                JArray diffs = (JArray)links["game"]["diffs"];
                for (int i = 0; i < diffs.Count; i++)
                {
                    versions_choice.Items.Add(diffs[i]["version"].ToString());
                }
                versions_choice.SelectedIndex = 0;
                button1_Click(null,null);

            }
            else
            {
                MessageBox.Show("API返回错误！");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            diffPackageLink_voices.Text = "";
            diffPackageLink_main.Text = "";
            JObject res = JObject.Parse(apiJson);
            JObject links = (JObject)res["data"];
            JArray diffs = (JArray)links["game"]["diffs"];
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
