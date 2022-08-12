using System;

namespace HOME_TASK_4___12.AUG_ucun
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Write a C# that calculates the day of week (ex: Monday) of your birthday

            //DateTime dateTime = new DateTime(1999, 05, 27);
            //Console.WriteLine(dateTime.DayOfWeek);
            //Console.WriteLine((int)dateTime.DayOfWeek);


            // 2. Write a C# that calculates you current life days (how many days past since your birth)


            //DateTime myBirthdate = new DateTime(1999, 05, 27);
            //TimeSpan myAge = DateTime.Now.Subtract(myBirthdate);
            //Console.WriteLine((int)myAge.TotalDays);


            // 3. Write a C# Sharp program to find the largest of three numbers.

            //Console.WriteLine("Enter the first number : ");
            //int first = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the second number : ");
            //int second = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the third number : ");
            //int third = int.Parse(Console.ReadLine());


            //if (first > second)
            //{

            //    if (first > third)
            //    {
            //        Console.WriteLine("largest number : " + first);
            //    }
            //    else
            //    {
            //        Console.WriteLine("largest number : " + third);
            //    }
            //}
            //else
            //{
            //    if (second > third)
            //    {
            //        Console.WriteLine("largest number : " + second);
            //    }
            //    else
            //    {
            //        Console.WriteLine("largest number : " + third);
            //    }
            //}



            // 4. Write a program in C# Sharp to read any day number in integer and display day name in the word.

            //Console.WriteLine("Enter Day :");
            //string weekday = Console.ReadLine();
            //int weekdayNum = int.Parse(weekday);

            //switch (weekdayNum)
            //{
            //    case 1:
            //        Console.WriteLine("Monday");
            //        break;
            //    case 2:
            //        Console.WriteLine("Tuesday");
            //        break;
            //    case 3:
            //        Console.WriteLine("Wednesday");
            //        break;
            //    case 4:
            //        Console.WriteLine("Thursday");
            //        break;
            //    case 5:
            //        Console.WriteLine("Friday");
            //        break;
            //    case 6:
            //        Console.WriteLine("Saturday");
            //        break;
            //    case 7:
            //        Console.WriteLine("Sunday");
            //        break;
            //    default:
            //        Console.WriteLine("Enter valid number");
            //        break;
            //}





            // 5. Write a program in C# Sharp which is a Menu-Driven Program to perform a simple calculation.

            Console.Write("Enter a : ");
            string str_a = Console.ReadLine();
            int int_a = int.Parse(str_a);

            Console.Write("Enter b : ");
            string str_b = Console.ReadLine();
            int int_b = int.Parse(str_b);

            Console.WriteLine("1.+    2.-    3.*    4./");
            Console.Write("Choose :");
            string str_op = Console.ReadLine();
            switch (str_op)
            {
                case "Toplama":
                    Console.WriteLine((int_a, int_b));
                    break;
                case "Cixma":
                    Console.WriteLine((int_a, int_b));
                    break;
                case "Vurma":
                    Console.WriteLine((int_a, int_b));
                    break;
                case "Bolme":
                    Console.WriteLine((int_a, int_b));
                    break;
                default:
                    break;
            }
            Console.ReadLine();
            





            // 6. Write a program in C# to check whether a number is a palindrome (visual simmetric) or not.

            //int num, i, rev;

            //Console.Write("Enter any number : ");
            //num = Convert.ToInt32(Console.ReadLine());

            //rev = num;
            //for (i = 0; num > 0; num = num / 10)
            //{
            //    i = i * 10;
            //    i = i + (num % 10);
            //}

            ////Checking if reverse number is equal to original num or not.
            //if (rev == i)
            //    Console.WriteLine(rev + " is a Palindrome Number.");
            //else
            //    Console.WriteLine(rev + " is not a Palindrome Number.");





            // 7. Write a program in C# to create a function to calculate the sum of the individual digits of a given number.

            //Console.Write("Enter the Number : ");
            //int number = int.Parse(Console.ReadLine());
            //int sum = 0, A;

            //while (number > 0)
            //{
            //    A = number % 10;
            //    sum = sum + A;
            //    number = number / 10;
            //}

            //Console.WriteLine($"The Sum of Digits is : {sum}");
            //Console.ReadKey();



















        }





    }
}
