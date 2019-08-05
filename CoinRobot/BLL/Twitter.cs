using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Tweetinvi;

namespace CoinRobot.BLL
{
    public class Twitter
    {
        public static async Task<Models.Public.Result> CheckAndSend(IEnumerable<Tweetinvi.Models.ITweet> tweets)
        {
            Models.Public.Result result = new Models.Public.Result();
            if (tweets != null && tweets.Count() > 0)
            {
                result.GetData = true;
                //先检本地数据库，如果是新的则发送
                string Path = string.Format("{0}\\Data\\Twitter_whale_alert.txt", System.Environment.CurrentDirectory);
                string[] Loadtxt = BLL.Public.LoadTxt(Path);
                if (Loadtxt != null)
                {
                    foreach (var tweet in tweets)
                    {
                        if (tweet.Text.Contains("#BTC")||tweet.Text.Contains("#PRA"))
                        {
                            var Check = Loadtxt.FirstOrDefault(s => s.Equals(tweet.IdStr));
                            if (Check == null)
                            {
                                //🚨  🔒  考虑是否过滤这两个符号
                                string TweetText = tweet.Text.Replace("🔒", "").Replace("🚨", "").TrimStart();
                                string Message = string.Format("Twitter：{0} \r\n{1}", tweet.CreatedBy, TweetText);
                                var send = await BLL.LWR.SendMesage(Message, "4339085795@chatroom");
                                if (send)
                                {
                                    BLL.Public.WriteTxt(Path, tweet.IdStr);
                                }
                            }
                        }
                    }
                }
            }
            return result;
        }
        public static async Task<IEnumerable<Tweetinvi.Models.ITweet>> GetTwitters(string TwitterUserNmae)
        {
            TweetinviConfig.CurrentThreadSettings.ProxyConfig = new ProxyConfig("http://127.0.0.1:1080");
            var appCreds = Auth.SetApplicationOnlyCredentials("dz3Kic4aQHxsx6SEcASG2A", "MHyyF5DMOZ5hkSnFG7ZqZNsrb5P2clv2K1tYSqKUYc", true);
            Auth.InitializeApplicationOnlyCredentials(appCreds);
            IEnumerable<Tweetinvi.Models.ITweet> tweets = await TimelineAsync.GetUserTimeline(TwitterUserNmae,10);
            return tweets;
        }
    }
}