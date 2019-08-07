using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinRobot.Models.Ipad
{
    /// <summary>
    /// 鱼尾纹
    /// </summary>
    public class yww
    {
        /// <summary>
        /// 接收事件
        /// </summary>
        public class JieShou
        {
            /// <summary>
            /// 私聊消息
            /// </summary>
            public class _eventPrivateMsg
            {
                public class MsgText
                {
                    public string content { get; set; }
                    public int @continue { get; set; }
                    public string description { get; set; }
                    public string from_user { get; set; }
                    public string msg_id { get; set; }
                    public string msg_source { get; set; }
                    public int msg_type { get; set; }
                    public int status { get; set; }
                    public int sub_type { get; set; }
                    public int timestamp { get; set; }
                    public string to_user { get; set; }
                    public int uin { get; set; }
                }

                public class Message
                {
                    /// <summary>
                    /// 事件ID
                    /// </summary>
                    public int Type { get; set; }
                    /// <summary>
                    /// _eventPrivateMsg
                    /// </summary>
                    public string Function { get; set; }
                    /// <summary>
                    /// 发送者wxid
                    /// </summary>
                    public string Fromuser { get; set; }
                    /// <summary>
                    /// 已处理过的消息内容
                    /// </summary>
                    public string Msg { get; set; }
                    /// <summary>
                    /// 消息类型
                    /// </summary>
                    public int SubType { get; set; }
                    /// <summary>
                    /// 发送时间，10位时间戳
                    /// </summary>
                    public int Timestamp { get; set; }
                    /// <summary>
                    /// 消息原始内容 url加密
                    /// </summary>
                    public string MsgText { get; set; }
                    /// <summary>
                    /// 消息原始内容
                    /// </summary>
                    //public MsgText MsgText { get; set; }


                }
            }
        }

        /// <summary>
        /// 发送
        /// </summary>
        public class FaSong
        {
            /// <summary>
            /// 发送好友消息
            /// </summary>
            public class SendPrivateMsg
            {
                /// <summary>
                /// 验证token
                /// </summary>
                public string Token { get; set; }
                /// <summary>
                /// 接收者
                /// </summary>
                public string Wxid { get; set; }
                /// <summary>
                /// 消息内容
                /// </summary>
                public string Msg { get; set; }
            }
            /// <summary>
            /// 发送好友消息的返回
            /// </summary>
            public class SendPrivateMsg_Result
            {
                public string message { get; set; }
                /// <summary>
                /// 消息Id
                /// </summary>
                public string msg_id { get; set; }
                public int status { get; set; }
            }


        }

    }
}
