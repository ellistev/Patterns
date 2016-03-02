using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class SuperAwesomeAdapterPattern
    {
        private static readonly ICanDoTheseThings FirstThings = new First();
        private static readonly ICanDoTheseThings SecondThings = new Second();
        private static ICanDoTheseThings TheseThings;
        static void Main(string[] args)
        {
            //adapter pattern
            ICanDoThis thisthing = new Dontkniwadapter(new DontKniw());
            thisthing.dothis();
            Console.ReadLine();

            //strategy pattern
            for (int x = 0; x < 10; x++)
            {
                DoStuff();
            }

            Console.ReadLine();
        }

        public static void DoStuff()
        {
            TheseThings = (TheseThings == FirstThings ? SecondThings : FirstThings);
            TheseThings.dothisthing();
        }
    }
}
