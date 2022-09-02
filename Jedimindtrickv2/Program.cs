using System;
using System.Collections.Generic;

namespace Jedimindtrickv2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1st assignment
            //Creates Dictionary
            Dictionary<string, int> names = new Dictionary<string, int>();
            names.Add("Emil", 28);
            names["Frederik"] = 26;

            //Writes out Dictionary
            foreach (KeyValuePair<string, int> pair in names)
            {
                Console.WriteLine("Found: " + pair.Value + ", with key: " + pair.Key);
            }

            //2nd assignment
            //Create jedi dictionary 
            Dictionary<string, bool> characters = new Dictionary<string, bool>()
            {
                {"Luke", true },
                {"Han", false },
                {"Chewbakka", false }
            };

            // removes Han
            characters.Remove("Han");

            //Writes out Dictionary
            foreach (KeyValuePair<string, bool> pair in characters)
            {
                Console.WriteLine("Found: " + pair.Value + ", with key: " + pair.Key);
            }



            Console.ReadKey();
        }
    }
}
