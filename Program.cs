using System;

namespace _01_NumberGuessing
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            bool restart;
            bool win;
             

            do 
            {

                int secret_num = rnd.Next(0, 100);
                win = false;
                restart = false;

                do
                {
                    Console.WriteLine("Gues the number from 0 to 100:");

                    try
                    {

                        int guesed = Convert.ToInt32(Console.ReadLine());

                        if (guesed > secret_num)
                        {
                            Console.WriteLine("Too hight! Gues lower!\n");
                        }
                        else if (guesed < secret_num)
                        {
                            Console.WriteLine("Too low! Gues higher!\n");
                        }
                        else
                        {
                            Console.WriteLine("YOU WON!!!\n");
                            win = true;
                        }

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message + "\n");
                    }


                } while (win != true);



                Console.WriteLine("To restart enter \'+\' symbol. ");

                char ans = Convert.ToChar(Console.ReadLine());

                if (ans == '+')
                {
                    restart = true;
                    Console.Clear();
                }
            } while (restart == true);


        }
    }
}
