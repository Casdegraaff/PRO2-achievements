using System;
using System.Collections.Generic;
using System.Threading;
using System.IO;


namespace quizEngine
{
    class Program
    {
        private static int score = 0;
        static void Main(string[] args)
        {    
            //create questions and answers            
            List<Question> questions = CreateQuestions();
                       
            Console.ForegroundColor = ConsoleColor.Cyan;
            
            //loop through questions
            int i = 0;
            foreach(Question q in questions){
                Console.Clear();
                Console.WriteLine("Score : "+score);
                i++;

                Console.WriteLine("question "+i+": "+ q.GetString());
                int j = 0;
                foreach(Answer a in q.GetOptions()){
                    j++;
                    Console.WriteLine("Type  "+ j + " for : "+a.GetString());   
                }
                
                //Await player input and validate if it's an int
                int input;
                bool parsed = false;
                do{
                    Console.WriteLine("Please answer with a number");
                    parsed = int.TryParse(Console.ReadLine(), out input);
                }
                while(!parsed);
                 
                int result = q.AnswerIt(input-1);//returns -1 if wrong

                if(result > -1){//RIGHT
                    score += result;
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.Black;                    
                    Console.WriteLine("You dit it!");
                    Console.WriteLine("+" +result);
                    Console.Beep(1200, 50);
                    Console.Beep(1300, 50);
                    Console.Beep(1400, 50);
                    Thread.Sleep(100);
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.Black;    
                }else{//WRONG
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.Black;                    
                    Console.WriteLine("Aww man...");
                    Console.Beep(1300, 50);
                    Console.Beep(1200, 50);
                    Console.Beep(1100, 50);
                    Thread.Sleep(100);
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.Black;                       
                }                
            }
            //After questions are answered player enters name for highscore
            Console.Clear();
            Console.WriteLine("Game Over your score is : "+ score + " points");       
            Console.WriteLine("Please enter your Username:");
            string playerName = Console.ReadLine();
            HighScore.WriteHighScore(playerName,score,"highScore.txt");        


            //print highscore after highscore is saved
            string[] highScore = ListSorter.GetSortedHighScore("highScore.txt");
            
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("+++++++++++++ Highscore +++++++++++++");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            int count = highScore.Length;
            if(count>10)count =10;
            for(int k=0;k<count;k++){
                Console.WriteLine(highScore[k]);
            }   
        }
       
        static List<Question> CreateQuestions(){
             return new List<Question>{

               new Question("In welk jaar kwam het nummer Billie Jean uit van Micheal Jackson?",
                50,
                new List<Answer>{
                    new Answer("1983"),
                    new Answer("1981"),
                    new Answer("1985")
                    },
                0),
                new Question("Waar was de band Nirvana ontstaan?",
                50,
                new List<Answer>{
                    new Answer("Baltimore"),
                    new Answer("aberdeen"),
                    new Answer("Fresno")
                    },
                1),
                new Question("Welke van deze nummers van Queen kwam in de jaren 80 uit?",
                50,
                new List<Answer>{
                    new Answer("Bohemian Rhapsody"),
                    new Answer("We are the champions"),
                    new Answer("Another one bites the dust")
                    },
                2),
                new Question("wat is geen nummer van David Bowie?",
                75,
                new List<Answer>{
                    new Answer("Ashes to Ashes"),
                    new Answer("Modern love"),
                    new Answer("China girl"),
                    new Answer("Killer queen")
                    },
                3),
                new Question("Wie is de zanger van de band Guns n Roses?",
                75,
                new List<Answer>{
                    new Answer("Slash"),
                    new Answer("Axl Rose"),
                    new Answer("Duff Mckagan"),
                    new Answer("Buckethead")
                    },
                1),
                new Question("Welke van deze nummers kwam niet uit in de jaren 80?",
                75,
                new List<Answer>{
                    new Answer("One - Metallica"),
                    new Answer("Beat it - Micheal Jackson"),
                    new Answer("Eye of the tiger - Survivor"),
                    },
                1),
                new Question("Welke band is niet in de jaren 80 ontstaan?",
                75,
                new List<Answer>{
                    new Answer("Metallica"),
                    new Answer("Guns n Roses"),
                    new Answer("Queen"),
                    new Answer("Mötley Crüe")
                    },
                2),
                new Question("Welke muziekgroep had in 1980 het nummer 1 album Back in Black?",
                75,
                new List<Answer>{
                    new Answer("Michael Jackson"),
                    new Answer("AC/DC"),
                    new Answer("David Bowie"),
                    new Answer("Nirvana")
                    },
                1),
                new Question("Hoe duur was het om de videoclip van Thriller te maken?",
                75,
                new List<Answer>{
                    new Answer("650.000"),
                    new Answer("200.000"),
                    new Answer("800.000"),
                    new Answer("1.200.000")
                    },
                2),
                new Question("Wat is geen nummer van queen?",
                75,
                new List<Answer>{
                    new Answer("I want to break free"),
                    new Answer("don`t stop me now"),
                    new Answer("Under pressure"),
                    new Answer("Livin on a prayer")
                    },
                3),
            };

        }

    }
}
