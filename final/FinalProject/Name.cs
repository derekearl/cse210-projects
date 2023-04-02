using System;

public class deName: deExercise
{
    public deName()
    {
        string[] deLetters = 
        {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z",
        };

        public string deLetter;
        public string letterInput;

        public void getLetter()
        {
            Random random = new Random();
            deLetter = deLetters[random.Next(0,25)];
            Console.WriteLine("Your letter will be");
            Console.WriteLine(deLetter);
            string letterInput = Console.ReadLine();
        }
    }
