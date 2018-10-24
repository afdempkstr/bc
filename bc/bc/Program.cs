using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bc
{
    class Program
    {
        static void Main(string[] args)
        {
            if ( args.Length == 0 )
            {
                Console.WriteLine("No number provided!");
                return;
            }

            int number = 0;
            number = int.Parse(args[0]);

        }
    }
}
