using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CoinRobot.BLL
{
    public class NewsList
    {
        public string url { get; set; }
        public string title { get; set; }
    }

    /// <summary>
    /// 币安新币公告获取
    /// </summary>
    public class binance_NowCoin
    {
        public static async Task<Models.Public.Result> CheckAndSendNews(List<NewsList> newsLists)
        {
            Models.Public.Result result = new Models.Public.Result ();
            if (newsLists != null && newsLists.Count() > 0)
            {
                result.GetData = true;
                //先检本地数据库，如果是新的则发送
                string Path = string.Format("{0}\\Data\\binance_NowCoin.txt", System.Environment.CurrentDirectory);
                string[] Loadtxt = BLL.Public.LoadTxt(Path);
                if (Loadtxt != null)
                {
                    foreach (var new_ in newsLists)
                    {
                        var Check = Loadtxt.FirstOrDefault(s => s.Equals(new_.url));
                        if (Check == null)
                        {
                            string Message = string.Format("币安 新币上线：\r\n{0}\n{1}", new_.title, new_.url);
                            var send = await BLL.LWR.SendMesage(Message, "4339085795@chatroom");
                            if (send)
                            {
                                BLL.Public.WriteTxt(Path, new_.url);
                            }
                        }
                    }
                }
            }
            return result;
        }
        public static async Task<List<NewsList>> CheckNewsLists()
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            string Url = "https://binance.zendesk.com/hc/zh-cn/sections/115000106672-%E6%96%B0%E5%B8%81%E4%B8%8A%E7%BA%BF";
            var Result = await Public.GetHtml(Url);
            List<NewsList> newsLists = new List<NewsList>();
            if (Result.StatusCode == HttpStatusCode.OK)
            {
                //第一步声明HtmlAgilityPack.HtmlDocument实例
                HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                //第二步加载html文档
                doc.LoadHtml(Result.Html);
                //第三步通过Xpath选中html的指定元素
                HtmlNodeCollection collection_news = doc.DocumentNode.SelectNodes("/html/body/main/div[2]/div/section/ul/li");
                if (collection_news != null && collection_news.Count > 0)
                {
                    foreach (HtmlNode q in collection_news)
                    {
                        if (q != null && !string.IsNullOrWhiteSpace(q.InnerHtml))
                        {
                            HtmlAgilityPack.HtmlDocument link = new HtmlAgilityPack.HtmlDocument();
                            link.LoadHtml(q.InnerHtml);
                            var x = link.DocumentNode.Descendants("a").First();
                            if (x != null && !string.IsNullOrWhiteSpace(x.InnerText))
                            {
                                NewsList newsList = new NewsList { title = x.InnerText, url = string.Format("https://binance.zendesk.com{0}", x.Attributes["href"].Value) };
                                newsLists.Add(newsList);
                            }
                        }
                    }
                }
            }
            return newsLists;
        }
    }
}