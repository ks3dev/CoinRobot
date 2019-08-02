using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinRobot.BLL
{
    public class Public
    {
        /// <summary>
        /// PC微信的接口地址
        /// </summary>
        public const string HookPCWxApi = "http://127.0.0.1:8083/lwr2server";
        public const string HookPcWxKey = "1234";


        public static async Task<HttpResult> GetHtml(string strURL)
        {
            HttpHelper http = new HttpHelper();
            HttpItem item = new HttpItem()
            {
                URL = strURL,//URL     必需项
                Connectionlimit = 1000,
                KeepAlive = true,
                ProtocolVersion= System.Net.HttpVersion.Version11,
            };
            if(item.URL.Contains("twitter.com"))
            {
                item.ProxyIp = "127.0.0.1:1080";
                item.Header.Add("Authorization", "OAuth 43133344-7elA64A9Om7WOfXutr0AIlnsnGfY3NdqbUSGDn9Nj");
                item.ContentType = "application/x-www-form-urlencoded;charset=UTF-8.";
            }
            HttpResult result = await http.GetHtml(item);
            return result;
        }

        /// <summary>
        /// 获取随机数组
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static string GetRandom(string[] arr)
        {
            Random ran = new Random();
            int n = ran.Next(arr.Length);
            return arr[n];
        }
        /// <summary>
        /// 读取Txt
        /// </summary>
        /// <param name="Path"></param>
        /// <returns></returns>
        public static string[] LoadTxt(string Path)
        {
            if (Path != null)
            {
                if (File.Exists(Path))
                {
                    try
                    {
                        string[] lines = System.IO.File.ReadAllLines(Path);
                        return lines;
                    }
                    catch
                    {
                        return null;
                    }
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// 创建TXT文件
        /// </summary>
        /// <param name="path"></param>
        public static void CreateTxt(string path)
        {
            if (path != null)
            {
                if (!Directory.Exists(Path.GetDirectoryName(path)))
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(path));
                }
                if (!File.Exists(path))
                {
                    try
                    {
                        FileStream fs1 = new FileStream(path, FileMode.Create, FileAccess.Write);//创建写入文件
                        fs1.Close();
                    }
                    catch
                    {

                    }
                }
            }
        }
        /// <summary>
        /// 向TXT文件中追加内容
        /// </summary>
        /// <param name="path"></param>
        /// <param name="X"></param>
        public static void WriteTxt(string path, string X)
        {
            try
            {
                StreamWriter sr = new StreamWriter(path, true);
                sr.WriteLine(string.Format("\r\n{0}", X));//开始写入值
                sr.Close();
            }
            catch
            {

            }
        }
        /// <summary>
        /// 删除文件
        /// </summary>
        /// <param name="path"></param>
        public static void DelectFile(string path)
        {
            if (File.Exists(path))
            {
                try
                {
                    File.Delete(path);
                }
                catch
                {

                }
            }
        }
    }
}
