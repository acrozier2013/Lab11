using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09
{
    class Program
    {
        static void GetResult(string[] args)
        //{
        //    MyMath mathproblem1 = new MyMath();
        //    MyMath mathproblem2 = new MyMath();

        //    mathproblem1.operand1 = 2;
        //    mathproblem1.operand2 = 2;

        //    mathproblem1.result = 0;
        //    mathproblem1.GetResult();

        //    Console.WriteLine(mathproblem1.GetResult());


        {
            MyMath myFirstCar = new MyMath();
            MyMath mySecondCar = new MyMath();
            MyMath myThirdCar = new MyMath();

            myFirstCar.operand1 = 2;
            myFirstCar.operand2 = 2;
            myFirstCar.result = 280;
            myFirstCar.setResult(280);
                        //myFirstCar.speedUp();
                        //myFirstCar.speedUp();
            Console.WriteLine(myFirstCar.getResult());
            //for (int i = 0; i <= 200; i++)
            //{
            //    myFirstCar.speedUp();
            //}
            myFirstCar.ToString();

           
        }
    }
}
