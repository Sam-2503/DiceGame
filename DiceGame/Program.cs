using System;

namespace DiceGame
{
    class myProgram
    {
        static void Main()
        {
            Random rnd = new Random();
            Loop:
            int aidice = rnd.Next(0, 7);
            int playerdice = rnd.Next(0, 7);

            Console.WriteLine("AI has scored " + aidice);
            Console.WriteLine("You have scored " + playerdice);
            
            if (playerdice > aidice)
            {
                Console.WriteLine("You win!");
                Console.ReadKey();
                goto Loop;
            }
            else
            {
                if (aidice > playerdice)
                {
                    Console.WriteLine("AI wins!");
                    Console.ReadKey();
                    goto Loop;
                }

                if (aidice == playerdice)
                {
                    Console.WriteLine("It's a tie.");
                    Console.ReadKey();
                    goto Loop;
                }
  
            }

           
        }
    }
}