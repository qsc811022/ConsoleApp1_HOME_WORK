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
               
                 DateTime dt = new DateTime(2022,01,02);
                //Console.WriteLine(dt.DayOfWeek.ToString());
                for (int i=7;i<365;i=i+7)
                {
                   Console.WriteLine(dt.AddDays(i));
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
