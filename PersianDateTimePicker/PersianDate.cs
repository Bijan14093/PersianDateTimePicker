using System;

namespace PersianDateTimeControl
{
    internal  class PersianDate
    {
        public int Year { get; internal set; }
        public int Month { get; internal set; }
        public int Day { get; internal set; }
        public string FullDate { get; internal set; }
        public string FullDatePersian { get; internal set; }
    }
}