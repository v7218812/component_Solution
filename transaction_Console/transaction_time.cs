using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace transaction_Console
{
    internal class transaction_time
    {
        static void Main(string[] args)
        {
            //抓入目前時間資料
            //var dt = DateTime.Now;
            //抓入目前時間資料中的星期
            //int i = Convert.ToInt32(dt.DayOfWeek);
            //抓入目前時間資料中的小時分鐘
            //TimeSpan start = new TimeSpan(09, 0, 0);
            //TimeSpan end = new TimeSpan(13, 30, 0);
            //TimeSpan now = dt.TimeOfDay;
            //if ((now > start) && (now < end) && (Week(i) == true))
            //{
            //    Console.WriteLine("現在是營業時間"); 
            //}
            //else { Console.WriteLine("現在不是營業時間"); }
            if (Time.isTradingHours(DateTime.Now) == true)
            {
                Console.WriteLine("現在是營業時間");
            }
            else { Console.WriteLine("現在不是營業時間"); }

        }

        public static class Time
        {
            public static bool isTradingHours(DateTime dt)
            {
                //抓入目前時間資料中的星期
                int i = Convert.ToInt32(dt.DayOfWeek);
                //抓入目前時間資料中的小時分鐘
                TimeSpan start = new TimeSpan(09, 0, 0);
                TimeSpan end = new TimeSpan(13, 30, 0);
                TimeSpan now = dt.TimeOfDay;

                // 判斷是否是周末及是否在營業時間
                if (Week(i)==true && now>start && now<end)
                {
                    return true;
                }
                else
                {
                    return false;
                }


                
            }
 
        }
        //判斷是否為周末(0表示星期天6表示星期六)
        public static bool Week(int i)
        {
            if (i == 0 && i == 6)
                return false;
            else
                return true;
        }


    }
}
