using System;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program();

            /* 
            Console.WriteLine("Hello World!");
            
            string name = "Travis Morrison";
            int age = "99";
            float something = 1.90f; //for any gloating point(number with decimals)
            double somethingD = 1.90; //for many decimal places
            decimal price = 2.12m; //for currency/money
            bool crazy = true;
            
            Console.WriteLine("My name is: " + name);
            */

        }

        /* Rules for constructor
        -must have same EXACT name as class
        -should not have a return type
         */
        public Program()
        {
            Console.WriteLine("I am the constructor");

            SayHello();
            AnotherOne(42);
            AnotherOne(20);
            Loops();

            task1();
            Arrays();
        }
        public void Arrays()
        {
            //declare an array
            string[] name = new string[10];
            int[] number = new int[10];

            //add values to arrays
            name[0] = "Travis";
            name[1] = "123";
            name[2] = "asd";
            name[3] = "zxc";
            number[0] = 0;
            number[1] = 1;
            

            //read values from array
            System.Console.WriteLine(name[0]);

            //travel the array with a loop
            System.Console.WriteLine("Start array + loop");
            for(int i = 0; i < number.Length; i++){
                Console.WriteLine(number[i]);
                }

                int[] numbers = new int[200];
                for(int i=0;i<200; i++){
                    numbers[i] = i + 1;
                }
                int howMany = CountAndPrintOdds(numbers); //complete functionality
                Console.WriteLine(howMany);

        }
        public void task1()
        {
            int k = 0;
            while (k < 15)
            {
                Console.WriteLine(k);
                k += 3;

            }
        }

        public void Loops()
        {

            //For loop
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Inside a for loop");
            }

            // do while loop
            int j = 0;
            do
            {
                Console.WriteLine("Inside a do-while loop");
                j = j + 1;
            } while (j < 10);

            //while loop
            int k = 0;
            while (k < 10)
            {
                Console.WriteLine("Inside a while loop");
                k = k + 1;
            }
        }
        public int SayHello()
        {
            Console.WriteLine("Hello from a function");


            return 42;
        }
        public void AnotherOne(int val)
        {

            if (val < 40)
            {
                Console.WriteLine("Lower than 40");
            }
            else
            {
                Console.WriteLine("Greater than 40");
            }
        }
    }
}


/*
Homework:


 */
