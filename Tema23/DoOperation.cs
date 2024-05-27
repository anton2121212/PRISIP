using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema23
{
    class DoOperation
    {
        public enum Operation
        {
            Add,
            Subtract,
            Multiply,
            Divide
        }
        public static double Dooperation(double x, double y, Operation op)
        {
            //double result = op switch
            //{
            //    Operation.Add => x + y,
            //    Operation.Subtract => x - y,
            //    Operation.Multiply => x * y,
            //    Operation.Divide => x / y
            //};
            double result = 0;
            switch (op )
            {
                case Operation.Add: result = x + y; break;
                case Operation.Subtract: result = x - y; break;
                case Operation.Multiply: result = x * y; break;
                case Operation.Divide: result = x * y; break;
                default: Console.WriteLine("ошибка");
                    break;
            }

            return result;
        }
    }
}
