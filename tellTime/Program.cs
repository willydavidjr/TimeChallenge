using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tellTime
{
    class Program
    {
        static void Main(string[] args)
        {
            string strTime = @"12:58";
            string result = tellTime(strTime);
        }

        static string tellTime(string time_str)
        {
            Dictionary<int, string> d = new Dictionary<int, string>()
            {
                {1, "one" },
                {2, "two" },
                {3, "three"},
                {4, "four" },
                {5, "five" },
                {6, "six" },
                {7, "seven" },
                {8, "eight" },
                {9, "nine" },
                {10, "ten" },
                {11, "eleven" },
                {12, "twelve" },
                {20, "twenty" },
                {25, "twenty five" },
                {35, "thirty five" },
                {40, "fourty" },
                {50, "fifty" },
                {55, "fifty five" },
            };
            double doubleResult = Math.Round(time_str.Split(':').ToArray().Select(x=>int.Parse(x)).Skip(1).SingleOrDefault() / 5.0) * 5;
            int y = time_str.Split(':').ToArray().Select(x => int.Parse(x)).Take(1).SingleOrDefault();

            if (doubleResult == 0)
                return string.Format("It's {0} o'clock", d[y]);

            if (doubleResult <= 29)
            {
                if (doubleResult == 15)
                    return string.Format("It's quarter past {0}", d[y]);
                return string.Format("It's {0} past {1}", d[Convert.ToInt32(doubleResult)], d[y]);
            }
            if (doubleResult == 30)
                return string.Format("It's half past {0}", d[y]);
            if (doubleResult > 30 && doubleResult <= 59)
            {
                //string p = (y + 1).ToString();
                if (doubleResult == 45)
                    return string.Format("It's quarter to {0}", (y + 1) == 13 ? "one" : d[(y + 1)]);
                if (doubleResult  < 45)
                    return doubleResult == 40 ? string.Format("It's twenty to {0}", (y + 1) == 13 ? "one" : d[(y + 1)]) : string.Format("It's twenty five to {0}", (y + 1) == 13 ? "one" : d[(y + 1)]);
                return doubleResult == 50 ? string.Format("It's ten to {0}", (y + 1) == 13 ? "one" : d[(y+1)]) : string.Format("It's five to {0}", (y + 1) == 13 ? "one" : d[(y + 1)]);
            }

            return string.Format("It's {0} o'clock", (y + 1) == 13 ? "one" : d[(y + 1)]);
        }
    }
}

