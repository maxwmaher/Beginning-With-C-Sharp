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

            //Console.WriteLine("Max\nMaher"); //Print Max, then on a new line, print Maher
            //Console.WriteLine("\"Max\"Maher"); //Allows for printing of quotiation marks within the string
            //string phrase = "Max Maher" + " is learning C#";
            //Console.WriteLine(phrase.Length); //Print the length of the phrase
            //Console.WriteLine(phrase.ToUpper()); //Converts phrase to UPPERCASE
            //Console.WriteLine(phrase.ToLower()); //Converts phrase to lowercase
            //Console.WriteLine(phrase.Contains("Max")); //Checks to see if phrase includes specificed parameter
            //Console.WriteLine(phrase[0]); //Returns the character at the provided index
            //Console.WriteLine(phrase.IndexOf("Maher")); //Returns the starting index of the value provided, if contained in the string.  Returns -1 if not contained in the string.
            //Console.WriteLine(phrase.Substring(4, 5)); //Retrieves one part of the string.  Begins at index of first value provided, and goes for the number of characters provided in the second value.  No second value is required if looking to grab the full remainder of the string.



            //WORKING WITH NUMBERS

            //Console.WriteLine(5 + 8); //Returns sum
            //Console.WriteLine(5 - 8); //Returns difference
            //Console.WriteLine(5 * 8); //Returns product
            //Console.WriteLine(40 / 5); //Returns quotient
            //Console.WriteLine(40 % 5); //Modulus operator.  Returns remainder
            //Console.WriteLine(4 + 2 * 3); //Order of operations applies.  3*2 will be performed first, then 4 will be added to get 10.
            //Console.WriteLine((4 + 2) * 3); //Now the inner parentheses will process first (4+2), times 3 to get 18.
            //Console.WriteLine(5 / 2); //We would expect 2.5 normally, but in C#, when only integer values are provided, an integer is returned.  Returns 2.
            //Console.WriteLine(5 / 2.0); //2.0 is considered a double.  This returns 2.5.

            //int num = 6;
            //num++; //increments by one.  Can decrement by one with num--;
            //Console.WriteLine(num);
            //Console.WriteLine(Math.Abs(-40)); //Returns the absolute value of the provided value (in this case, 40).
            //Console.WriteLine(Math.Pow(3, 2)); //Returns the first number taken to the power of the second number.
            //Console.WriteLine(Math.Sqrt(36)); //Returns the square root
            //Console.WriteLine(Math.Max(4, 92)); //Returns the largest of the two numbers provided in the parameters
            //Console.WriteLine(Math.Min(4, 92)); //Returns the smallest of the two numbers provided in the parameters
            //Console.WriteLine(Math.Round(4.32)); //Returns the number rounded to the nearest integer



            //GETTING USER INPUT

            //Console.WriteLine() writes out a line of text, then moves onto the next line.
            //Console.Write() does not go to a new line, but stays on the same one.

            //Console.Write("Enter your name: "); //prompt for the user
            //string name = Console.ReadLine(); //pauses the program and allows the user to enter a line of text.  Stores value into a string variable called name.
            //Console.Write("Enter your age: "); //display message and variable to the user
            //string age = Console.ReadLine();
            //Console.WriteLine("Hello " + name + ", you are " + age + "."); //displays message and variables to the user



            //BUILDING A CALCULATOR

            //int num = Convert.ToInt32("45");
            //Console.WriteLine(num + 6); //returns 51
            //Console.WriteLine("43" + "56"); //concatenates the values, returns 4356

            //Console.Write("Enter a first number: ");
            //double num1 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Enter a second number: ");
            //double num2 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine(num1 + num2);



            //BUILDING A MAD LIBS GAME

            //string color, pluralNoun, celebrity;

            //Console.Write("Enter a color: ");
            //color = Console.ReadLine(); //pause the program, save the value the user enters to this variable

            //Console.Write("Enter a plural noun: ");
            //pluralNoun = Console.ReadLine(); //pause the program, save the value the user enters to this variable

            //Console.Write("Enter a celebrity: ");
            //celebrity = Console.ReadLine(); //pause the program, save the value the user enters to this variable

            //Console.WriteLine("Roses are " + color + ".");
            //Console.WriteLine(pluralNoun + " are blue.");
            //Console.WriteLine("I love " + celebrity + ".");



            //ARRAYS

            //Arrays get declared with a type.  All elements within the array must be of the same type.

            //int[] luckyNumbers = { 4, 8, 15, 16, 23, 42 };
            //string[] friends = new string[5]; //indicates this friends array can hold up to five values
            //friends[0] = "Alex";
            //friends[1] = "Ariel";

            //luckyNumbers[1] = 900;

            //Console.WriteLine(luckyNumbers[1]);



            //METHODS


            //    SayHi("Max", 31);
            //    SayHi("Chris", 32);
            //    SayHi("Melee", 11);
            //    Console.ReadLine(); //essentially pauses the program
            //}

            ////new methods are declared with static
            ////void indicates the method is not returning anything

            //static void SayHi(string name, int age)
            //{
            //    Console.WriteLine("Hello " + name + ", you are " + age + ".");
            //}



            //RETURN STATEMENT

            //    int cubedNumber = cube(5);
            //    Console.WriteLine(cubedNumber);

            //    Console.ReadLine(); 
            //}

            //static int cube(int num)
            //{
            //    int result = num * num * num;
            //    return result; //return piece of information back to the caller
            //}



            //IF STATEMENTS

            bool isHappy = true;
            bool isTall = false;

            if (isHappy && isTall)  // Like JavaScript, || means or, && means and
            {
                Console.WriteLine("You are happy and tall!");
            } else if (isHappy && !isTall) {
                Console.WriteLine("You are short, but happy!");
            } else if (!isHappy && isTall) {
                Console.WriteLine("You are not happy, but you are tall!");
            } else {
                Console.WriteLine("You are neither happy nor tall!");
            }

            Console.ReadLine();
        }
    }
}
