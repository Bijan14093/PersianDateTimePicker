using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace PersianDateTimeControl
{
    internal static class Utility
    {
        public static PersianCalendar PersianCalendar = new PersianCalendar();
        public  static CultureInfo CultureInfo = new CultureInfo("fa-Ir");

        internal static PersianDate GetPersianDate(DateTime datetime)
        {
            PersianDate p = new PersianDate();
            p.FullDatePersian = datetime.ToString("yyyy/MM/dd", Utility.CultureInfo.DateTimeFormat);
            p.Year = Convert.ToInt32(p.FullDatePersian.Substring(0, 4));
            p.Month = Convert.ToInt32(p.FullDatePersian.Substring(5, 2));
            p.Day = Convert.ToInt32(p.FullDatePersian.Substring(8, 2));
            p.FullDate = ((DateTime)datetime).ToString("yyyy/MM/dd"); ;

            return p;
        }
    }
}
