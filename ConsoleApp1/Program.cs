using System;

namespace magicalnummer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program begin");

            int sum = 0;

            for (int i = 0; i <= 3; i++) {
                sum += i; 

                Console.WriteLine($"i = {i}");
                Console.WriteLine($"sum = {sum}\n");

                if (sum == 3) {
                    Console.WriteLine("We have the magical sum of 3\n");
                }
            }
            Console.WriteLine("Try again with different number ");
            Console.ReadLine();
            string again = "y";
            

            if (again == "y") {
                int total = 0;

                for (int i = 0; i <= 10; i++) {
                    total += i; 

                    Console.WriteLine($"i = {i}");

                    if (i == 10) {
                        Console.WriteLine("We have the magical sum " + i);
                    }
                }
            } 
            Console.WriteLine("program ends");
            
            
        }
    }
}
