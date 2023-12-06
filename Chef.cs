using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2._23_Inheritance
{
    internal class Chef
    {
        public void MakesChicken()
        {
            Console.WriteLine("The chef makes Chicken");
        }

        public void MakeSalad()
        {
            Console.WriteLine("The chef makes salad");
        }

        public virtual void MakeSpecialDish()
        {
            Console.WriteLine("The chef makes Special dish");
        }
    }   
}
