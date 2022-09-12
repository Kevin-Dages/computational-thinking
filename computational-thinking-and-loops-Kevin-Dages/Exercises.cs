using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace template_csharp_computational_thinking
{
    internal class Exercises
    {
        public static void AreTheseIntegersEqual()
        {
            // Ask the user for two integers. 
            // Check and see if the two integers are equal to each other.
            // If they are, inform the the user that the numbers are equal,
            // else inform the user that the numbers are not equal


            // Enter your solution here

            int int1,int2;

            Console.Clear();
            Console.WriteLine("ARE THESE INTEGERS EQUAL?\n"); // \n = a new line gives a space intbetween currrent line and next line 

            
            Console.WriteLine("Input first number: ");    //Convert allows for me to go from one data type to the next so I can take a string and make it a integer
            int1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input Second number: ");
            int2 = Convert.ToInt32(Console.ReadLine());

            if (int1 == int2)
            {
                Console.WriteLine("These two numbers are equal"); 
            }
            else
            {
                Console.WriteLine("These two numbers are not equal"); 
            }

             //put nothing below this

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        public static void EvenOrOdd()
        {
            // Ask the user for a number.
            // Tell the user if that number is even or odd.

            //how the computer recs if its even or odd is it takes the number and / it by 2 and if the remainder is 0 it = even
            // if the computer / it by 2 and the remainder is 1 its odd


            Console.Clear();
            Console.WriteLine("EVEN OR ODD?\n");

            // Enter your solution here

            int userNumber, remainder;

            userNumber = Convert.ToInt32(Console.ReadLine());  //This converts the user input string to a int

            remainder = userNumber % 2;   //remainder variable takes the users number and divides it by two and if it equals zero it is a even number

            if(remainder == 0)
            {
                Console.WriteLine("This number is Even");
            }
            else
            {
                Console.WriteLine("This number is Odd");
            }

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        public static void VowelOrConsonant()
        {
            // Ask the user for a letter. Check whether a letter is a vowel or consonant.
            // Hint: You can do this problem using a switch or an if condition.

            Console.Clear();
            Console.WriteLine("VOWEL OR CONSONANT?\n");

            // Enter your solution here



            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        public static void FindLargestNumber()
        {
            // Prompt the user to input two integer values.
            // Find and print the greatest value of the two integers.

            Console.Clear();
            Console.WriteLine("FIND THE LARGEST NUMBER\n");

            // Enter your solution here

            int largeNumber1, largeNumber2;

            Console.WriteLine("Enter Number One");
            largeNumber1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Number Two");
            largeNumber2 = Convert.ToInt32(Console.ReadLine());

            if(largeNumber1 > largeNumber2)
            {
                Console.WriteLine(largeNumber1 + "is a larger number");
            }
            if (largeNumber2 > largeNumber1)
            {
                Console.WriteLine(largeNumber2 + " is a larger number");
            }

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        public static void DivisibleBy3()
        {
            // Ask the user for a number and then tell them if it is divisible by 3

            Console.Clear();
            Console.WriteLine("DIVISIBLE BY 3\n");

            // Enter your solution here

            int divideNumber;

            Console.WriteLine("Enter a number to see if it can be divided by 3");
            divideNumber = Convert.ToInt32(Console.ReadLine());

            if (divideNumber % 3 == 0)
            {
                Console.WriteLine("This number is divisable 3");
            }
            else
            {
                Console.WriteLine("This number is not divisible by 3");
            }

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        public static void WordsToDigits()
        {
            // Having a string representation of a number, you need to print the digit form of the number.
            // Ask the user to enter a string representation of a number from zero to ten.
            // Using switch case, print the digit (0-10) representation of the number.

            Console.Clear();
            Console.WriteLine("WORDS TO DIGITS\n");

            // Enter your solution here
                    
            Console.WriteLine("Enter a string value from one - ten");
            string one = "one";
            string two = "two";
            string three = "three";
            string four = "four";
            string five = "five";
            string six = "six";
            string seven = "seven";
            string eight = "eight";
            string nine = "nine";
            string ten = "ten";
            string input = Console.ReadLine();

            switch(input)
            {
                case "one":
                    Console.WriteLine("1");
                    break;
                case "two":
                    Console.WriteLine("2");
                    break;
                case "three":
                    Console.WriteLine("3");
                    break;
                case "four":
                    Console.WriteLine("4");
                    break;
                case "5":
                    Console.WriteLine("5");
                    break;
                case "six":
                    Console.WriteLine("6");
                    break;
                case "seven":
                    Console.WriteLine("7");
                    break;
                case "eight":
                    Console.WriteLine("8");
                    break;
                case "nine":
                    Console.WriteLine("9");
                    break;
                case "ten":
                    Console.WriteLine("ten");
                    break;

            }



            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        public static void WhichNameIsLonger()
        {
            // Ask the user for their first and last name.

            // Print the user's full name.
            // If the first name is longer than the last name, print "First is longer."
            // If the first name and last name are the same length, print "Same-sies!"
            // Otherwise, print "Last must be longer!"

            Console.Clear();
            Console.WriteLine("WHICH NAME IS LONGER?\n");

            // Enter your solution here

            string firstName, lastName;

            Console.WriteLine("Enter your first Name");
            firstName = (Console.ReadLine());

            Console.WriteLine("Enter your last name");
            lastName = (Console.ReadLine());


            if (firstName.Length > lastName.Length)  //.Length gets the number of characters inside of your string
            {
                Console.WriteLine("First name is longer");
            }
            if (firstName.Length  < lastName.Length)
            {
                Console.WriteLine("Last Name is longer");
            }
            else if(lastName.Length == firstName.Length)
            {
                Console.WriteLine("Same Size Name");
            }
            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        public static void AreNamesSame()
        {
            // Ask the user for 2 names.

            // If the two names are the same, print "The names are the same."
            // If they're not the same, print "The names are different."

            Console.Clear();
            Console.WriteLine("ARE THESE NAMES THE SAME?\n");

            // Enter your solution here
            string name1, name2;
            
            Console.WriteLine("Enter Name #1");
           name1 = Console.ReadLine();

            Console.WriteLine("Enter Name #2");
            name2 = Console.ReadLine();

            if (name1.Equals(name2))
            {
                Console.WriteLine("These Names are the same");
            }
            else
            {
                Console.WriteLine("These name are different");
            }

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        public static void NameAndBirthplace()
        {
            // Ask the user for their first name and where they were born.
            // Print a sentence to the console that repeats this information.

            Console.Clear();
            Console.WriteLine("NAME AND PLACE OF BIRTH\n");

            // Enter your solution here
            string firstName, placeofbirth;

            Console.WriteLine("Enter your first name");
           firstName = Console.ReadLine();

            Console.WriteLine("Enter your place of birth");
           placeofbirth = Console.ReadLine();

            Console.WriteLine(firstName + " Was born in " + placeofbirth);

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }


        //LOOPS SECTION
        //For this next section, in order to get a passing grade, each of the following problems must be solved using at least one of the the loop types we learned in class.

        public static void ReverseCounting()
        {
            // Ask the user for a number between 1-20. Starting at the number given,
            // count backwards to 1 and print the numbers to the console.

            Console.Clear();
            Console.WriteLine("REVERSE COUNTING\n");

            // SOLUTION HERE
            int numberPicked, i;

            Console.WriteLine("Pick a number between 1-20 ");
            numberPicked = Convert.ToInt32(Console.ReadLine());

            for(i = numberPicked; numberPicked >= 1 ; numberPicked -= 1  )
                Console.WriteLine(numberPicked);
                if(numberPicked == 1)
                              

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        public static void SquareOfEvenNumbers()
        {
            // For the numbers 1-9, if a number is even print the square of that number (number multiplied by itself) and if it is odd, just print the number

            Console.Clear();
            Console.WriteLine("PRINT THE SQUARE OF EVEN NUMBERS\n");

            // SOLUTION HERE
          

            for(var i = 1; i <= 9 ; i++)
            {

                if (i % 2 == 0)
                {
                    Console.WriteLine(i * 2);
                }
               
                
            }
               
            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        public static void GuessMagicNumber()
        {
            // Write a console application that asks the user for an integer.
            // If that integer is evenly divisible by 3, then print “You Won!”.
            // If it isn’t, ask the user to “Try again.”
            // Keep asking them for a number (looping) until they win.

            Console.Clear();
            Console.WriteLine("GUESS THE MAGIC NUMBER\n");



            // This reads the user's input and converts it to an integer.
            // We'll assume that users can only input integers.
            // SOLUTION HERE
            bool tryAgiain = true;
                Console.WriteLine("Enter an integer");

                int userInput = Convert.ToInt32(Console.ReadLine());

                var remainder1 = userInput & 1;


                if (remainder1 == 1)
                {
                    Console.WriteLine("You Won");
                }
                else
                {
             
                }
            
            
            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }
    }
}
