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

            //Console.WriteLine("-----create an array-----");

            //Console.WriteLine("How long you want it?");
            //bool isNumber = int.TryParse(Console.ReadLine(), out int size);//check if it is number or not

            //Console.WriteLine("-----cm to feet-----");
            //Console.WriteLine("How tall are you in cm?");
            //isNumber = double.TryParse(Console.ReadLine(), out double height);//check if it is number or not
            //double feet = 0.0, inch= 0.0;
            //while (height > 0)
            //{
            //    if (isNumber)
            //    {
            //        feet = Math.Floor((height / 2.54) / 12);
            //        //make it an integer by using math.floor
            //        inch = Math.Floor((((height / 2.54) / 12) - feet) * 10);
            //        //(height / 2.54) / 12) this returns like 1.2345
            //        //I just want 2 so substruct feet and mutiple by 10 then use math.floor 
            //        Console.WriteLine($"cm : {height} -> feet/inch : {feet}'{inch}");
            //        Console.ReadLine();

            //    }
            //    else
            //    {
            //        Console.WriteLine("Type a number.");
            //        Console.ReadLine();
            //    }
            //}
            //Console.WriteLine("Not valid.");
            //Console.ReadLine();


            //Console.WriteLine("-----print the word of the number-----");
            //Console.WriteLine("Type a number between 0-9.");
            //isNumber = int.TryParse(Console.ReadLine(), out int number);

            //if (isNumber)
            //{
            //    switch (number)
            //    {
            //        case 0:
            //            Console.WriteLine("0 : ZERO");
            //            break;
            //        case 1:
            //            Console.WriteLine("1 : ONE");
            //            break;
            //        case 2:
            //            Console.WriteLine("2 : TWO");
            //            break;
            //        case 3:
            //            Console.WriteLine("3 : THREE");
            //            break;
            //        case 4:
            //            Console.WriteLine("4 : FOUR");
            //            break;
            //        case 5:
            //            Console.WriteLine("5 : FIVE");
            //            break;
            //        case 6:
            //            Console.WriteLine("6 : SIX");
            //            break;
            //        case 7:
            //            Console.WriteLine("7 : SEVEN");
            //            break;
            //        case 8:
            //            Console.WriteLine("8 : EIGHT");
            //            break;
            //        case 9:
            //            Console.WriteLine("9 : NINE");
            //            break;
            //        default:
            //            Console.WriteLine("Not available.");
            //            break;
            //    }
            //    Console.ReadLine();
            //}
            //Console.WriteLine("Try again.B");
            //Console.ReadLine();

            int count1 = 0, count2 = 0, count3 = 0, count4 = 0, count5 = 0, count6 = 0;
            Random random = new Random();//set rondom
            Console.WriteLine("-----throw a dice 100 times and count the each roll.");
            for (int i = 0; i < 100; i += 1)//100 times trial
            {
                
                int roll = random.Next(1, 7);
                //set min and max (min,max).i dont know why but it seems that the value of min is included but max is excluded from the result

                switch (roll)
                {
                    case  1:
                        count1 = count1 + 1;
                        break;
                    case  2:
                        count2 = count2 + 1;
                        break;
                    case  3:
                        count3 = count3 + 1;
                        break;
                    case  4:
                        count4 = count4 + 1;
                        break;
                    case  5:
                        count5 = count5 + 1;
                        break;
                    case  6:
                        count6 = count6 + 1;
                        break;
                    //case 7: which shows error.

                }
               
            }
            Console.WriteLine(
                $"{count1} times of 1 \n" +
                $"{count2} times of 2 \n" +
                $"{count3} times of 3 \n" +
                $"{count4} times of 4 \n" +
                $"{count5} times of 5 \n" +
                $"{count6} times of 6 \n");
            Console.ReadLine();


        }
    }
}
