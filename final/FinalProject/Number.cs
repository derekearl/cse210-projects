using System;

public class deNumber: deExercise
{
    public deNumber()
    {
        List<int> Digits = getRandomNumbers();
        for (int i = 0; i < 6; i++)
        {
            if (i != 5){
                Console.Write($"{Digits[i]},");
            }
            else Console.WriteLine($"{Digits[i]}");
        }
        Thread.Sleep(10000);
        Console.Clear();
    }

    public List<int> getRandomNumbers()
    {
        // List of random numbers
        List<int> randNums = new List<int>();        
        // Get 6 random numbers between 0-9
        for(int i = 0; i < 6; i++) {
            // Get valid data
            int randNum = ValidateRandomNumberData(randNums);
            // Put valid data in list.
            randNums.Add(randNum);
        }
        return randNums;
    }

    private int ValidateRandomNumberData(List<int> randNums) {
        Random random = new Random();
        int randNum = random.Next(0,9);
        // Loop will read to see if a number will appear more than twice and
        // it will go through again until the number does not appear twice.
        while (MoreThanTwice(randNums, randNum)){
            int newRandNum = random.Next(0,9);
            //Loop will give a new number if previous number appeared thrice.
            while (newRandNum == randNum) {
                newRandNum = random.Next(0,9);
            }
            randNum = newRandNum;
        }
        return randNum;
    }
    private bool MoreThanTwice(List<int> nums, int randNum) {
        // Check if the number already exists in the list more than twice.
        int counter = 0; // Count how many times the number exists in the list
        foreach (int num in nums) {
            if (num == randNum) {
                counter++;
            }
        }
        if (counter > 2) return true;
        else return false;
        // if the number exists more than twice, then pick a different number.

    }

}
