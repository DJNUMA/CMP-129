using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 set of 1-100 every 10 is different colour, 1 set even are different, odd are another.
            int x = 1;

            switch (A)
                case 1:
                    while(x<10)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(x);
                        x++;
                    }
                case 2:
                    while(x>10 && x<20)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(x);
                        x++;
                    }
                case 3:
                    while(x>20 && x<30)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(x);
                        x++;
                    }
                case 4:
                    while(
            }
            
        }
    }
}
