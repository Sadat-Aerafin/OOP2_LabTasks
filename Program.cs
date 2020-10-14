using System;

namespace OOP2_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            Console.WriteLine("Hello ");
            Console.WriteLine("Sadat Aerafin ");
            //2  //3
            int x = 10;
            int y = 5;
            int z = x + y;
            int p = x / y;
            Console.WriteLine("The Sum is: " + z);
            Console.WriteLine("The divition is: " + p);

            //4_a

            Console.WriteLine(-5 + 8 * 6);

            //4_b
            Console.WriteLine((55 + 9) % 9);

            //4_c
            Console.WriteLine(20 + -3 * 5 / 8);

            //4_d

            Console.WriteLine(5 + 15 / 3 * 2 - 8 % 3);


            //5
            int a = 12;
            int b = 4;
            int c = a + b;
            int d = a - b;
            int e = a * b;
            int f = a / b;
            int g = a % b;
            Console.WriteLine("The sum is :" +c);
            Console.WriteLine("The sub is :" +d);
            Console.WriteLine("The mul is :" +e);
            Console.WriteLine("The div is :" +f);
            Console.WriteLine("The rem is :" +g);


            //6

            Console.WriteLine((25.5 * 3.5 - 3.5 * 3.5) / (40.5 - 4.5));


            //7

            double width = 5.6;
            double height = 8.5;
            double area = width * height;
            double perimeter = 2 * (width + height);

            Console.WriteLine("Area is 5.6 * 8.5 =" + area);
            Console.WriteLine("Perimeter is 2 * (5.6 + 8.5) =" + perimeter);



        }
    }
}
