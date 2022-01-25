using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    //this delegate will hold the event publisher
    public delegate void eventVoidDelegate();
    //this delegate returns and string
    public delegate string eventStringDelegate(string s);
    class Program
    {
        //creates an event for the void delegate
        public static event eventVoidDelegate voidPublisher;
        // creates an event publisher for the string delegate
        public static event eventStringDelegate stringPublisher;
        static void Main(string[] args)
        {
            //the publisher takes functions to run
            voidPublisher += GoodBye;
            stringPublisher += SayWhat;
            Hello();
            Console.ReadLine();
            
        }
        //hello() is the function the activates the events

        public static void Hello()
        {
            string s;
            Console.WriteLine("Hello");

            //activates the events
            voidPublisher();
            Console.WriteLine(stringPublisher("what"));
        }
        public static void GoodBye()
        {
            Console.WriteLine("Good bye");
        }
        public static string SayWhat(string s)
        {
            return s;
        }

        
    }
}
