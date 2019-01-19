using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace _05_Date_Modifier
{
    public class DateModifier
    {
       public DateModifier()
        {
            this.Days = new List<int>();
        }

        private List<int> days;
        public List<int> Days
        {
            get { return days; }
            set { days = value; }
        }
        public void GetDays(string date1, string date2)
        {
            DateTime date1st = DateTime.ParseExact(date1, "yyyy MM dd", CultureInfo.InvariantCulture);
            DateTime date2nd = DateTime.ParseExact(date2, "yyyy MM dd", CultureInfo.InvariantCulture);
            int daysDiff = (date1st - date2nd).Days;
            this.Days.Add(Math.Abs(daysDiff));
        }
    }
}
