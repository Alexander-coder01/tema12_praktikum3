using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema12_praktikum3
{
    internal class Newspaper
    {
        public string title;
        public int circulation;
        public int stripes;
        public void Init(string title, int circulation, int stripes)
        {
            this.title = title;   
            this.circulation = circulation;
            this.stripes = stripes;
        }
        public void Info()
        {
            Console.WriteLine($"title = {title}     circulation = {circulation}     stripes = {stripes}");
        }
        public void ChangeName(string title)
        {
            this.title = title;
        }
        public void ChangeNumber(int stripes)
        {
            this.stripes = stripes;
        }
        

    }
}
