using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema12_praktikum3
{
    //Класс для 3 задачи
    internal class Triangle
    {
        public double a;
        public double b;
        public double c;
        public Triangle()
        {

        }
        public Triangle(double a)
        {
            this.a = a;
            this.b = a;
            this.c = a;
        }
        public Triangle(double a, double b, double c) : this(a)
        {
            this.b = b;
            this.c = c;
        }
        public override string ToString()
        {
            return $"a = {a}\nb = {b}\nc = {c}";
        }
        public void Perimeter()
        {
            Console.WriteLine("Perimeter =  " + (a + b + c));
        }
    }
}
