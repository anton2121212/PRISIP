using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema23
{
    class Program
    {
        //задача 1
        //enum Month
        //{
        //    январь, февраль, март, апрель, май, июнь, июль, август, сентябрь, октябрь, ноябрь, декабрь
        //}


        //задача 2
        //enum Days
        //{
        //    Sat, Sun, Mon, Tue, Wed, Thu, Fri 
        //}

        //задача 3
       
  
        static void Main(string[] args)
        {
            //задача 1
            //Month i;
            //for (i=Month.январь; i<=Month.декабрь; i++)
            //{
            //    Console.WriteLine($"{(int)i}      {i}");
            //}


            //задача 2
            //Days i;
            //for (i = Days.Sat; i <= Days.Fri; i++)
            //{
            //    Console.WriteLine($"{i} имеет значение {(int)i}");
            //}


            //задача 3

            Console.WriteLine("Введите первое число=");
            double x = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число=");
            double y = double.Parse(Console.ReadLine());




            DoOperation.Dooperation(x, y, DoOperation.Operation.Add);
            DoOperation.Dooperation(x, y, DoOperation.Operation.Subtract);
            DoOperation.Dooperation(x, y, DoOperation.Operation.Multiply);
            DoOperation.Dooperation(x, y, DoOperation.Operation.Divide);       

            Console.ReadKey();
        }
    }
}
