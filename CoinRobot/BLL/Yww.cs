using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CoinRobot.BLL
{
    public class Yww
    {
        public const string Token = "asdf";
        public const string ServerIp = "http://127.0.0.1:8866";
        /// <summary>
        /// 发送消息
        /// </summary>
        /// <param name="content">消息内容</param>
        /// <param name="Wxid">接收人微信Id</param>
        /// <returns></returns>
        public static async Task<bool> SendPrivateMsg(string content, string Wxid)
        {
            bool isSend = true;
            Models.Ipad.yww.FaSong.SendPrivateMsg sendMessage = new Models.Ipad.yww.FaSong.SendPrivateMsg { Msg = (System.Web.HttpUtility.UrlEncode(content, System.Text.Encoding.UTF8)).Replace("+", "%20"), Wxid = Wxid, Token = Token };
            string json = JsonConvert.SerializeObject(sendMessage);
            var result = await PostHtml(string.Format("{0}/SendPrivateMsg", ServerIp), json);
            if (result.StatusCode == HttpStatusCode.OK)
            {
                var data = JsonConvert.DeserializeObject<Models.Ipad.yww.FaSong.SendPrivateMsg_Result>(result.Html);
                if (data != null)
                {
                    if (data.status == 0)
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
        /// 发送消息
        /// </summary>
        /// <param name="content">消息内容</param>
        /// <param name="Wxid">接收人微信Id</param>
        /// <returns></returns>
        public static async Task<bool> SendGroupMsg(string content, string Wxid)
        {
            bool isSend = true;
            Models.Ipad.yww.FaSong.SendPrivateMsg sendMessage = new Models.Ipad.yww.FaSong.SendPrivateMsg { Msg = (System.Web.HttpUtility.UrlEncode(content, System.Text.Encoding.UTF8)).Replace("+", "%20"), Wxid = Wxid, Token = Token };
            string json = JsonConvert.SerializeObject(sendMessage);
            var result = await PostHtml(string.Format("{0}/SendGroupMsg", ServerIp), json);
            if (result.StatusCode == HttpStatusCode.OK)
            {
                var data = JsonConvert.DeserializeObject<Models.Ipad.yww.FaSong.SendPrivateMsg_Result>(result.Html);
                if (data != null)
                {
                    if (data.status == 0)
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
