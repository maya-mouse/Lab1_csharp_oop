using System;

namespace lab1
{
    class Program
    {
        public static void Main(string[] args)
        {
            GameAccount Player1 = new GameAccount("Котик");
            GameAccount Player2 = new GameAccount("Мавпа");
            int i = 0;
            while (i < 2)
            {
                Random rndm = new Random();
                int gamerating = rndm.Next(1, 10);

                if (gamerating >= 5)
                {
                    Player1.WinGame(Player2, gamerating);
                    Player2.LoseGame(Player1, gamerating);
                }
                else
                {
                    Player2.WinGame(Player1, gamerating);
                    Player1.LoseGame(Player2, gamerating);
                }
                i++;
                Console.WriteLine("<<<<-------->>>>\n");
                Console.WriteLine(Player1.GetStats());
                Console.WriteLine("Рейтинг на який грали : "+ gamerating);
                Console.WriteLine("\n<<<<-------->>>>\n");
                Console.WriteLine(Player2.GetStats());
                Console.WriteLine("\n<<<<-------->>>>\n");
                Console.WriteLine("Рейтинг на який грали : "+ gamerating);
            }

        }
    }
}
