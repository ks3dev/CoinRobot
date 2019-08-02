using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinRobot.Models
{
    public class Public
    {
        /// <summary>
        /// 公共返回类
        /// </summary>
        public class Result
        {
            private bool getData = false;
            /// <summary>
            /// 获取数据是否成功
            /// </summary>
            public bool GetData
            {
                get { return getData; }
                set { getData = value; }
            }
        }

    }
}
