using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrozierLabWk11
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] names = {"Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford"};

            //Console.WriteLine(names[1]);
            //Console.WriteLine(names[names.Length - 1]);


            //string[] months = new string[12];

            //months[0] = "January";
            //months[1] = "February";
            //months[2] = "March";
            //months[3] = "April";
            //months[4] = "May";
            //months[5] = "June";
            //months[6] = "July";
            //months[7] = "August";
            //months[8] = "September";
            //months[9] = "October";
            //months[10] = "November";
            //months[11] = "December";

            //for (int i = 0; i < months.Length; i++)
            //{
            //    Console.WriteLine((i) + ": " + months[i]);
            //}


            //string[] seasons = {"Spring", "Summer", "Fall", "Winter"};

            //foreach (string season in seasons)
            //{
            //    Console.WriteLine(season);
            //}

            int[] randomNum = new int[1000];
            Random random = new Random();

            for (int i = 0; i < randomNum.Length; i++)
            {
                randomNum[i] = random.Next(0, 1000);
            }

            foreach (int a in randomNum)
            {
                Console.WriteLine(a.ToString());
            }
        }
    }
}










