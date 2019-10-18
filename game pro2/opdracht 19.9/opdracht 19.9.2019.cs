using System;

namespace pr02
{
    class Program
    {
        static void Main(string[] args)
        {


          

            Bool gameOver = false;

            Bool runningAway = false;
            string commandRunaway = "run";


            string commandAttack = "attack";
            string commandMagic = "magic";
            string commandDefend = "defend";

            byte playerHealth = 100;
            byte monsterHealth = 250;

            string monsterName = "Gerard";

            int screenWidth = 75;
            int screenHeight = 75;

            Console.SetBufferSize(screenwidth, screenheight);
            Console.SetWindowSize(screenwidth, screenheight);






            Console.Clear();

            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.DarkRed;

            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("----------------                    -------------------");
            Console.WriteLine("----------------       Slay         -------------------");
            Console.WriteLine("----------------       Gerard       -------------------");
            Console.WriteLine("----------------                    -------------------");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("-------------------------------------------------------");

            Console.CursorTop = 15;
            Console.CursorLeft = 10;
            
            Console.write(" Speler levens: "  + playerHealth + "HP \n");

            Console.WriteLine("[" + commandAttack + "]" + "[" + commandMagic + "]" + "[" + commandDefend + "]");


            Console.WriteLine("");

            Console.WriteLine("Hallo mijn naam is game, wat is jouw naam?");

            Console.WriteLine("");

            string name = Console.ReadLine();

            Console.WriteLine("");

            Console.WriteLine("Hallo {0} leuk dat je mijn game wilt spelen!", name);


            Console.ReadLine();

        }
    }
}
