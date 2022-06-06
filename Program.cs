using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
        class Program
        {
            static void Main(string[] args)
            {
                Q1();
                Q2();
            }
            static void Q1()
            {
                DisplayHeader("Q1");
               //todo Q1
               // 顯示今年星期天的所有日期
               DateTime  dt = DateTime.Now;
               var year=Convert.ToInt32(dt.Year);
               var result = dt.Year;
                if (result % 400==0 || result %4==0 && result%100!=0)
                {
                    for (int i = 1; i < 366; i++)
                    {
                        if (i % 7 == 0)
                        {
                        Console.WriteLine(dt.AddDays(i));
                        }
                    }
                }
                else
                {
                for (int i = 1; i < 365; i++)
                {
                    if (i % 7 == 0 && dt.Year== year)
                    {
                        Console.WriteLine(dt.AddDays(i));
                    }
                }
            }

        }
            static void Q2()
            {
                DisplayHeader("Q2");
                //todoQ2
                //進階: 顯示今天的中華民國日期
                DateTime dt = DateTime.Now;
                CultureInfo culture = new CultureInfo("zh-TW");
                culture.DateTimeFormat.Calendar = new TaiwanCalendar();
                Console.WriteLine(dt.ToString("yyy/MM/dd", culture));

        }
            static void DisplayHeader(string title)
            {
                Console.WriteLine("\r\n");
                Console.WriteLine(title);
                Console.WriteLine(new string('=', 40));

            }
        }
    
}
