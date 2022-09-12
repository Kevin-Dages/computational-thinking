# Computational Thinking Exercises
 Make sure you only code where prompted in the Exercises.cs file. This means any code you write should be one line directly under "//Enter your solution here" and should never go beyond "Console.Write("Press enter to return to the Main Menu");" Once you are done with one solution, find the next spot down in the code to start your next solution to the next problem.  
## Are These Integers Equal?
Ask the user for two integers. Check and see if the two integers are equal to each other. If they are, inform the the user that the numbers are equal, else inform the user that the numbers are not equal

&;Input: 16

;&nbsp;Input: 18

;**Output:** The numbers 16 and 18 are not equal to each other

;Input: Enter your first number: 25

&;Input: Enter your second number: 25

:** The numbers 25 and 25 are the same number

## Even or Odd?
Ask the user for a number. Tell the user if that number is even or odd.

;Input: 15

;**Output:** 15 is an odd number

;Input: 116

:** 116 is an even number

## Vowel or Consonant?
Ask the user for a letter. Check whether a letter is a vowel or consonant. Hint: You can do this problem using a switch or an if condition.

;Input: a

:** That letter a is a vowel

Input: c

 The letter c is a consonant


## Find the Largest Number
Prompt the user to input two integer values. Find and print the greatest value of the two integers.

;Input:  25

;Input: -25

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Output:** 25 is the larger number
#### BONUS: Ask the user for 3 numbers and find the greatest value between those 3 numbers

## Divisible by 3
Ask the user for a number and then tell them if it is divisible by 3

;Input: 5

:** not divisible by 3

;Input: 306

111*Output:** divisible by 3

## Words to Digits
Having a string representation of a number, you need to print the digit form of the number. Ask the user to enter a string representation of a number from zero to ten. Using switch case, print the digit (0-10) representation of the number.

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Input: two

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Output:** 2

## Which Name is Longer?
Ask the user for their first and last name.
Print the user's full name.
- If the first name is longer than the last name, print "First is longer."
- If the first name and last name are the same length, print "Same-sies!"
- Otherwise, print "Last must be longer!"
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Input: Mary

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Input: Brown

**Output:** Mary Brown. Last must be longer!

## Are these Names the Same?
Ask the user for 2 names.
- If the two names are the same, print "The names are the same."
- If they're not the same, print "The names are different."
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Input: Joe

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Input: Joseph

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Output:** The names are different

First try using == and then try it using .Equals()

## Name and Place of Birth
Ask the user for their first name and where they were born. Print a sentence to the console that repeats this information.

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Input: John

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Input: Delaware

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Output:** Hi John!  You were born in Delaware.

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Input: Yvonne

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Input: San Diego

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Output:** Hi Yvonne!  You were born in San Diego.

# Loops Section 
## Numbers In Reverse
Print out numbers from 5 to 1.

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;No Input

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Output:** 5 4 3 2 1

## Reverse Counting
Ask the user for an integer input between 1 and 20 inclusive. Starting at the number given, count backwards to 1 and print the result.

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Input: 15

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Output:** 15 14 13 12 11 10 9 8 7 6 5 4 3 2 1 

## Square Of Even Numbers
Print the squares (the number multiplied by itself) for even numbers between 1-9. For the odd numbers, just print them.

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;No Input

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Output:** 1 4 3 16 5 36 7 64 9

## Guess Magic Number
Write a console application that asks the user for an integer.
- If that integer is evenly divisible by 3, then print “You Won!”.
- If it isn’t, ask the user to “Try again.”

Keep asking them for a number (looping) until they win.
**HINT:** Use a while loop and Console.ReadLine() to keep updating the user's input.

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Input: 1

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Output:** "Try again."


&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Input: 2

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Output:** "Try again."


&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Input: 3

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Output:** "You Won!"
