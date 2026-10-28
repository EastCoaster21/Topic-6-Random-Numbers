using System;
using System.Reflection.Emit;

namespace Topic_6_Random_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Random generator = new Random();
            int randNum;
            int lowNum;
            int highNum;
            Random generator = new Random();
            randNum = generator.Next(10);

            Console.WriteLine("My random number is " + randNum);
            Console.WriteLine("Here are some numbers from 0 to 5!");
            Console.Write(generator.Next(1, 6) + " ");
            Console.Write(generator.Next(1, 6) + " ");
            Console.Write(generator.Next(1, 6) + " ");
            Console.Write(generator.Next(1, 6) + " ");
            Console.Write(generator.Next(1, 6) + " ");
            Console.WriteLine(generator.Next(1, 6) + " ");
            Console.WriteLine();
            Console.WriteLine("Here are some numbers from 0 to 99!");
            Console.Write(generator.Next(101) + " ");
            Console.Write(generator.Next(101) + " ");
            Console.Write(generator.Next(101) + " ");
            Console.Write(generator.Next(101) + " ");
            Console.Write(generator.Next(101) + " ");
            Console.WriteLine(generator.Next(101) + " ");
            Console.WriteLine();
            int num1 = generator.Next(10);
            int num2 = generator.Next(10);
            if (num1 == num2)
            {
                Console.WriteLine("The random numbers were the same! Weird.");
            }
            if (num1 != num2)
            {
                Console.WriteLine("The random numbers were different! Not weird. ");
            }
            Console.WriteLine("Kewl.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Please enter a random number between 1 and 50.");
            lowNum = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            if (lowNum <= 0)
            {
                Console.WriteLine("That's not in the range of numbers.");
               
            }
            else if (lowNum <= 51)
            {
                Console.WriteLine("");
            }
            else if (lowNum >= 51)
            {
                Console.WriteLine("Number is to high.");
                
            }
        }
    }
}
