using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World
{
    internal class Program
    {
        //entry point of our program
        static void Main(string[] args)
        {
 
            string myName = "Duane";
            string capsMessage = myName.ToUpper();
            string lowerMessage = capsMessage.ToLower();
            Console.WriteLine("My name is "+ capsMessage);
        }
    }
}
