﻿using System;
using System.Collections.Generic;

namespace dictionary_of_words
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Create a dictionary with key value pairs to
            represent words (key) and its definition (value)
            */
            Dictionary<string, string> wordsAndDefinitions = new Dictionary<string, string>();

            // Add several more words and their definitions
            wordsAndDefinitions.Add("Awesome", "The feeling of students when they are learning C#");
            wordsAndDefinitions.Add("potato", "something hobbits eat, you know, po-tay-to");
            wordsAndDefinitions.Add("console.log", "so much easier than console.writeLine. like wtf");
            wordsAndDefinitions.Add("meow", "some kitty scientist believe this to be the orgin of life");
            wordsAndDefinitions.Add("50 cent", "two quarters, sometimes five dimes. thats it");

            /*
                Use square bracket lookup to get the definition of two
                words and output them to the console
            */

            Console.WriteLine(wordsAndDefinitions["meow"]);
            Console.WriteLine(wordsAndDefinitions["potato"]);
            // Console.WriteLine(wordsAndDefinitions.Keys);
            /*
                Loop over dictionary to get the following output:
                    The definition of [WORD] is [DEFINITION]
                    The definition of [WORD] is [DEFINITION]
                    The definition of [WORD] is [DEFINITION]
            */
            foreach (KeyValuePair<string, string> word in wordsAndDefinitions)
            {
                Console.WriteLine($"The definition of {word.Key} is {word.Value}");
            }
        }
    }
}
