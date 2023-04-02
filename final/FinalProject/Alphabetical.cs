using System;

public class deAlphabetical: deExercise
{
    public deAlphabetical()
    {
        string[] wordPrompts = 
        {
            "Dog, Cat, Mouse, Bird, Zebra, Hipppo:  ",
            "Charizard, Pikachu, Arcanine, Sceptile, Snorlax, Metagross:  ",
            "Link, Zelda, Gannondorf, Darunia, Sheik, Saria:  ",
            "Cloud, Tifa, Yuffie, Vincent, Red XIII,  Aerith:  ",
            "John, Dutch, Arthur, Micah, Hosea, Charles:  ",
            "Ulfric, Tullius, Lokir, Ralof, Cicero, Astrid:  ",
            "Halo, Fable, Uncharted, Darksiders, Sekiro:  ",
            "Ghosts 'n Goblins, Donkey Kong Country, Kingdom Hearts, Grand Theft Auto:  "
        };

        public string wordPrompt;
        public string deUserInput;

        public void getWords ()
        {
            Random random = new Random();
            wordPrompt = wordPrompts[random.Next(0,7)];
            Console.WriteLine(wordPrompt);
            string deUserInput = Console.ReadLine();
        }
    }
}    
