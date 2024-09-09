using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroOOP
{
    internal class Testing
    {
        private int num;

        public static void TryFoorLoop()
        {
            for (int i = 0; i < 5; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("It is 0");
                }
                else if (i == 2)
                {
                    Console.WriteLine("It is 2");
                }
                else
                {
                    Console.WriteLine("Others");
                }


                switch (i)
                {
                    case 0:
                        Console.WriteLine("It is 0");
                        break;
                    case 2:
                        Console.WriteLine("It is 2");
                        break;
                    default:
                        Console.WriteLine("Others");
                        break;
                }
            }
        }

        public static void TryDoWhileLoop()
        {
            int j = 0;
            do
            {
                Console.WriteLine("Different");
            } while (j != 0);
        }
    }
}
