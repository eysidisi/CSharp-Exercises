using System;
using System.Collections.Generic;
using System.Linq;

public class AliihsanHelperClass
{
    internal static bool GetIntInputsWithCommaBetween(ref int[] inputs, out bool quit)
    {
        quit = false;
        // Get two numbers from  user
        Console.WriteLine($"Enter {inputs.Length} number(s) with a comma in between and q to quit!");
        string input = Console.ReadLine();

        if (input == "q")
        {
            quit = true;
            return false;
        }

        // Parse input string
        List<string> parsedInput = input.Split(new char[] { ',' },
            StringSplitOptions.RemoveEmptyEntries).ToList();

        if (parsedInput.Count != inputs.Length)
        {
            return false;
        }

        // Delete spaces
        parsedInput.ForEach((numberInString) => numberInString = numberInString.Replace(" ", ""));

        List<int> inputNumbers = new List<int>();

        foreach (var numberInString in parsedInput)
        {
            if (!int.TryParse(numberInString, out int numberInInt))
            {
                return false;
            }

            inputNumbers.Add(numberInInt);
        }

        inputs = inputNumbers.ToArray();
        return true;
    }
}