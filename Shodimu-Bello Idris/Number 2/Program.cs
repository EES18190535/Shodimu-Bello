using System;

namespace Number_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter values for a");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter values for b");
            int b = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter values for c");
            int c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter values for d");
            int d = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter values for e");
            int e = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter values for f");
            int f = Convert.ToInt32(Console.ReadLine());

            double s = e*d - f*b;
            double g = a*d - b*c;

            double r = a*f - e*c;
            double o = a*d - b*c;

            double x = s/g;
            double y = r/g;

            

            if (o == 0) 
            {
                System.Console.WriteLine("The equation has no solution");

            }
            else
            {
                Console.WriteLine("x is:"+x);
                Console.WriteLine("y is:"+y);
            }
        }
    }
}
