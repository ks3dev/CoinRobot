namespace CoinRobot
{
    partial class Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer_AutoCheck = new System.Windows.Forms.Timer(this.components);
            this.checkBox_binance_NowCoin = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label_Timer = new System.Windows.Forms.Label();
            this.checkBox_Twitter_whale_alert = new System.Windows.Forms.CheckBox();
            this.label_binance_NowCoin = new System.Windows.Forms.Label();
            this.label_Twitter_whale_alert = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer_AutoCheck
            // 
            this.timer_AutoCheck.Interval = 30000;
            this.timer_AutoCheck.Tick += new System.EventHandler(this.timer_AutoCheck_Tick);
            // 
            // checkBox_binance_NowCoin
            // 
            this.checkBox_binance_NowCoin.AutoSize = true;
            this.checkBox_binance_NowCoin.Checked = true;
            this.checkBox_binance_NowCoin.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_binance_NowCoin.Location = new System.Drawing.Point(12, 12);
            this.checkBox_binance_NowCoin.Name = "checkBox_binance_NowCoin";
            this.checkBox_binance_NowCoin.Size = new System.Drawing.Size(114, 16);
            this.checkBox_binance_NowCoin.TabIndex = 0;
            this.checkBox_binance_NowCoin.Text = "binance_NowCoin";
            this.checkBox_binance_NowCoin.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(451, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button_Stop";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(354, 209);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button_Start";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label_Timer
            // 
            this.label_Timer.AutoSize = true;
            this.label_Timer.Location = new System.Drawing.Point(12, 214);
            this.label_Timer.Name = "label_Timer";
            this.label_Timer.Size = new System.Drawing.Size(71, 12);
            this.label_Timer.TabIndex = 3;
            this.label_Timer.Text = "label_Timer";
            // 
            // checkBox_Twitter_whale_alert
            // 
            this.checkBox_Twitter_whale_alert.AutoSize = true;
            this.checkBox_Twitter_whale_alert.Checked = true;
            this.checkBox_Twitter_whale_alert.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_Twitter_whale_alert.Location = new System.Drawing.Point(12, 34);
            this.checkBox_Twitter_whale_alert.Name = "checkBox_Twitter_whale_alert";
            this.checkBox_Twitter_whale_alert.Size = new System.Drawing.Size(138, 16);
            this.checkBox_Twitter_whale_alert.TabIndex = 4;
            this.checkBox_Twitter_whale_alert.Text = "Twitter_whale_alert";
            this.checkBox_Twitter_whale_alert.UseVisualStyleBackColor = true;
            // 
            // label_binance_NowCoin
            // 
            this.label_binance_NowCoin.AutoSize = true;
            this.label_binance_NowCoin.Location = new System.Drawing.Point(161, 13);
            this.label_binance_NowCoin.Name = "label_binance_NowCoin";
            this.label_binance_NowCoin.Size = new System.Drawing.Size(11, 12);
            this.label_binance_NowCoin.TabIndex = 5;
            this.label_binance_NowCoin.Text = "0";
            // 
            // label_Twitter_whale_alert
            // 
            this.label_Twitter_whale_alert.AutoSize = true;
            this.label_Twitter_whale_alert.Location = new System.Drawing.Point(161, 35);
            this.label_Twitter_whale_alert.Name = "label_Twitter_whale_alert";
            this.label_Twitter_whale_alert.Size = new System.Drawing.Size(11, 12);
            this.label_Twitter_whale_alert.TabIndex = 6;
            this.label_Twitter_whale_alert.Text = "0";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 244);
            this.Controls.Add(this.label_Twitter_whale_alert);
            this.Controls.Add(this.label_binance_NowCoin);
            this.Controls.Add(this.checkBox_Twitter_whale_alert);
            this.Controls.Add(this.label_Timer);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox_binance_NowCoin);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer_AutoCheck;
        private System.Windows.Forms.CheckBox checkBox_binance_NowCoin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label_Timer;
        private System.Windows.Forms.CheckBox checkBox_Twitter_whale_alert;
        private System.Windows.Forms.Label label_binance_NowCoin;
        private System.Windows.Forms.Label label_Twitter_whale_alert;
    }
}

