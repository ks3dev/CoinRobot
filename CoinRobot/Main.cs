using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tweetinvi;

namespace CoinRobot
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private async void timer_AutoCheck_Tick(object sender, EventArgs e)
        {
            if (checkBox_binance_NowCoin.Checked)
            {
                var Work = await BLL.binance_NowCoin.CheckAndSendNews(await BLL.binance_NowCoin.CheckNewsLists());
                if (Work.GetData)
                {
                    label_binance_NowCoin.Text = (Convert.ToDecimal(label_binance_NowCoin.Text) + 1).ToString();
                }
            }
            if (checkBox_Twitter_whale_alert.Checked)
            {
                var Work = await BLL.Twitter.CheckAndSend(await BLL.Twitter.GetTwitters("whale_alert"));
                if (Work.GetData)
                {
                    label_Twitter_whale_alert.Text = (Convert.ToDecimal(label_Twitter_whale_alert.Text) + 1).ToString();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label_Timer.Text = "start";
            timer_AutoCheck.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label_Timer.Text = "stop";
            timer_AutoCheck.Stop();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Text = string.Format("{0}  V:{1}", Text, Application.ProductVersion.ToString());
        }
    }
}
