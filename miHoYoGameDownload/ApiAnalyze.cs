using Newtonsoft.Json.Linq;
using System;
using System.Linq;

namespace miHoYoGameDownload
{
    internal class ApiAnalyze
    {
        private JObject nowGame;
        private JArray diffPacks;
        private JObject links;

        public ApiAnalyze(string apiJson, bool isPreDownload) //初始化ApiAnalyze类（需要传递apiJson文本和预更新标志）
        {
            JObject res = JObject.Parse(apiJson);
            this.links = (JObject)res["data"];
            if ((int)res["retcode"] == 0 && links.Count > 0) //如果json文本正常
            {
                string dist = isPreDownload ? "pre_download_game" : "game"; //获取的资源是不是预更新资源
                this.nowGame = (JObject)links[dist]["latest"]; //获取完整包资源对象
                this.diffPacks = (JArray)links[dist]["diffs"]; //获取增量包资源对象
            }
            else //如果json文本不正常，则抛出错误
            {
                throw new Exception("'data' item in json text is wrong!");
            }
        }

        public string getCurrentVersion()
        {
            return this.nowGame["version"].ToString();
        } //返回当前对象的版本号

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
        } //获取当前的完整包链接

        public bool haveVoice()
        {
            return ((JArray)this.nowGame["voice_packs"]).Count > 0;
        } //判断是否有语音资源

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
        } //获取存在的语音资源中对应的语言

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
        } //获取相对应的语音资源（需要传递希望输出的语音包的语言代码）

        public bool haveDiffPacks()
        {
            return diffPacks.Count > 0;
        } //判断是否存在增量更新资源

        public string[] getExistVersionInDiffs()
        {
            string[] version = new string[diffPacks.Count];
            for (int i = 0;i < diffPacks.Count; i++)
            {
                version[i] = diffPacks[i]["version"].ToString();
            }
            return version;
        } //获取存在的增量更新资源的目标版本

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
        } //获取增量更新包本体链接（需要传递目标版本号）

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
        } //判断目标版本中是否存在语音资源（需要传递目标版本号）

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
        } //获取目标版本中存在的语音资源中对应的语言

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
        } //获取对应语音资源的增量更新链接（需要传递目标版本号和希望输出的语音包的语言代码）

        public bool havePreDownload()
        {
            return this.links["pre_download_game"].Count() > 0;
        } //判断是否存在预更新资源
    }
}
