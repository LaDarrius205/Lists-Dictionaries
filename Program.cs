using System;
using System.Collections.Generic;

namespace Lists_Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            //HOW TO MODEL A REAL WORLD DICTIONARY


            // Let's model a rea-world Dictionary of words and their Definitions
            //
            // One Item in a rel-world dictionary is represented like this;
            // word : list od definitions
            //
            // this maps will be to C# Dictionary structure od Key-Value pair
            // Key will be the word (string)
            //Value: will be the list od definitions (List<string>)
            //
            //___________________________________________________

            // STEP 1: Create the C# Dictionary to Model a real-World dictionanry
            Dictionary<string, List<string>> realWorldDictionary = new Dictionary<string, List<string>>();

            // STEP 2; Add some words and definitions to pur C# Dictionary
            realWorldDictionary["vehicle"] = new List<string>()
            {
                "any means in or by which someone travels ",
                "a conveyance moving on wheels",
                "a carrier",
                "a medium of communication,"
            };
            realWorldDictionary.Add("van", new List<string>()
            {
                "a covered vehicle", 
                "a smaller boxlike vehicle that resembles a panel truck ",
                "a railway baggage car."

            });
            realWorldDictionary.Add("Truck", new List<string>()
            {
                "any of various wheeled frames used for transporting heavy objects.",
                "A dolly which a camera is mounted. "


            }) ;



            // STEP 3: Show all of the words in our C# Dictionary
            // loop over dictionary to show everything in it
            // Words and Definitions
            // the key value type has to use the same Name as in the dictiolnary
            // KeyValue  <string, List<string>

            foreach (KeyValuePair<string, List<string>> word in realWorldDictionary)
            {
                Console.WriteLine($"{word.Key}");
                foreach (string definition in word.Value)
                {
                    Console.WriteLine($"\t{definition}");
                }
            }

            foreach (KeyValuePair <string, List<string>> word in realWorldDictionary)
            {
                Console.WriteLine($"{word.Key}");
                foreach(string definition in word.Value)
                {
                    Console.WriteLine($"\t{definition}");
                }
            }

            //Step 4: Search for a word in our C# Dictionary
            // looping over dictionary
            // We searched to see it the dictionary ContainsKey
            // it grabs the valuse of that Key and Print them out

            Console.WriteLine("Search: ");
            string searchWord = Console.ReadLine();
            if (realWorldDictionary.ContainsKey(searchWord))
            {
                // used a subscript value to get the value for a assicated key
                List<string> definitions = realWorldDictionary[searchWord];
                foreach (string definition in definitions)
                {
                    Console.WriteLine($"\t{definition}");
                }
            }
            // if word is not found
            else
            {
                Console.WriteLine($"Search word {searchWord} not found. ");
            }
            searchWord = Console.ReadLine();

            // using the TryGetValue method
            if(realWorldDictionary.TryGetValue(searchWord, out List<string> defs))
            {
                foreach (string definition in defs)
                {
                    Console.WriteLine($"\t{definition}");
                }
            }

            Console.ReadKey();

        }
    }
}
