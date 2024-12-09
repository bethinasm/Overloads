using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloads
{
    internal class Welcome
    {
        public void PrintMessage()
        {
            Console.WriteLine("Hello and welcome!");
            Console.WriteLine();
        }

        public void PrintMessage(string compliment)
        {
            Console.WriteLine("Hello and welcome! " + compliment);
            Console.WriteLine();
        }
    }
}