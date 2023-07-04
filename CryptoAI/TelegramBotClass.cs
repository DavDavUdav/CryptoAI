using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using static System.Net.Mime.MediaTypeNames;

namespace CryptoAI
{
    public class TelegramBotMessageClass
    {
        public string TgBotSendMessage(string apiToken, int destID, string text)
        {
            string urlString = $"https://api.telegram.org/bot{apiToken}/sendMessage?chat_id={destID}&text={text}";

            WebClient webclient = new WebClient();

            return webclient.DownloadString(urlString);
        }
    }
}
