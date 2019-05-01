using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("-----biniary to decimal-----");
            //string userinput;
            //Console.WriteLine("Give me a binary number");
            //userinput = Console.ReadLine();
            //string number;
            //number = Convert.ToInt32(userinput, 2).ToString();
            //Console.WriteLine($"Binary : {userinput} -> Decimal : {number}");
            //Console.ReadLine();
            //string userinput;
            //Console.WriteLine("Give me a binary number");
            //userinput = Console.ReadLine();
            //int number;

            //bool canconvert = int.TryParse(userinput, out number);
            //if (canconvert)
            //{
            //    userinput = Convert.ToString(number);
            //    string deci = Convert.ToInt32(userinput, 2).ToString();
            //    Console.WriteLine($"Binary : {userinput} -> Decimal : {deci}");
            //    Console.ReadLine();
            //}
            //else
            //{
            //    Console.WriteLine("Not valid.");
            //    Console.ReadLine();
            //}

            //Console.WriteLine("-----decimal to binary-----");
            //string userinput2;
            //Console.WriteLine("Give me a decimal number");
            //userinput2 = Console.ReadLine();
            //int number2;
            //bool canconvert2 = int.TryParse(userinput2, out number2);

            //if (canconvert2)
            //{
            //    string binary = Convert.ToString(number2, 2);
            //    Console.WriteLine($"Decimal : {number2} -> Binary : {binary}");
            //    Console.ReadLine();
            //}
            //else
            //{
            //    Console.WriteLine("Not valid.");
            //    Console.ReadLine();
            //}

            Console.WriteLine("-----create an array-----");
           
            Console.WriteLine("How long you want it?");
            bool isNumber = int.TryParse(Console.ReadLine(), out int size);
            
                Console.WriteLine("type name for the array.");
                string[] name = new string Console.ReadLine()[]{ };
                name = new string[size]{ };
           
            if (isNumber)
            {

                Console.WriteLine($"Input {size} data");
                Console.WriteLine("{");
                for (int i = 0; i < size; i += 1)
                {
                    a{i} = Console.ReadLine();
                    Console.WriteLine($"{Console.ReadLine()},");
                }
                Console.ReadLine();
            }

            


        }
    }
}
