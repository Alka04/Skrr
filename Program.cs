using System;

namespace brrrr
{
    class Program
    {
        static void Main(string[] args)
        { 
            Random rand = new Random();
            int guess = 0;
            string Välkommen = "Gissa på ett nummer mellan 1-100";
            int num = rand.Next(1,100);
            Console.WriteLine(Välkommen);


            int i = 0;

            while(guess != num)
            {
                    try
                        {
                            guess = Convert.ToInt32(Console.ReadLine());

                            if (guess > num)
                            {
                                Console.WriteLine("för högt");
                            }
                        else
                            {
                                Console.WriteLine("För lågt");
                            }
                        }

                catch
                {
                    Console.WriteLine("Du måste skriva ett nummer");
                    i--;
                } 


                i++;
            }
            Console.WriteLine("Grattis, det tog dig enbart " + i + " försök");
            Console.ReadLine();


        }
    }
}
