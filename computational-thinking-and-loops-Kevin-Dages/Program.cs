using template_csharp_computational_thinking;

bool keepThinking = true;
while (keepThinking)
{
    Console.Clear();
    Console.WriteLine("WELCOME TO WE CAN CODE IT\n");
    Console.WriteLine("COMPUTATIONAL THINKING EXERCISES\n");
    Console.WriteLine("Which exercise would you like to run?");
    Console.WriteLine("1. Are These Integers Equal?");
    Console.WriteLine("2. Even or Odd?");
    Console.WriteLine("3. Vowel or Consonant?");
    Console.WriteLine("4. Find the Largest Number");
    Console.WriteLine("5. Divisible by 3");
    Console.WriteLine("6. Words to Digits");
    Console.WriteLine("7. Which Name is Longer?");
    Console.WriteLine("8. Are these Names the Same?");
    Console.WriteLine("9. Name and Place of Birth");
    Console.WriteLine("LOOPS SECTION");
    Console.WriteLine("10. Reverse Counting");
    Console.WriteLine("11. Square of Even Numbers");
    Console.WriteLine("12. Guess the Magic Number");
    Console.WriteLine("Press Q to quit");

    string userChoice = Console.ReadLine().ToLower();

    switch (userChoice)
    {
        case "1":
            Exercises.AreTheseIntegersEqual();
            break;
        case "2":
            Exercises.EvenOrOdd();
            break;
        case "3":
            Exercises.VowelOrConsonant();
            break;
        case "4":
            Exercises.FindLargestNumber();
            break;
        case "5":
            Exercises.DivisibleBy3();
            break;
        case "6":
            Exercises.WordsToDigits();
            break;
        case "7":
            Exercises.WhichNameIsLonger();
            break;
        case "8":
            Exercises.AreNamesSame();
            break;
        case "9":
            Exercises.NameAndBirthplace();
            break;
        case "10":
            Exercises.ReverseCounting();
            break;
        case "11":
            Exercises.SquareOfEvenNumbers();
            break;
        case "12":
            Exercises.GuessMagicNumber();
            break;
        case "q":
            keepThinking = false;
            Console.WriteLine("Good bye!");
            break;
        default:
            break;
    }
}
