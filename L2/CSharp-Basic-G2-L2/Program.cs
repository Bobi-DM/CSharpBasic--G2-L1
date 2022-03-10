using System;

namespace CSharp_Basic_G2_L2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //int a=0;
            //a = 2;
            //double averageScore = 0.5;

            //averageScore = a;

            //bool isActive = true;
            //bool isBusy = false;

            //DateTime datum = new DateTime(2022, 03, 10, 15, 18, 45);

            //char chosenLetter = 'a';

            //string helloWorld = "Hello Wolrd";

            //Console.WriteLine(a);
            //Console.WriteLine(averageScore);
            //Console.WriteLine(datum);
            //Console.WriteLine(chosenLetter);
            //Console.WriteLine(helloWorld);

            //Declare two integer variables with values
            int variableOne = 1;
            int variableTwo = 2;

            //Perform the operation addition and store the result in a third variable
            int result = variableOne + variableTwo;

            // Print uot of result of the addition
            Console.WriteLine(result);
            // Example of addition without assinging the result to a variabble
            Console.WriteLine(variableTwo + variableOne);

            //Declare two decimal variables and assign


            //exercise 1

            //double numberOne = 25.8;
            //double numberTwo = 5.4;

            //double divide = numberOne / numberTwo;
            //Console.WriteLine(divide);

            //int a = 25;
            //int b = 5;

            //int divideInt = a / b;

            //Console.WriteLine(divideInt);

            //exercise 2

            //string hey = "Hey G2";
            //string hello = "Hello SEDC";
            //string conca = hey + hello;
            //Console.WriteLine(conca);

            //string numOne = "9";
            //string numTwo = "3";
            //string stringS = numOne + numberTwo;
            //Console.WriteLine(stringS);

            //exercise 3

            //string n = Console.ReadLine();
            //string m = Console.ReadLine();

            //int nParsed = Convert.ToInt32(n);
            //int mParsed = Convert.ToInt32(m);

            //int result1 = nParsed / mParsed;
            //Console.WriteLine(result1);

            //Exercise 4

            //string numEven = Console.ReadLine();
            //string numOdd = Console.ReadLine();

            //int numEvenParsed = Convert.ToInt32(numEven);
            //int numOddParsed = Convert.ToInt32(numOdd);

            //if (numEvenParsed % 2 == 0)
            //{
            //    Console.WriteLine($"{numEvenParsed} e paren broj");
            //}
            //else
            //{
            //    Console.WriteLine($"{numEvenParsed} e neparen broj");
            //}
            //if (numOddParsed % 2 == 1)
            //{
            //    Console.WriteLine($"{numOddParsed} e neparen broj");
            //}
            //else
            //{
            //    Console.WriteLine($"{numOddParsed} e paren broj");
            //}


            string input;
            input = Console.ReadLine();

            switch (input)
            {
                case "a":
                    {
                        Console.WriteLine("Vnesena e bukvata a");
                    }
                    break;
            }


            string inputTwo;
            inputTwo = Console.ReadLine();

            switch (input)
            {
                case "1":
                    {
                        Console.WriteLine("You got a new car!");
                    }
                    break;
                case "2":
                    {
                        Console.WriteLine("You got a new plane!");
                    }
                    break;
                case "3":
                    {
                        Console.WriteLine("You got a new bike!");
                    }
                    break;
            }

        }
    }
}
