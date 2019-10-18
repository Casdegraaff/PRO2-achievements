using System;

namespace _Eindresultaat
{
    class Program
    {

        // ------------------ ROCK/PAPER/SCISSORS RPG ------------------
        static void Main(string[] args)
        {

            int screenWidth = 75;
            int screenHeight = 25;


            // COMMAND VARIABLES:
            string commandAttack        = "attack";
            string commandDefend        = "defend";
            string commandMagic         = "magic";
            string commandRun           = "run";


            // PLAYER VARIABLES:
            int playerHealth = 100;
            int playerHealthMax = 100;
            int playerAttack = 10;
            int playerWins = 0;
            int playerWinsEnd = 5;
            int playerRunSetback = 1;
            bool playerRunAway = false;
            bool gameOver = false;

            int healthRestoreMin = 1;
            int healthRestoreMax = 25;


            // MONSTER VARIABLES:
            int monsterHealth  = 30;
            int monsterAttack  = 5;
            string monsterName = "Goblin";
            bool monsterInit   = true;  // Sets monster health before battle starts

            string message = "";

            string input;
            input = "";


            Console.Title = "MY FIRST CONSOLE GAME";

            Console.SetWindowSize(screenWidth, screenHeight);
            Console.SetBufferSize(screenWidth, screenHeight);


            // ---------- WELCOME SCREEN, DO ONCE -------------
            
            Console.Clear();
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.Cyan;

            int openingScreenX          = 0;
            int openingScreenY          = 0;
            int openingScreenWidth      = 72;
            int openingScreenHeight     = 9;

            Console.WriteLine("########################################################################");
            Console.WriteLine("########################################################################");
            Console.WriteLine("###########                                                  ###########");
            Console.WriteLine("###########          WELCOME TO:  'SLAY THE DEMON'!          ###########");
            Console.WriteLine("###########                                                  ###########");
            Console.WriteLine("###########            PRESS ANY KEY TO CONTINUE.            ###########");
            Console.WriteLine("###########                                                  ###########");
            Console.WriteLine("########################################################################");
            Console.WriteLine("########################################################################");
            
            Console.MoveBufferArea( 0, 0, openingScreenWidth, openingScreenHeight, openingScreenX, openingScreenY );

            Console.ReadKey(true);
            
            // -------------------------------------------------
            
            Console.Clear();
            Console.CursorVisible = true;
            Console.BackgroundColor = ConsoleColor.White;
            Console.SetCursorPosition(0, 0);


            // UPDATE THE GAME:
            Console.ForegroundColor = ConsoleColor.Blue;



            // #####################   DRAW GAME STATE   #####################

            // DRAW VISUAL OPPONENT:
            // L2 - GOBLIN ENCOUNTERED:
            Console.WriteLine("========= You have encountered a " + monsterName + ". =========");

            // Colour:
            Console.ForegroundColor = ConsoleColor.DarkGreen; // L3

            // L3 - Show the graphic:
            Console.WriteLine("                        ");
            Console.WriteLine("       |\\___/|  V       ");
            Console.WriteLine("     <( Ò   Ó )>|       ");
            Console.WriteLine("       \\  ^  /  |       ");
            Console.WriteLine("        V```V           ");
            Console.WriteLine("                        ");
        

            // MOVE 2 BLOCKS BELOW IMAGE:
            Console.CursorTop += 2;
            
            // SHOW MONSTER HEALTH:
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("ENEMY HEALTH:   " + monsterHealth + "HP");

            // SHOW PLAYER HEALTH:
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("PLAYER HEALTH:  " + playerHealth + "HP");

            // SHOW ACTIONS:
            Console.CursorTop += 1;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Type one of the following actions:");
            Console.WriteLine("[" + commandAttack + "]" + "  " + "[" + commandDefend + "]" + "  " + "[" + commandMagic + "]" + "  " + "[" + commandRun + "]");



            // #####################   REQUEST INPUT   #####################
            Console.CursorTop += 2;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            input = "";

            input = Console.ReadLine();



            // #####################   UPDATE GAME   #####################

            if (input == commandAttack || input == commandDefend || input == commandMagic )
            {
                Random randomnumber = new Random();
                int resultRandom = randomnumber.Next(0, 3);

                string enemyMove = "";
                if (resultRandom = 0)
                {
                    enemyMove = commandAttack;
                }
                else if (resultRandom == 1)
                {
                    enemyMove = commandDefend;
                }
                else 
                {
                    enemyMove = commandMagic;
                }

                if (input == enemyMove) ;
                message = "ITS A DRAW"; 

                else if (
                    (input == commandAttack && enemyMove == commandMagic) || (input == commandDefend && enemyMove == commandAttack) || (input == commandMagic && enemyMove == commandDefend)) ;
                
                {
                    monsterHealth == playerAttack;
                    Console.Beep(1000, 500);
                    message += "YOU WON!";
                }
             else
                {
                    playerHealth == monsterAttack;
                    Console.Beep(1100, 500);
                    message += "YOU LOST!";


                }


                message += "\n";
                message += "PLAYER HEALTH:" + playerHealth + "\n";
                message += "MONSTER HEALTH:" + monsterHealth + "\n";
                }


            Console.Write message;





            // L2 - GIVE THE PLAYER TIME TO READ THE MESSAGE:
            Console.ReadKey(true);



            // END GAME:
            Console.ResetColor();
            Console.Clear();
            Console.WriteLine("Thank you for playing! Press any button to exit.");
            Console.ReadKey(true);


        }
    }
}
