using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miHoYoGameDownload
{
    internal class ApiAnalyze
    {
        private JObject nowGame;
        private JArray diffPacks;
        private JObject links;

        public ApiAnalyze(string apiJson, bool isPreDownload)
        {
            JObject res = JObject.Parse(apiJson);
            this.links = (JObject)res["data"];
            if ((int)res["retcode"] == 0 && links.Count > 0)
            {
                if (isPreDownload)
                {
                    this.nowGame = (JObject)links["pre_download_game"]["latest"];
                    this.diffPacks = (JArray)links["pre_download_game"]["diffs"];
                }
                else
                {
                    this.nowGame = (JObject)links["game"]["latest"];
                    this.diffPacks = (JArray)links["game"]["diffs"];
                }

            }
            else
            {
                throw new Exception("'data' item in json text is wrong!");
            }
        }

        public string getCurrentVersion()
        {
            return this.nowGame["version"].ToString();
        }

        public string getMainLink()
        {
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
            return path;
        }

        public bool haveVoice()
        {
            return ((JArray)this.nowGame["voice_packs"]).Count > 0;
        }

        public string[] getLauguageExists()
        {
            JArray voices = (JArray)this.nowGame["voice_packs"];
            int num = voices.Count;
            string[] voiceExist = new string[num];
            for (int i = 0; i < num; i++)
            {
                voiceExist[i]=(voices[i]["language"].ToString());
            }
            return voiceExist;
        }

        public string getVoiceLink(string lauguage)
        {
            JArray voices = (JArray)this.nowGame["voice_packs"];
            int num = voices.Count;
            for (int i = 0; i < num; i++)
            {
                if (voices[i]["language"].ToString().Equals(lauguage))
                {
                    return (string)voices[i]["path"];
                }
            }
            return null;
        }

        public bool haveDiffPacks()
        {
            return diffPacks.Count > 0;
        }

        public string[] getExistVersionInDiffs()
        {
            string[] version = new string[diffPacks.Count];
            for (int i = 0;i < diffPacks.Count; i++)
            {
                version[i] = diffPacks[i]["version"].ToString();
            }
            return version;
        }

        public string getMainLinkInDiffs(string version)
        {
            int num = diffPacks.Count;
            for (int i = 0; i < num; i++)
            {
                if (diffPacks[i]["version"].ToString().Equals(version))
                {
                    return diffPacks[i]["path"].ToString();
                }
            }
            return null;
        }

        public bool haveVoiceInDiffs(string version)
        {
            for (int i = 0; i < this.diffPacks.Count; i++)
            {
                if (this.diffPacks[i]["version"].ToString().Equals(version))
                {
                   return ((JArray)this.diffPacks[i]["voice_packs"]).Count > 0;
                }
            }
            return false;
        }

        public string[] getLauguageExistsInDiffs(string version)
        {
            for (int i = 0;i < this.diffPacks.Count; i++)
            {
                if (this.diffPacks[i]["version"].ToString().Equals(version))
                {
                    JArray voices = (JArray)this.diffPacks[i]["voice_packs"];
                    string[] lauguages = new string[voices.Count];
                    for (int j = 0; j < voices.Count; j++)
                    {
                        lauguages[j] = voices[j]["language"].ToString();
                    }
                    return lauguages;
                }
            }
            return null;
        }

        public string getVoiceInDiffs(string version, string lauguage)
        {
            for (int i = 0; i < this.diffPacks.Count; i++)
            {
                if (this.diffPacks[i]["version"].ToString().Equals(version))
                {
                    JArray voices = (JArray)this.diffPacks[i]["voice_packs"];
                    for (int j = 0; j < voices.Count; j++)
                    {
                        if (voices[j]["language"].ToString().Equals(lauguage))
                        {
                            return voices[j]["path"].ToString();
                        }
                    }
                }
            }
            return null;
        }

        public bool havePreDownload()
        {
            return this.links["pre_download_game"].Count() > 0;
        }
    }
}
