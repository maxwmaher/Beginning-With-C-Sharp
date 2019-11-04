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

            //    bool isHappy = true;
            //    bool isTall = false;

            //    if (isHappy && isTall)  // Like JavaScript, || means or, && means and
            //    {
            //        Console.WriteLine("You are happy and tall!");
            //    } else if (isHappy && !isTall) {
            //        Console.WriteLine("You are short, but happy!");
            //    } else if (!isHappy && isTall) {
            //        Console.WriteLine("You are not happy, but you are tall!");
            //    } else {
            //        Console.WriteLine("You are neither happy nor tall!");
            //    }

            //    Console.ReadLine();
            //}




            //MORE IF STATEMENTS

            //    Console.WriteLine(GetMax(20, 10, 40));

            //    Console.ReadLine();
            //}

            //static int GetMax(int num1, int num2, int num3)
            //{
            //    int result;

            //    if (num1 >= num2 && num1 >= num3)
            //    {
            //        result = num1;
            //    } else if (num2 >= num1 && num2 >= num3)
            //    {
            //        result = num2;
            //    } else
            //    {
            //        result = num3;
            //    }

            //    return result;
            //}



            //BUILDING A BETTER CALCULATOR

            //Console.Write("Enter a number: ");
            //double num1 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter Operator: ");
            //string op = Console.ReadLine();

            //Console.Write("Enter a number: ");
            //double num2 = Convert.ToDouble(Console.ReadLine());

            //if (op == "+")
            //{
            //    Console.WriteLine(num1 + num2);
            //} else if (op == "-")
            //{
            //    Console.WriteLine(num1 - num2);
            //} else if (op == "*")
            //{
            //    Console.WriteLine(num1 * num2);
            //}
            //else if (op == "/")
            //{
            //    Console.WriteLine(num1 / num2);
            //} else
            //{
            //    Console.WriteLine("Invalid operator");
            //}



            //SWITCH STATEMENTS

            //Convert numbers to days of the week.  0 is Sunday, 1 is Monday, 2 is Tuesday, etc.

            //    Console.WriteLine(GetDay(3));

            //    Console.ReadLine();
            //}

            //static string GetDay(int dayNum)
            //{
            //    string dayName;

            //    switch (dayNum)
            //    {
            //        case 0:
            //            dayName = "Sunday";
            //            break;
            //        case 1:
            //            dayName = "Monday";
            //            break;
            //        case 2:
            //            dayName = "Tuesday";
            //            break;
            //        case 3:
            //            dayName = "Wednesday";
            //            break;
            //        case 4:
            //            dayName = "Thursday";
            //            break;
            //        case 5:
            //            dayName = "Friday";
            //            break;
            //        case 6:
            //            dayName = "Saturday";
            //            break;
            //        default:
            //            dayName = "Invalid entry";
            //            break;
            //    }

            //    return dayName;
            //}



            //WHILE LOOPS

            //int number = 1;
            ////Block of code to run while the condition provided is true
            //while (number <= 5)
            //{
            //    Console.WriteLine(number);
            //    number++;
            //}

            ////DO WHILE LOOP

            ////This type of loop executes the code provided prior to checking the condition
            //int index = 6;
            //do
            //{
            //    Console.WriteLine(index);
            //    index++;
            //} while (index <= 5);



            //BUILDING A GUESSING GAME

            //string secretWord = "giraffe";
            //string guess = "";
            //int guessCount = 0;
            //int guessLimit = 3;
            //bool outOfGuesses = false;

            //while(guess != secretWord && !outOfGuesses)
            //{
            //    if (guessCount < guessLimit)
            //    {
            //        Console.Write("Enter guess: ");
            //        guess = Console.ReadLine();
            //        guessCount++;
            //    }
            //    else
            //    {
            //        outOfGuesses = true;
            //    }

            //}
            //if (outOfGuesses)
            //{
            //    Console.Write("You lose!");
            //}
            //else
            //{
            //    Console.Write("You win!");
            //}



            //FOR LOOPS

            //int[] luckyNumbers = { 4, 8, 15, 16, 23, 42 };
            //for (int i = 0; i < luckyNumbers.Length; i++)
            //{
            //    Console.WriteLine(luckyNumbers[i]);
            //}



            //BUILDING AN EXPONENT METHOD

            //Provide two numbers (a base number and a power number)
            //    Console.WriteLine(GetPow(4, 3));
            //    Console.ReadLine();
            //}

            //static int GetPow(int baseNum, int powNum)
            //{
            //    int result = 1;

            //    for (int i = 0; i < powNum; i++)
            //    {
            //        result = result * baseNum;
            //    }

            //    return result;



            //2D ARRAYS

            //Where each element in an array has its own array, like a matrix

            //int[,] numberGrid = { //the comma tells C# we want a 2D array.  Add another comma for 3D array, and more commas as needed.
            //    {1, 2},
            //    {3, 4},
            //    {5, 6},
            //};
            //int[,] myArray = new int[2, 3]; //another way to declare this.  There are two elements, and each of those elements has three of its own elements

            //Console.WriteLine(numberGrid[2, 1]); //enter what Row number (beginning at 0), then what Column number (beginning at 0) you wish to access.  Example: 2, 1 means number 6 would print.



            //COMMENTS

            //Comments work in C# just like they work in JavaScript.

            /*
             Example
             of
             a
             multi-line
             comment.
             */

            //Console.WriteLine("Comments are fun!");



            //EXCEPTION HANDLING

            //Exceptions come up when there are parts of the code that C# is unable to handle

            //Example - run the code below and try to divide 5 by 0.  Exceptions occur when we do not have the catch block.

            //try
            //{
            //    Console.Write("Enter a number: ");
            //    int num1 = Convert.ToInt32(Console.ReadLine());
            //    Console.Write("Enter another number: ");
            //    int num2 = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine(num1 / num2);
            //}
            //catch(Exception e) //Declares e as a variable that contains the exception message from the system.  This catches any type of exception.  Usually is better practice to capture the specific exceptions.
            ////catch(DivideByZeroException e) <-- this would catch only Divide By Zero exceptions
            ////catch(FormatException e) <-- this would catch only Format exceptions
            //{
            //    Console.WriteLine(e.Message);  //The system will tell the user what went wrong.
            //}
            //finally
            //{
            //    Console.WriteLine("Thanks for using this application!");
            //}



            //CLASSES & OBJECTS

            //Class is a specification for a new data type
            //Classes are used to model real-world entities inside of our programs
            //Objects are instances of a class

            //Book book1 = new Book(); //creating an instance of a book
            //book1.title = "Harry Potter and the Sorcerer's Stone";
            //book1.author = "J.K. Rowling";
            //book1.numberOfPages = 309;

            //Book book2 = new Book(); //creating an instance of a book
            //book2.title = "Carrie";
            //book2.author = "Stephen King";
            //book2.numberOfPages = 199;

            //Console.WriteLine(book1.title);
            //Console.WriteLine(book1.author);
            //Console.WriteLine(book1.numberOfPages);

            //Console.WriteLine(book2.title);
            //Console.WriteLine(book2.author);
            //Console.WriteLine(book2.numberOfPages);



            //CONSTRUCTORS

            //Special method that can go into a C# class that will get called whenever we create an object of that class

            //Book book1 = new Book("Harry Potter and the Sorcerer's Stone", "J.K. Rowling", 309); //creating the book through the constructor

            //Book book2 = new Book("Carrie", "Stephen King", 199); //creating the book through the constructor

            //Console.WriteLine(book1.numberOfPages);
            //Console.WriteLine(book2.title);


            
            //OBJECT METHODS

            //Student student1 = new Student("Jim", "Business", 2.8);
            //Student student2 = new Student("Pam", "Art", 3.6);

            //Console.WriteLine(student1.HasHonors());
            //Console.WriteLine(student2.HasHonors());



            //GETTERS & SETTERS

            Movie avengers = new Movie("The Avengers", "Joss Whedon", "Dog");
            Movie shrek = new Movie("Shrek", "Adam Adamson", "PG");
            //Valid Ratings - G, PG, PG-13, R, NR

            Console.WriteLine(avengers.Rating);
            Console.WriteLine(shrek.Rating);

            Console.ReadLine();
        }
    }
}
