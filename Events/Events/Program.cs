using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    //this delegate will hold the event publisher
    public delegate void eventDelegate();

    class Program
    {
        //creates the publisher of the event
        public static event eventDelegate publisher;
        static void Main(string[] args)
        {
            //the publisher takes functions to run
            publisher += GoodBye;

            Hello();

            Console.ReadLine();
            
        }

        public static void Hello()
        {
            Console.WriteLine("Hello");
            //activates the event
            publisher();
        }
        public static void GoodBye()
        {
            Console.WriteLine("Good bye");
        }

        
    }
}
