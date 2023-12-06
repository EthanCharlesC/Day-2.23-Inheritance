using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2._23_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Chef chef = new Chef();
            chef.MakesChicken();


            ItalianChef chef1 = new ItalianChef();
            chef1.MakesChicken();
            chef1.MakesPasta();
            chef1.MakeSpecialDish();

            Console.ReadKey();
        }
    }
}
