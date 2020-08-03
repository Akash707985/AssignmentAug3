using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29july_test
{

    class PropClass
    {
        private int day;
        private int month;
        private int year;

        public int Day
        {
            get { return day; }
            set
            {
                if (value > 0 && value < 32)
                {
                    value = day;
                    //  Console.WriteLine("Date you entered: {0}", value);
                }
                else
                {
                    Console.WriteLine("Day value is incorrect");
                }
            }
        }

        public int Month
        {
            get { return month; }
            set
            {

                if (value > 0 && value < 13)
                {
                    value = month;
                    //Console.WriteLine("Month you entered: {1}", value);
                }
                else
                {
                    Console.WriteLine("month value is incorrect");
                }
            }
        }

        public int Year
        {
            get { return year; }
            set
            {

                if (value > 2018 && value < 2020)
                {
                    value = year;
                    //Console.WriteLine("Year you entered: {1}",value);
                }
                else
                {
                    Console.WriteLine("year value is incorrect");
                }
            }
        }



    }



    class Program
    {
        static void Main(string[] args)
        {
            PropClass propc = new PropClass();
            Console.WriteLine("Enter Day");
            propc.Day = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Month");
            propc.Month = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Year");
            propc.Year = Convert.ToInt32(Console.ReadLine());

            Console.Read();
        }
    }
}