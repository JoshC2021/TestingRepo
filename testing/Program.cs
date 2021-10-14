using System;
using System.Linq;

namespace DecisionMaking
{
    class MainClass
    {
        public static void DestroyMain()
        {
            Console.WriteLine("End of your Repo");
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
