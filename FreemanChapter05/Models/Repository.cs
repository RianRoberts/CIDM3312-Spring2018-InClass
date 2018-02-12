using System.Collections.Generic;

namespace FreemanChapter05.Models{
    public class Repository
    {
        public static List<string> ToDos {get; set; } 

        //static constructor is there to initialize static members 
        static Repository()
        {
            ToDos = new List<string>();
        }
    }
}