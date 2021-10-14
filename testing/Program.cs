using System;
using System.Linq;

namespace DecisionMaking
{
    class MainClass
    {
        public static int GetCategory()
        {

            int categoryNumber = -1;
            bool needCategory = true;
            while (needCategory)
            {
                Console.Write("Please enter the number of the category you are interested in: ");
                string input = Console.ReadLine().ToLower().Trim();
                try
                {
                    if (input.Any()) // checks to see if user entered anything
                    {
                        categoryNumber = int.Parse(input) - 1;
                        if (categoryNumber >= 5 || categoryNumber < 0) // choice has to be within range
                        {
                            throw new Exception("No category in that range, please try again.");
                        }
                    }
                    else
                    {
                        throw new Exception("No category detected, please try again.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Not a valid number, please try again");
                    continue;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }
                needCategory = false;
            }

            return categoryNumber;
        }

        public static void Main(string[] args)
        {



            Console.WriteLine("Hello friendo! What's your name?");



            string name = Console.ReadLine();

            Console.WriteLine("Thanks " + (name) + ". Please enter a number between 1 and 100.");

            string input = Console.ReadLine();
            int num = int.Parse(input);

            //Console.WriteLine(num);




            {


                if (num >= 1 && num <= 100)
                {
                    //Console.WriteLine("Number accepted.");


                    int EvenOrOdd = (num % 2);

                    if (EvenOrOdd == 1)
                    {
                        Console.WriteLine("Odd " + num);
                    }
                    else
                    {
                        Console.WriteLine("Even");

                        {
                            if (num >= 2 && num <= 24)
                            {
                                Console.WriteLine("and less than 25");
                            }
                            else if (num >= 61)
                            {
                                Console.WriteLine(num);
                            }
                        }

                    }
                }
                else
                {
                    Console.WriteLine("Try again.");

                }





            }

        }
    }
}
