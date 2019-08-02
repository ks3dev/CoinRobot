using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CoinRobot.BLL
{
    public class LWR
    {
        /// <summary>
        /// 发送消息
        /// </summary>
        /// <param name="content">消息内容</param>
        /// <param name="talker">接收人微信Id</param>
        /// <returns></returns>
        public static async Task<bool> SendMesage(string content, string talker)
        {
            bool isSend = true;
            Models.HookPcWx.LWR.SendMessage sendMessage = new Models.HookPcWx.LWR.SendMessage { apiName = "Coin", content = content, serverKey = BLL.Public.HookPcWxKey, type = 1, talker = talker };
            string json = JsonConvert.SerializeObject(sendMessage);
            var result = await PostHtml(BLL.Public.HookPCWxApi, json);
            if (result.StatusCode == HttpStatusCode.OK)
            {
                var data = JsonConvert.DeserializeObject<Models.HookPcWx.LWR.ResultSendMessage>(result.Html);
                if (data != null)
                {
                    if (!data.msg.Contains("ok"))
                    {
                        isSend = false;
                    }
                }
            }
            else
            {
                isSend = false;
            }
            return isSend;
        }
        /// <summary>
        /// 发送群消息，如果atid不为空则@
        /// </summary>
        /// <param name="content"></param>
        /// <param name="talker"></param>
        /// <param name="atid"></param>
        /// <returns></returns>
        public static async Task<bool> SendGroupMesage(string content, string talker, string atName = null, string atid = null)
        {
            bool isSend = true;
            Models.HookPcWx.LWR.SendMessage sendMessage = new Models.HookPcWx.LWR.SendMessage { apiName = "WXPost", content = content, serverKey = BLL.Public.HookPcWxKey, type = 7, talker = talker, atName = string.Format("@{0}", atName), atid = atid };
            string json = JsonConvert.SerializeObject(sendMessage);
            var result = await PostHtml(BLL.Public.HookPCWxApi, json);
            if (result.StatusCode == HttpStatusCode.OK)
            {
                var data = JsonConvert.DeserializeObject<Models.HookPcWx.LWR.ResultSendMessage>(result.Html);
                if (data != null)
                {
                    if (!data.msg.Contains("ok"))
                    {
                        isSend = false;
                    }
                }
            }
            else
            {
                isSend = false;
            }
            return isSend;
        }


        /// <summary>
        /// 发送POST并返回HTML
        /// </summary>
        /// <param name="strURL"></param>
        /// <param name="PostData"></param>
        /// <returns></returns>
        public static async Task<HttpResult> PostHtml(string strURL, string PostData)
        {
            HttpHelper http = new HttpHelper();
            HttpItem item = new HttpItem()
            {
                URL = strURL,//URL     必需项
                Method = "POST",//URL     可选项 默认为Get
                Postdata = PostData,
                Connectionlimit = 1000,
                KeepAlive = true,
                PostEncoding = Encoding.UTF8,
                ContentType = "application/json"
            };
            HttpResult result = await http.GetHtml(item);
            return result;
        }
    }
}
