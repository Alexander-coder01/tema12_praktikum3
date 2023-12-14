using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema12_praktikum3
{
    //Класс для 1 задачи
    internal class SquareRoot
    {
        public double number1;
        public double number2;
        public SquareRoot(){}
        public SquareRoot(double number1, double number2)
        {
            this.number1 = number1;
            this.number2 = number2;
        }
        public override string ToString()
        {
            return $"number1={number1}\tnumber2={number2}";
        }
        public void Find()
        {
            Console.WriteLine("Корень квадратный из произведения чисел = {0}", Math.Sqrt(number1 * number2));
        }
    }
}
