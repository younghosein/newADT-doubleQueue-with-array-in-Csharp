using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Adt_Example_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Adt q = new Adt(20);
            q.insert(34);
            q.insert(54);
            q.insert(-23);
            q.insert(99);
            q.insert(59);
            q.insert(-16);
            q.insert(-19);
            q.insert(-7);
            q.insert(84);
            q.insert(-90);
            q.insert(-13);
            q.insert(77);

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Queue Is : ");
            q.print();
            Console.ResetColor();
            Console.WriteLine("\n\n");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Enter The Choice Remove ( R Or L ) : ");
            string ch1 = Console.ReadLine();
            if (ch1 == "l" || ch1 == "l")
                q.remove(true);
            else if (ch1 == "r" || ch1 == "R")
                q.remove(false);
            Console.WriteLine("\nNow Queue Is : ");
            q.print();
            Console.ResetColor();
            Console.WriteLine("\n\n");

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Enter The Choice To Remove ( R Or L ) : ");
            string ch2 = Console.ReadLine();
            if (ch2 == "l" || ch2 == "L")
                q.remove(true);
            else if (ch2 == "r" || ch2 == "R")
                q.remove(false);
            Console.WriteLine("\nNow Queue Is : ");
            q.print();
            Console.ResetColor();
            Console.WriteLine("\n\n");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("The Length Of New Adt ( Double Queue Is ) : ");
            int l = q.length();
            Console.WriteLine(l);
            Console.ResetColor();
            Console.WriteLine("\n");

            Console.WriteLine("Please Enter A Number To Check & Insert : ");
            int i = int.Parse(Console.ReadLine());
            q.insert(i);
            Console.WriteLine("\nNow Queue Is : ");
            q.print();
            Console.ResetColor();
            Console.WriteLine("\n\n");

            Console.ReadKey();
        }
    }
}
