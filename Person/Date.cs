using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    internal class Date
    {
        int year;
        int month;
        int day;
        public Date(int year, int month, int day)
        {
            this.year = year; this.month = month; this.day = day;
        }
        public int GetYear()
        {
            return this.year;
        }
        public void SetYear(int year)
        {
            this.year = year;
        }

        public int GetMonth()
        {
            return this.month;
        }
        public void SetMonth(int month)
        {
            this.month = month;
        }

        public int GetDay()
        {
            return this.day;
        }
        public void SetDay(int day)
        {
            this.day = day;
        }
    }
}
