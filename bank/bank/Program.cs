using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    class Program
    {
        static void Main(string[] args)
        {
            //حق واجب البنك
            while (true)
            {
                Console.WriteLine("1--ssssss");
                Console.WriteLine("2--ooo");
                Console.WriteLine("3--vv");

                Console.WriteLine("what did yoy want");
                int x = Convert.ToInt32(Console.ReadLine());
                if (x == 1)
                {
                    Console.WriteLine("how much do you want");
                    int y = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("ok");
                }
                if (x == 2)
                {
                    Console.WriteLine("how much to eeeeda");
                    int y = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("ok");
                }
                else
                {
                    Console.WriteLine("to exite");
                }

            }

        }
    }
}
