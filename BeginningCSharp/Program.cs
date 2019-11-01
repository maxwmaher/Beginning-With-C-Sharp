using System;

namespace BeginningCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //INTRODUCTION TO VARIABLES

            //string characterName = "John";
            //int characterAge;
            //characterAge = 35;

            //Console.WriteLine("There once was a man named " + characterName + ".");
            //Console.WriteLine("He was " + characterAge + " years old.");

            //characterName = "Mike";

            //Console.WriteLine("He really liked the name " + characterName + ".");
            //Console.WriteLine("But didn't like being " + characterAge + ".");



            //INTRODUCTION TO DATA TYPES

            //string phrase = "C Sharp Professional Development"; //any phrase
            //char grade = 'A'; //any single character.  NOTE - single characters use just single quotes '' instead of double quotes "" in C#
            //int age = 30;
            //double gpa = 3.2;
            //bool isPracticing = true;

            //Console.WriteLine(age);



            //PRACTICE WITH STRINGS

            Console.WriteLine("Max\nMaher"); //Print Max, then on a new line, print Maher
            Console.WriteLine("\"Max\"Maher"); //Allows for printing of quotiation marks within the string
            string phrase = "Max Maher" + " is learning C#";
            Console.WriteLine(phrase.Length); //Print the length of the phrase
            Console.WriteLine(phrase.ToUpper()); //Converts phrase to UPPERCASE
            Console.WriteLine(phrase.ToLower()); //Converts phrase to lowercase
            Console.WriteLine(phrase.Contains("Max")); //Checks to see if phrase includes specificed parameter
            Console.WriteLine(phrase[0]); //Returns the character at the provided index
            Console.WriteLine(phrase.IndexOf("Maher")); //Returns the starting index of the value provided, if contained in the string.  Returns -1 if not contained in the string.
            Console.WriteLine(phrase.Substring(4, 5)); //Retrieves one part of the string.  Begins at index of first value provided, and goes for the number of characters provided in the second value.  No second value is required if looking to grab the full remainder of the string.

            Console.ReadLine();
        }
    }
}
