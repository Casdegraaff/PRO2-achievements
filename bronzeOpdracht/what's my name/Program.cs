using System;

namespace opdracht3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            string s;
            Console.WriteLine("What is your name?");
            s = Console.ReadLine();

            Console.Clear();

            string d;
            Console.WriteLine("In which city do you live?");
            d = Console.ReadLine();

            Console.Clear();

            string q;
            Console.WriteLine("What is your postal code?");
            q = Console.ReadLine();

            Console.Clear();

            string t;
            Console.WriteLine("What age are you?");
            t = Console.ReadLine();

            Console.Clear();

            string w;
            Console.WriteLine("What is your favorite hobby?");
            w = Console.ReadLine();

            Console.Clear();

            string b;
            Console.WriteLine("What is yout favorite color?");
            b = Console.ReadLine();

            Console.Clear();

            string h;
            Console.WriteLine("What color do your eyes have?");
            Console.WriteLine("(Only write down your color)");
            h = Console.ReadLine();

            Console.Clear();

            string j;
            Console.Write("How tall are you in cm?");
            j = Console.ReadLine();

            Console.Clear();


            Console.WriteLine("Hi There, nice to meet you {0}", s);

            Console.WriteLine("I see that your zip code is also {0}", q);

            Console.WriteLine("So your favorite hobby is {0}", w);

            Console.WriteLine("And your favorite color is {0}", b);

            Console.WriteLine("You're pretty tall with a length of {0}", j);

            Console.WriteLine("Also, {0} eyes are really good looking", h);

        }
    }
}
