using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(countStack(1, 500000));
            }
            catch (StackOverflowException e)
            {
                Console.WriteLine("oops");
            }
            Console.ReadKey();
        }

        public static int countStack(int i, int amount)
        {
            
                if (i >= amount)
                    return i;
               return countStack(++i, amount);
            
        }
    }
}
