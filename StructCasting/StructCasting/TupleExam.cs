using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructCasting
{
    class WeekdayResult
    {
        public bool IsWeekDay { get; set; }
        public string WeekDay { get; set; }
    }
    class TupleExam
    {
        public static WeekdayResult CheckWeekDay(int num)
        {
            WeekdayResult result = new WeekdayResult();
            result.IsWeekDay = true;
            switch (num)
            {
                case 1:
                    result.WeekDay = nameof(Weekdays.Monday);
                    return result;
                case 2:
                    result.WeekDay = nameof(Weekdays.Tuesday);
                    return result;
                case 3:
                    result.WeekDay = nameof(Weekdays.Wednesday);
                    return result;
                case 4:
                    result.WeekDay = nameof(Weekdays.Thursday);
                    return result;
                case 5:
                    result.WeekDay = nameof(Weekdays.Friday);
                    return result;
                case 6:
                    result.WeekDay = nameof(Weekdays.Saturday);
                    return result;
                case 7:
                    result.WeekDay = nameof(Weekdays.Sunday);
                    return result;
                default:
                    result.WeekDay = "";
                    result.IsWeekDay = false;
                    return result;
            }
        }
        public static (bool, string) CheckWeekDayWithTuple(int num)
        {
            (bool IsWeekDay, string WeekDay) result = new(false,"");
            result.IsWeekDay = true;
            switch (num)
            {
                case 1:
                    result.WeekDay = nameof(Weekdays.Monday);
                    return result;
                case 2:
                    result.WeekDay = nameof(Weekdays.Tuesday);
                    return result;
                case 3:
                    result.WeekDay = nameof(Weekdays.Wednesday);
                    return result;
                case 4:
                    result.WeekDay = nameof(Weekdays.Thursday);
                    return result;
                case 5:
                    result.WeekDay = nameof(Weekdays.Friday);
                    return result;
                case 6:
                    result.WeekDay = nameof(Weekdays.Saturday);
                    return result;
                case 7:
                    result.WeekDay = nameof(Weekdays.Sunday);
                    return result;
                default:
                    result.WeekDay = "";
                    result.IsWeekDay = false;
                    return result;
            }
        }
    }
}
