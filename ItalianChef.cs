using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Day_2._23_Inheritance
{
    internal class ItalianChef:Chef
    {
        public void MakesPasta()
        {
            Console.WriteLine("Makes Pasta");
        }

        public override void MakeSpecialDish()
        {
            Console.WriteLine("The chef makes Italian specials");
        }
    }
}
