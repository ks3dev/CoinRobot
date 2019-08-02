using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinRobot.Models.HookPcWx
{
    public class LWR
    {
        /// <summary>
        /// 发送后返回类
        /// </summary>
        public class ResultSendMessage
        {
            public string code { get; set; }
            public string msg { get; set; }
        }
        public class SendMessage
        {
            public string serverKey { get; set; }
            public string apiName { get; set; }
            public int type { get; set; }
            public string talker { get; set; }
            public string content { get; set; }
            public string atName { get; set; }
            public string atid { get; set; }
        }
        /// <summary>
        /// PC微信回调信息
        /// </summary>
        public class PCWX_HuiDiaoMesage
        {
            public int code { get; set; }
            public string msg { get; set; }
            public object data { get; set; }
        }


        /// <summary>
        /// PC微信回调信息-好友消息
        /// </summary>
        public class PCWX_HuiDiaoMesage_HaoYouMesage
        {
            /// <summary>
            /// 消息id
            /// </summary>
            public int msgId { get; set; }
            /// <summary>
            /// 消息类型
            /// </summary>
            public int type { get; set; }
            /// <summary>
            /// 是否为自己发送
            /// </summary>
            public int isme { get; set; }
            /// <summary>
            /// 10位时间戳
            /// </summary>
            public int t { get; set; }
            public string talkernick { get; set; }
            public string talker { get; set; }
            public string atidnick { get; set; }
            public string atid { get; set; }
            public string recvId { get; set; }
            public string content { get; set; }
            public string picDat { get; set; }
        }
    }
}
