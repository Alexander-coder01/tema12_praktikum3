using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema12_praktikum3
{
    //Класс для 2 задачи
    internal class Time
    {
        public double hours;
        public double minutes;
        public double seconds;
        public Time()
        {

        }
        public Time(double hours, double minutes)
        {
            this.hours = hours;
            this.minutes = minutes;
        }
        public Time(double hours, double minutes, double seconds) : this(hours, minutes)
        {
            this.seconds = seconds;
        }
        public override string ToString()
        {
            return $"hours = {hours}\nminutes = {minutes}\nseconds = {seconds}";
        }
        public void TotalTimeInMinutes()
        {
            Console.WriteLine("Total Time In Minutes = " + (hours *60+minutes));
        }
        public void TotalTimeInSeconds()
        {
            Console.WriteLine("Total Time In Seconds = {0}",(hours * 60 + minutes) * 60 + seconds);
        }
    }
}
