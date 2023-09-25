using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern
{
    internal class Program
    {
        private static bool intersted;

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the problem Numbers:"+
                "\n 1.Pattern.\n"+
                "\n 2.BoxPattern.\n 0---QUIT");
                int choice =int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter the number of lines to print the triangle");
                    int num = int.Parse(Console.ReadLine());
                    Pattern p = new Pattern();
                    p.Test(num);
                    Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("Enter the rows");
                    int n = int.Parse(Console.ReadLine());
                    BoxPattern bp = new BoxPattern();
                    bp.Assign(n);
                    Console.ReadLine();
                    break;
                case 0:
                    if (choice == 0)
                    {
                        intersted = false;
                        Console.WriteLine("Thanks for your interst");
                    }
                    break;
            }
        }
    }
}
