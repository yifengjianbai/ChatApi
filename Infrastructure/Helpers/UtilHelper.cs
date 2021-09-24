using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Helpers
{
  public   class UtilHelper
    {
        public static DateTime WeekStartTime
        {
            get
            {
                DateTime dt = DateTime.Now;
                int dayOfWeek = -1 * (int)dt.Date.DayOfWeek;
                //Sunday = 0,Monday = 1,Tuesday = 2,Wednesday = 3,Thursday = 4,Friday = 5,Saturday = 6,

                DateTime weekStartTime = dt.AddDays(dayOfWeek + 1);//取本周一
                if (dayOfWeek == 0) //如果今天是周日，则开始时间是上周一
                {
                    weekStartTime = weekStartTime.AddDays(-7);
                }

                return weekStartTime.Date;
            }
        }


        public static DateTime WeekEndTime
        {
            get
            {
                return WeekStartTime.AddDays(7);
            }
        }


    }
}
