using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinComment
{
    class OperaTimeStamp
    {
        /// <summary>
        /// 时间类型变成long类型时间戳(13位)
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        public static long DateTimeToTimestamp(DateTime time)
        {
            DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));
            //return Convert.ToInt64((time - startTime).TotalMilliseconds);
            return (time.Ticks - startTime.Ticks) / 10000;//除10000调整为13位
        }

        /// <summary>
        /// string类型时间戳转换为时间
        /// </summary>
        /// <param name="strTimeStamp"></param>
        /// <returns></returns>
        public static DateTime StampToDateTime(string strTimeStamp)
        {
            DateTime dateTimeStart = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));
            long lTime = long.Parse(strTimeStamp + "0000");//+ "0000000"
            TimeSpan toNow = new TimeSpan(lTime);
            return dateTimeStart.Add(toNow);
        }

        /// <summary>
        /// double类型时间戳转换为时间
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        public static DateTime ConvertIntDateTime(double d)
        {
            System.DateTime time = System.DateTime.MinValue;
            System.DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1));
            time = startTime.AddMilliseconds(d);
            return time;
        }
    }
}
