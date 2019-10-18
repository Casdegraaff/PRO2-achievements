using System;

namespace wirwar
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("");
            Console.WriteLine("Welke van de 3 Pro2 leraren waar je les van krijgt is je favoriet?");  
             Console.WriteLine("");
            String name = Console.ReadLine();
            Console.WriteLine("");


            if(name == "Erwin")                
                Console.WriteLine("Oei. die Erwin, hij geeft wel goed les ja!");
                
            else if(name == "Erik")
                Console.WriteLine("Natuurlijk is Erik je favoriet, duh!");
                
            else if(name == "Alex")
                Console.WriteLine("Jij moet vast erg van 3D Pro2 houden!");

            else 
            Console.WriteLine("Wie ben jij eigenlijk?");    
			
        }
    }
}

