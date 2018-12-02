using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09
{
    class MyMath
    {
        //public double operand1;
        //public double operand2;

        //public double result;

        //public void GetResult(double result, double operand1, double operand2)
        //{
        //    this.result = operand1 * operand2;    
        //}


        public double operand1;
        public double operand2;
        public int year;
        public string color;

        private int speed;
        public int result;
        

        public void setResult(int setResult)
        {
            this.result = setResult;
        }

        public int getResult()
        {
            return result;
        }

        public void Honk()
        {
            Console.WriteLine("Honk Honk");
        }

        public void Beep()
        {
            Console.WriteLine("Beep Beep");
        }


        //public void speedUp()
        //{
        //    if (speed < topSpeed)
        //    {
        //        speed++;
        //    }
        //    Console.WriteLine("Speeding Up....");
        //}

        public void slowDown()
        {
            if (speed > 0)
            {
                speed--;
            }
            Console.WriteLine("Slowing Down....");
        }

        public void ToString()
        {
            Console.WriteLine("I'm a " + operand1 + " " + operand2 + " and I'm going " + speed + "mph");
        }
    }
}
