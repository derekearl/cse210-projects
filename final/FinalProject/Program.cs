using System;

class Program
{
    static void Main(string[] args)
    {
        //Welcomes the user to the exercises.
        Console.WriteLine("Welcome to the Speech Pathology Exercise!");
        //Give the list of exercises for the user to select.
        Console.WriteLine("Please select one of the following Exercises!");
        Console.WriteLine("1. Number Game");
        Console.WriteLine("2. Alphabet Game");
        Console.WriteLine("3. Name Game");
        Console.WriteLine("4. State Game");
        Console.WriteLine("5. Homophone Game");
        Console.WriteLine("6. Category Game");
        Console.WriteLine("(Select a number 1-7)-->");
        //User selects one of the exercisees.
        string choice = Console.ReadLine();
        switch(choice)


        {
            case "1":
                break;
            case "2":
                break;
            case "3":
                break;
            case "4":
                break;
            case "5":
                break;
            case "6":
                break;
            case "7":
                break;
            default:
                break;
        }
        if (choice == "1")
        {
            //NUMBER GAME
            //user will given a random set of numbers to memorize.
            //User will have 10 seconds to memorize a random set of numbers.
            //Number will dissappear and the user will need to type in the numbers from the list.
            //If numbers match what was given then you pass. If not they can try again.
            Console.WriteLine("You will be given 10 seconds to memorize random generated numbers.");
            Console.WriteLine("Type out the numbers as closely in order on the random generated list.");
            Console.WriteLine("Press Enter to start the game!");
            Console.Read();
            deNumber number = new deNumber();
        }

        else if(choice == "2")
        {
            //ALPHABET GAME
            //User will given a random set of words.
            //User will need to organize the words in aplphabetical order.
            //If words are in alphbetical order then you pass.
            Console.WriteLine("You will be given four random words.");
            Console.WriteLine("Organize each word in alphbetical order.");
            Console.WriteLine("Press Enter to start the game!");
            Console.Read();
            deAlphabetical alphabetical = new deAlphabetical();
        }

        else if (choice == "3")
        {
            //NAME GAME
            //User will be given a random letter.
            //User will have 10 seconds to type as many words that start with the random generated letter.
            Console.WriteLine("You will be given a random letter of the alphabet");
            Console.WriteLine("You will have 10 seconds to type out as many words that start with that letter.");
            Console.WriteLine("Press Enter to start the game!");
            Console.Read();
            deName name = new deName();
        }

        else if (choice == "4")
        {
            //STATE GAME
            //User will be given 20 seconds to type as many states as possible.
            Console.WriteLine("Type out as many states as possible in 20 seconds.");
            Console.WriteLine("Press Enter to start the game!");
            Console.Read();
            deState state = new deState();
        }

        else if (choice == "5")
        {
            //HOMOPHONE GAME
            //User will have 20 seconds to type out as many homophones as possible
            Console.WriteLine("Type out as many homophones as possible");
            Console.WriteLine("Press Enter to start the game!");
            Console.Read();
            deHomophone homophone = new deHomophone();
        }

        else if (choice == "6")
        {
            //CATEGORY GAME
            //User will given three words that are related in some way.
            //User will need to type a word that is similar to the other three words as well.
            Console.WriteLine("You will be given three words that are realted in some way.");
            Console.WriteLine("Add another word to the list that share similarities with the other words.");
            Console.WriteLine("Press Enter to start the game!");
            Console.Read();

        }
    }
}