using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema12_praktikum3
{
    //Класс для 4 задачи
    internal class Car
    {
        public string make;
        public string model;
        public string number;
        public Car()
        {
            
        }

        public Car(string make, string model, string number)
        {
            this.make = make;
            this.model = model;
            this.number = number;
        }   
        public void Start()
        {
            Console.WriteLine("Машина {0} {1} {2} завелась", make, model, number);
        }
        public void Stop()
        {
            Console.WriteLine("Машина {0} {1} {2} остановилась", make, model, number);
        }
    }
}
