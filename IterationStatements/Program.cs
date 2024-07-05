using System;

namespace MethodsWithLoopsAndConditionsals
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, I have a few things to show and a few questions to ask. First, you will see numbers from 1000 to -1000 displayed.");

            PrintRange(1000, -1000);

            Console.WriteLine("Next, the screen will give you the numbers from 3 to 999, counting by 3s.");

            PrintRangeByThree(999, 3);

            EqualOrNot();

            EvenOdd();

            PosNeg();

            VoteOrNot();

            TenCheck();

            MultOneTwelve();

            Console.WriteLine("Thanks for participating. I hope you had fun and learned something!");
        }

        public static void PrintRange(int ceiling, int floor)
        {
            for (int i = ceiling; i >= floor; i--)
            {
                Console.WriteLine(i);
            }

        }

        public static void PrintRangeByThree(int ceiling, int floor)
        {
            for (int i = floor; i <= ceiling && i >= floor; i += 3)
            {
                Console.WriteLine(i);
            }
        }

        public static void EqualOrNot()
        {
            Console.WriteLine("Okay, time for some input from you. Pick a number.");
            var inputOne = Console.ReadLine();
            int inputOneI = int.Parse(inputOne);
            Console.WriteLine("Great! Pick 1 more.");
            var inputTwo = Console.ReadLine();
            int inputTwoI = int.Parse(inputTwo);

            var check = (inputOneI == inputTwoI) ? "Your numbers are equal." : "Your numbers are not equal.";
            Console.WriteLine(check);



        }

        public static string EvenOdd()
        {
            Console.WriteLine("Let's check another number. Which one should it be?");
            var b = Console.ReadLine();
            int bI = int.Parse(b);
            var check = ((bI % 2) == 0) ? "Your number is even." : "Your number is odd";
            Console.WriteLine(check);
            return check;

        }

        public static string PosNeg()
        {
            Console.WriteLine("Let's see if a number is positive or negative. Which one should we check?");
            var pNeg = Console.ReadLine();
            int pNegI = int.Parse(pNeg);
            var check = (pNegI > 0) ? "That's a positive number!" : "That number is negative!";
            Console.WriteLine(check);
            return check;


        }

        public static string VoteOrNot()
        {
            Console.WriteLine("Let see if you are old enough to vote. What is your age?");
            string age = Console.ReadLine();
            int ageI = int.Parse(age);
            var response = (ageI >= 18) ? "You are able to vote." : "You are not able to vote.";
            Console.WriteLine($"{response}");
            return response;

        }

        public static string TenCheck()
        {
            Console.WriteLine("Let's see if a number is within the 10 to -10 range. Pick one.");
            var num = Console.ReadLine();
            int numI = int.Parse(num);
            var answer = (numI <= 10 && numI >= -10) ? "Your number is within range." : "Your number is out of range.";
            Console.WriteLine($"{answer}");
            return answer;


        }

        public static void MultOneTwelve()
        {
            Console.WriteLine("Now I will show you the 1 to 12 multiplication table for a number of your choosing. Which number should I show the table for?");
            var numTwo = Console.ReadLine();
            int numTwoI = int.Parse(numTwo);
            int[] multipliers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            Console.WriteLine("Good choice!");
            foreach (int number in multipliers)

            {

                Console.WriteLine(numTwoI * number);

            }




        }


    }


}