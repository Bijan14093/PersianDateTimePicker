using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace PersianDateTimeControl
{
    internal static class Utility
    {
        public static PersianCalendar PersianCalendar = new PersianCalendar();
        private static System.Globalization.CultureInfo Persiancalture = new System.Globalization.CultureInfo("fa-IR");
        private static string[] allFormats = { "yyyy/MM/dd", "yyyy/M/d", "dd/MM/yyyy", "d/M/yyyy", "dd/M/yyyy", "d/MM/yyyy", "yyyy-MM-dd", "yyyy-M-d", "dd-MM-yyyy", "d-M-yyyy", "dd-M-yyyy", "d-MM-yyyy", "yyyy MM dd", "yyyy M d", "dd MM yyyy", "d M yyyy", "dd M yyyy", "d MM yyyy" };
        private static DateTimeFormatInfo PersianDateTimeFormatInfo= Persiancalture.DateTimeFormat;

        internal static PersianDate GetPersianDate(DateTime datetime)
        {
            Initialize();
            PersianDate p = new PersianDate();
            p.FullDatePersian = datetime.ToString("yyyy/MM/dd", PersianDateTimeFormatInfo);
            p.Year = Convert.ToInt32(p.FullDatePersian.Substring(0, 4));
            p.Month = Convert.ToInt32(p.FullDatePersian.Substring(5, 2));
            p.Day = Convert.ToInt32(p.FullDatePersian.Substring(8, 2));
            p.FullDate = ((DateTime)datetime).ToString("yyyy/MM/dd"); ;

            return p;
        }

        private static void Initialize()
        {
            if (System.Threading.Thread.CurrentThread.CurrentUICulture == Persiancalture)
            {
                return;
            }
            typeof(System.Globalization.DateTimeFormatInfo).GetField("calendar", System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).SetValue(PersianDateTimeFormatInfo, PersianCalendar);
            typeof(System.Globalization.CultureInfo).GetField("calendar", System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).SetValue(Persiancalture, PersianCalendar);
            typeof(System.Globalization.CultureInfo).GetField("calendar", System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).SetValue(Persiancalture, PersianCalendar);
            System.Threading.Thread.CurrentThread.CurrentUICulture = Persiancalture;
            System.Globalization.CultureInfo.CurrentUICulture.DateTimeFormat = PersianDateTimeFormatInfo;
        }

        internal static DateTime GetDateTime(string PersianDate)
        {
            Initialize();
            return  DateTime.ParseExact(PersianDate, allFormats, PersianDateTimeFormatInfo, DateTimeStyles.AllowWhiteSpaces);
        }
    }
}
