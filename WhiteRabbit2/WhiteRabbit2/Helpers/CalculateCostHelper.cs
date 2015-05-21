using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhiteRabbit2.Models;

namespace WhiteRabbit2.Helpers
{
    public static class CalculateCostHelper
    {

        // in minutes
        public static int GetTimeForEatingByOrderId(int orderId)
        {
            using (var db = new OrderContext())
            {
                var times = db.Courses.Where(x => x.Order.OrderId == orderId).Select(x => x.TimeForEating);
                return Enumerable.Sum(times, time => Int32.Parse(time));
            }
        }
        public static int GetTimeForCookingByOrderId(int orderId)
        {
            using (var db = new OrderContext())
            {
                var times = db.Courses.Where(x => x.Order.OrderId == orderId).Select(x => x.TimeForCooking);
                return Enumerable.Sum(times, time => Int32.Parse(time));
            }
        }

        public static int GetHoursFromMinutes(int minutes)
        {
            if (minutes%60 == 0)
            {
                return minutes/60;
            }
            return minutes/60 + 1;
        }

        public static double GetTotalPrice(int n)
        {
            double result = 0;
            for(int i = n; i >= 1; i--)
            {
                result += 1000.0 / Fibonacci(i);
            }
            return Math.Round(result, 2);

        }

        //Recursion.
        private static int Fibonacci(int n)
        {
            return n > 1 ? Fibonacci(n - 1) + Fibonacci(n - 2) : n;
        }
    }
}
