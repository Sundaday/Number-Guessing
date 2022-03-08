using System;

namespace Number_Guessing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int winNum = r.Next(0,100);
            bool win = false;

            do 
            {
                Console.WriteLine("Guess a number in between 0 and 100");
                string a = Console.ReadLine();

                int e = int.Parse(a);

                if( e > winNum)
                {
                    Console.WriteLine("To High");
                }
                else if( e < winNum)
                {
                    Console.WriteLine("Go low");
                } else if ( e == winNum)
                {
                    Console.WriteLine("YOU WIN");
                    win = true;
                }
            } 
            while (win==false);

            Console.WriteLine();
        }
    }
}
