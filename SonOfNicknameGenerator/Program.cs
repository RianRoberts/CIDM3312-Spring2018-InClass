using System;

namespace SonOfNickNameGenerator
{ 
    class Program
    {
        static void Main(string[] args)
        {

            if(args.Length > 0)
            {
                Console.WriteLine("The thing(s) you sent to me after the program name is: ");
                for( int i = 0; i < args.Length; i++)
                {
                    Console.WriteLine(args[i]);
                }
                
            }            

            string[,] nicknames = new string [10, 2];

            //row 1, column 1
            nicknames[0,0] = "Dude";
            //row 1, column 2
            nicknames[0, 1] = "Jones";

            //row 2, column 1
            nicknames[1,0] = "Snappy";
            //row 2, column 2
            nicknames[1, 1] = "Firecracker";            

            Console.WriteLine("Please enter your name: ");

            string name = Console.ReadLine();

            string[] nameparts = name.Split(new char[' ']);

            //[0] = "Jeffry";
            //[1] = "Babb";

            for(int i = 0; i < nameparts.Length; i++){
                Console.WriteLine(nameparts[i]);
            }

            /* 
            for(int i = 0; i < nameparts.Length; i++){
                
            }
            */
        }
    }
}
