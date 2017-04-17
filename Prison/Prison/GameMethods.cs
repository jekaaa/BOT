using System;
using System.Net;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prison
{
    class GameMethods
    {
        private string host = "http://109.234.156.253/prison/universal.php?";
        public Authentification auth;
        public GameMethods(Authentification auth)
        {
            this.auth = auth;
        }

        public string getBoss()
        {
            string url = host + "key=" + auth.key + "&method=getBoss" + "&user=" + auth.id;
            string result = "";
            using (var webClient = new WebClient())
            {
                var response = webClient.DownloadString(url);
                string pattern = @"(<h_now>\w*</h_now>)";
                var hp = new Regex(pattern);
                Match match = hp.Match(response);
                if (match.Groups[1].Value != "")
                {
                    result += "Текущее здоровье - " + match.Groups[1].Value.Split('>')[1].Split('<')[0];
                }
                else
                {
                    result += "Босс не стоит";
                }
            }
            return result;
        }

        public string collectToiletPaper()
        {

            return host + "key=" + auth.key + "&method=collectToiletPaper" + "&user=" + auth.id;
        }

        public string startBattle(string idBoss, string combo, string mode, string singleMode, string guildMode)
        {
            string url = host + "key=" + auth.key + "&method=startBattle" + "&user=" + auth.id + "&combo=" + combo + "&buff=0" +
                         "&mode=" + mode + "&choice=p" + "&boss_id=" + idBoss + "&type=boss" + "&single_mode=" + singleMode + "&guild_mode=" + guildMode;
            string result = "";
            using (var webClient = new WebClient())
            {
                var response = webClient.DownloadString(url);
                string pattern = @"(<msg>.*</msg>)";
                var regular_msg = new Regex(pattern);
                Match match = regular_msg.Match(response);

                if (match.Groups[1].Value == "<msg>success battle start</msg>")
                {
                    result += "напали";
                }
                else if (match.Groups[1].Value == "<msg>not enough keys/reqs fail/under cd</msg>")
                {
                    result += "нет ключей";
                }
                else
                {
                    result += "лимит";
                }
                
            }
            return result;
        }
    }
}
