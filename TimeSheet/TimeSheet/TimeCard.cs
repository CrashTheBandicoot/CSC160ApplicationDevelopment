﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSheet
{
    public class TimeCard
    {
        public int HoursInWeek { get; set; }
        public int OverTime { get; set; }
        private const int numOfDaysInPayPeriod = 14;
        public Day[] PayPeriod = new Day[numOfDaysInPayPeriod];
        public TimeCard(DateTime payPeriodStart)
        {
            if (payPeriodStart.DayOfWeek.Equals(DayOfWeek.Sunday))
            {
                for (int i = 0; i < numOfDaysInPayPeriod; ++i)
                {
                    PayPeriod[i] = new Day(payPeriodStart.AddDays(i));
                }
            }
            else
            {
                throw new ArgumentOutOfRangeException("payPeriodStart", "payPeriodStart must be a Sunday.");
            }
        }
    }
}