using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class BasicAlgorithmExercises : IBasicAlgorithmExercises
{
    public void Exercise1()
    {
        while (true)
        {
            // Get two numbers from  user
            Console.WriteLine("Enter two numbers with a comma in between");
            string input = Console.ReadLine();

            // Parse input string
            List<string> parsedInput = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            if (parsedInput.Count != 2)
            {
                Console.WriteLine("Error at the given input!");
                continue;
            }

            // Delete spaces
            parsedInput.ForEach((numberInString) => numberInString = numberInString.Replace(" ", ""));

            // Convert inputs from string to int
            List<int> intInputs = new List<int>();

            bool errorOccured = false;
            foreach (var numberInString in parsedInput)
            {
                bool parsingResult = int.TryParse(numberInString, out int numberInInt);
                if (!parsingResult)
                {
                    Console.WriteLine("Error at the given input!");
                    errorOccured = true;
                    break;
                }
                intInputs.Add(numberInInt);
            }

            if (errorOccured)
            {
                continue;
            }

            // Operation result
            int? result = null;

            if (intInputs[0] == intInputs[1])
            {
                result = 6 * intInputs[0];
            }
            else
            {
                result = intInputs.Sum();
            }

            Console.WriteLine($"{result}");
        }
    }

    public void Exercise10()
    {
        while (true)
        {
            Console.WriteLine("Enter a number. Enter 'q' to quit!");

            string input = Console.ReadLine();

            if (input.Equals("q"))
            {
                Console.WriteLine("Quitting...");
                break;
            }

            if (string.IsNullOrEmpty(input) || !int.TryParse(input, out int inputNumber))
            {
                Console.WriteLine("Input is not valid");
                continue;
            }

            if (inputNumber % 3 == 0 || inputNumber % 7 == 0)
            {
                Console.WriteLine("True");
            }

            else
            {
                Console.WriteLine("False");
            }
        }
    }

    public void Exercise100()
    {
        while (true)
        {
            Console.WriteLine("Write an int array with a comma between each number. i.e 10,20,30,40,");

            string input = Console.ReadLine().Trim();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Wrong format");
                continue;
            }

            string[] parsedInput = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            List<int> numbers = new List<int>();

            bool errorOccured = false;
            foreach (var item in parsedInput)
            {
                if (int.TryParse(item, out int number))
                {
                    numbers.Add(number);
                }
                else
                {
                    errorOccured = true;
                    break;
                }
            }

            if (errorOccured)
            {
                Console.WriteLine("error with given input!");
                continue;
            }

            Console.WriteLine(numbers.FindAll(num => num == 10).Count == 2 || numbers.FindAll(num => num == 20).Count == 2);
        }
    }

    public void Exercise101()
    {
        while (true)
        {
            Console.WriteLine("Write an int array with a comma between each number. i.e 10,20,30,40,");

            string input = Console.ReadLine().Trim();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Wrong format");
                continue;
            }

            string[] parsedInput = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            List<int> numbers = new List<int>();

            bool errorOccured = false;
            foreach (var item in parsedInput)
            {
                if (int.TryParse(item, out int number))
                {
                    numbers.Add(number);
                }
                else
                {
                    errorOccured = true;
                    break;
                }
            }

            if (errorOccured)
            {
                Console.WriteLine("error with given input!");
                continue;
            }

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] == 5 && numbers[i + 1] == 7)
                {
                    numbers[i + 1] = 1;
                }
            }

            foreach (var num in numbers)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine();
        }
    }

    public void Exercise102()
    {
        while (true)
        {
            Console.WriteLine("Write two int arrays with a comma between each number and paranthesis around each array. " +
                "i.e { 10, 20, 40, 50 }, { 10, 20, 40, 50 }");

            string input = Console.ReadLine().Trim();
            input = Regex.Replace(input, " ", "");

            if (string.IsNullOrWhiteSpace(input) || input.Count(chr => chr == '{') != 2 || input.Count(chr => chr == '}') != 2)
            {
                Console.WriteLine("Wrong format");
                continue;
            }

            string[] inputArrays = new string[2];
            inputArrays[0] = input.Substring(1, input.IndexOf('}') - 1);
            inputArrays[1] = input.Substring(input.LastIndexOf('{') + 1, input.LastIndexOf('}') - input.LastIndexOf('{') - 1);

            int[][] intArrays = new int[2][];

            bool errorOccured = false;
            for (int arrayIndex = 0; arrayIndex < inputArrays.Length; arrayIndex++)
            {
                string[] parsedIntArray = inputArrays[arrayIndex].Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                intArrays[arrayIndex] = new int[parsedIntArray.Length];

                for (int strIndex = 0; strIndex < parsedIntArray.Length; strIndex++)
                {
                    if (int.TryParse(parsedIntArray[strIndex], out int intVal))
                    {
                        intArrays[arrayIndex][strIndex] = intVal;
                    }
                    else
                    {
                        errorOccured = true;
                        break;
                    }
                }

                if (errorOccured)
                {
                    break;
                }
            }

            if (errorOccured)
            {
                Console.WriteLine("problem with given input");
                continue;
            }

            int largerArrIndex = intArrays[0].Sum() > intArrays[1].Sum() ? 0 : 1;

            Console.Write("Larger arr: ");
            for (int i = 0; i < intArrays[largerArrIndex].Length; i++)
            {
                Console.Write(intArrays[largerArrIndex][i] + " ");
            }

            Console.WriteLine();
        }
    }

    public void Exercise103()
    {
        while (true)
        {
            Console.WriteLine("Write an int array with a comma between each number. i.e 10,20,30,40,");

            string input = Console.ReadLine().Trim();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Wrong format");
                continue;
            }

            string[] parsedInput = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            List<int> numbers = new List<int>();

            bool errorOccured = false;
            foreach (var item in parsedInput)
            {
                if (int.TryParse(item, out int number))
                {
                    numbers.Add(number);
                }
                else
                {
                    errorOccured = true;
                    break;
                }
            }

            if (errorOccured || numbers.Count <= 1)
            {
                Console.WriteLine("error with given input!");
                continue;
            }

            Console.WriteLine(numbers[numbers.Count / 2 - 1] + " " + numbers[numbers.Count / 2]);
        }
    }

    public void Exercise104()
    {
        while (true)
        {
            Console.WriteLine("Write two int arrays with a comma between each number and paranthesis around each array. " +
                "i.e { 10, 20, 40, 50 }, { 10, 20, 40, 50 }");

            string input = Console.ReadLine().Trim();
            input = Regex.Replace(input, " ", "");

            if (string.IsNullOrWhiteSpace(input) || input.Count(chr => chr == '{') != 2 || input.Count(chr => chr == '}') != 2)
            {
                Console.WriteLine("Wrong format");
                continue;
            }

            string[] inputArrays = new string[2];
            inputArrays[0] = input.Substring(1, input.IndexOf('}') - 1);
            inputArrays[1] = input.Substring(input.LastIndexOf('{') + 1, input.LastIndexOf('}') - input.LastIndexOf('{') - 1);

            int[][] intArrays = new int[2][];

            bool errorOccured = false;
            for (int arrayIndex = 0; arrayIndex < inputArrays.Length; arrayIndex++)
            {
                string[] parsedIntArray = inputArrays[arrayIndex].Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                intArrays[arrayIndex] = new int[parsedIntArray.Length];

                for (int strIndex = 0; strIndex < parsedIntArray.Length; strIndex++)
                {
                    if (int.TryParse(parsedIntArray[strIndex], out int intVal))
                    {
                        intArrays[arrayIndex][strIndex] = intVal;
                    }
                    else
                    {
                        errorOccured = true;
                        break;
                    }
                }

                if (errorOccured)
                {
                    break;
                }
            }

            if (errorOccured)
            {
                Console.WriteLine("problem with given input");
                continue;
            }

            int[] newArr = intArrays[0].Concat(intArrays[1]).ToArray();

            Console.WriteLine($"{string.Join(",", newArr)}");
        }
    }

    public void Exercise105()
    {
        while (true)
        {
            Console.WriteLine("Write an int array with a comma between each number. i.e 10,20,30,40,");

            string input = Console.ReadLine().Trim();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Wrong format");
                continue;
            }

            string[] parsedInput = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            List<int> numbers = new List<int>();

            bool errorOccured = false;
            foreach (var item in parsedInput)
            {
                if (int.TryParse(item, out int number))
                {
                    numbers.Add(number);
                }
                else
                {
                    errorOccured = true;
                    break;
                }
            }

            if (errorOccured)
            {
                Console.WriteLine("error with given input!");
                continue;
            }


            int temp = numbers[0];
            numbers[0] = numbers[numbers.Count - 1];
            numbers[numbers.Count - 1] = temp;

            Console.WriteLine(string.Join(",", numbers));
        }
    }

    public void Exercise106()
    {
        while (true)
        {
            Console.WriteLine("Write an int array with a comma between each number. i.e 10,20,30,40,");

            string input = Console.ReadLine().Trim();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Wrong format");
                continue;
            }

            string[] parsedInput = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            List<int> numbers = new List<int>();

            bool errorOccured = false;
            foreach (var item in parsedInput)
            {
                if (int.TryParse(item, out int number))
                {
                    numbers.Add(number);
                }
                else
                {
                    errorOccured = true;
                    break;
                }
            }

            if (errorOccured || numbers.Count < 3)
            {
                Console.WriteLine("error with given input!");
                continue;
            }

            int middleIndex = (int)Math.Floor(numbers.Count / 2.0);

            Console.WriteLine(numbers[middleIndex - 1] + " " + numbers[middleIndex] + " " + numbers[middleIndex + 1]);
        }
    }

    public void Exercise107()
    {
        while (true)
        {
            Console.WriteLine("Write an int array with a comma between each number. i.e 10,20,30,40,");

            string input = Console.ReadLine().Trim();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Wrong format");
                continue;
            }

            string[] parsedInput = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            List<int> numbers = new List<int>();

            bool errorOccured = false;
            foreach (var item in parsedInput)
            {
                if (int.TryParse(item, out int number))
                {
                    numbers.Add(number);
                }
                else
                {
                    errorOccured = true;
                    break;
                }
            }

            if (errorOccured)
            {
                Console.WriteLine("error with given input!");
                continue;
            }

            int middleIndex = (int)Math.Floor(numbers.Count / 2.0);

            int maxElement = numbers.First() > numbers[middleIndex] ? numbers.First() : numbers[middleIndex];
            maxElement = maxElement > numbers.Last() ? maxElement : numbers.Last();

            Console.WriteLine(maxElement);
        }
    }

    public void Exercise108()
    {
        while (true)
        {
            Console.WriteLine("Write an int array with a comma between each number. i.e 10,20,30,40,");

            string input = Console.ReadLine().Trim();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Wrong format");
                continue;
            }

            string[] parsedInput = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            List<int> numbers = new List<int>();

            bool errorOccured = false;
            foreach (var item in parsedInput)
            {
                if (int.TryParse(item, out int number))
                {
                    numbers.Add(number);
                }
                else
                {
                    errorOccured = true;
                    break;
                }
            }

            if (errorOccured)
            {
                Console.WriteLine("error with given input!");
                continue;
            }

            if (numbers.Count < 2)
            {
                Console.WriteLine(string.Join(",", numbers));
                continue;
            }

            Console.WriteLine(string.Join(",", numbers.Take(2).ToArray()));
        }
    }

    public void Exercise109()
    {
        while (true)
        {
            Console.WriteLine("Write an int array with a comma between each number. i.e 10,20,30,40,");

            string input = Console.ReadLine().Trim();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Wrong format");
                continue;
            }

            string[] parsedInput = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            List<int> numbers = new List<int>();

            bool errorOccured = false;
            foreach (var item in parsedInput)
            {
                if (int.TryParse(item, out int number))
                {
                    numbers.Add(number);
                }
                else
                {
                    errorOccured = true;
                    break;
                }
            }

            if (errorOccured)
            {
                Console.WriteLine("error with given input!");
                continue;
            }


            Console.WriteLine(numbers.Count(num =>
            {
                if (num % 2 == 0)
                {
                    return true;
                }
                return false;
            }));
        }
    }

    public void Exercise11()
    {
        while (true)
        {
            Console.WriteLine("Enter a string. Enter -1 to quit!");

            string input = Console.ReadLine();

            if (input.Equals("-1"))
            {
                Console.WriteLine("Quitting...");
                break;
            }

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Input is not valid");
                continue;
            }

            string strToAdd;

            if (input.Length < 3)
            {
                strToAdd = input;
            }
            else
            {
                strToAdd = input.Substring(0, 3);
            }

            StringBuilder outputSB = new StringBuilder(input);

            outputSB = outputSB.Insert(0, strToAdd).Append(strToAdd);

            Console.WriteLine(outputSB);
        }
    }

    public void Exercise110()
    {
        while (true)
        {
            Console.WriteLine("Write an int array with a comma between each number. i.e 10,20,30,40,");

            string input = Console.ReadLine().Trim();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Wrong format");
                continue;
            }

            string[] parsedInput = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            List<int> numbers = new List<int>();

            bool errorOccured = false;
            foreach (var item in parsedInput)
            {
                if (int.TryParse(item, out int number))
                {
                    numbers.Add(number);
                }
                else
                {
                    errorOccured = true;
                    break;
                }
            }

            if (errorOccured)
            {
                Console.WriteLine("error with given input!");
                continue;
            }

            Console.WriteLine(numbers.Max() - numbers.Min());
        }
    }

    public void Exercise111()
    {
        while (true)
        {
            Console.WriteLine("Write an int array with a comma between each number. i.e 10,20,30,40,");

            string input = Console.ReadLine().Trim();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Wrong format");
                continue;
            }

            string[] parsedInput = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            List<int> numbers = new List<int>();

            bool errorOccured = false;
            foreach (var item in parsedInput)
            {
                if (int.TryParse(item, out int number))
                {
                    numbers.Add(number);
                }
                else
                {
                    errorOccured = true;
                    break;
                }
            }

            if (errorOccured)
            {
                Console.WriteLine("error with given input!");
                continue;
            }

            int sum = 0;

            numbers.ForEach(num =>
            {
                if (num != 17)
                {
                    sum += num;
                }
            });

            Console.WriteLine(sum);
        }
    }

    public void Exercise112()
    {
        while (true)
        {
            Console.WriteLine("Write an int array with a comma between each number. i.e 10,20,30,40,");

            string input = Console.ReadLine().Trim();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Wrong format");
                continue;
            }

            string[] parsedInput = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            List<int> numbers = new List<int>();

            bool errorOccured = false;
            foreach (var item in parsedInput)
            {
                if (int.TryParse(item, out int number))
                {
                    numbers.Add(number);
                }
                else
                {
                    errorOccured = true;
                    break;
                }
            }

            if (errorOccured)
            {
                Console.WriteLine("error with given input!");
                continue;
            }

            int sum = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i].ToString()[0] == '5' && i < numbers.Count - 1 && numbers[i + 1] == 6)
                {
                    i++;
                    continue;
                }

                sum += numbers[i];
            }

            Console.WriteLine(sum);
        }
    }

    public void Exercise113()
    {
        while (true)
        {
            Console.WriteLine("Write an int array with a comma between each number. i.e 10,20,30,40,");

            string input = Console.ReadLine().Trim();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Wrong format");
                continue;
            }

            string[] parsedInput = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            List<int> numbers = new List<int>();

            bool errorOccured = false;
            foreach (var item in parsedInput)
            {
                if (int.TryParse(item, out int number))
                {
                    numbers.Add(number);
                }
                else
                {
                    errorOccured = true;
                    break;
                }
            }

            if (errorOccured)
            {
                Console.WriteLine("error with given input!");
                continue;
            }

            var indices = numbers.Select((b, i) => b == 5 ? i : -1).Where(i => i != -1).ToArray();

            bool success = false;
            for (int index = 0; index < indices.Length - 1; index++)
            {
                if (indices[index + 1] - indices[index] == 1)
                {
                    success = true;
                    break;
                }
            }

            Console.WriteLine(success);
        }
    }

    public void Exercise114()
    {
        while (true)
        {
            Console.WriteLine("Write an int array with a comma between each number. i.e 10,20,30,40,");

            string input = Console.ReadLine().Trim();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Wrong format");
                continue;
            }

            string[] parsedInput = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            List<int> numbers = new List<int>();

            bool errorOccured = false;
            foreach (var item in parsedInput)
            {
                if (int.TryParse(item, out int number))
                {
                    numbers.Add(number);
                }
                else
                {
                    errorOccured = true;
                    break;
                }
            }

            if (errorOccured)
            {
                Console.WriteLine("error with given input!");
                continue;
            }

            var strNumbers = string.Join(" ", numbers).ToString();

            Console.WriteLine(strNumbers.Contains('5') && strNumbers.Contains('7'));
        }
    }

    public void Exercise115()
    {
        while (true)
        {
            Console.WriteLine("Write an int array with a comma between each number. i.e 10,20,30,40,");

            string input = Console.ReadLine().Trim();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Wrong format");
                continue;
            }

            string[] parsedInput = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            List<int> numbers = new List<int>();

            bool errorOccured = false;
            foreach (var item in parsedInput)
            {
                if (int.TryParse(item, out int number))
                {
                    numbers.Add(number);
                }
                else
                {
                    errorOccured = true;
                    break;
                }
            }

            if (errorOccured)
            {
                Console.WriteLine("error with given input!");
                continue;
            }

            int numberOfFives = numbers.FindAll(num => num == 5).Count();

            Console.WriteLine(numberOfFives == 3);
        }
    }

    public void Exercise116()
    {
        while (true)
        {
            Console.WriteLine("Write an int array with a comma between each number. i.e 10,20,30,40,");

            string input = Console.ReadLine().Trim();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Wrong format");
                continue;
            }

            string[] parsedInput = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            List<int> numbers = new List<int>();

            bool errorOccured = false;
            foreach (var item in parsedInput)
            {
                if (int.TryParse(item, out int number))
                {
                    numbers.Add(number);
                }
                else
                {
                    errorOccured = true;
                    break;
                }
            }

            if (errorOccured)
            {
                Console.WriteLine("error with given input!");
                continue;
            }

            Console.WriteLine(numbers.Count((num) => { return num == 3; }) >
                numbers.Count((num) => { return num == 5; }));
        }
    }

    public void Exercise117()
    {
        while (true)
        {
            Console.WriteLine("Write an int array with a comma between each number. i.e 10,20,30,40,");

            string input = Console.ReadLine().Trim();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Wrong format");
                continue;
            }

            string[] parsedInput = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            List<int> numbers = new List<int>();

            bool errorOccured = false;
            foreach (var item in parsedInput)
            {
                if (int.TryParse(item, out int number))
                {
                    numbers.Add(number);
                }
                else
                {
                    errorOccured = true;
                    break;
                }
            }

            if (errorOccured)
            {
                Console.WriteLine("error with given input!");
                continue;
            }

            Console.WriteLine(numbers.Count((num) => { return num == 3; }) == numbers.Count() ||
                numbers.Count((num) => { return num == 5; }) == numbers.Count());
        }
    }

    public void Exercise118()
    {
        while (true)
        {
            Console.WriteLine("Write an int array with a comma between each number. i.e 10,20,30,40,");

            string input = Console.ReadLine().Trim();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Wrong format");
                continue;
            }

            string[] parsedInput = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            List<int> numbers = new List<int>();

            bool errorOccured = false;
            foreach (var item in parsedInput)
            {
                if (int.TryParse(item, out int number))
                {
                    numbers.Add(number);
                }
                else
                {
                    errorOccured = true;
                    break;
                }
            }

            if (errorOccured)
            {
                Console.WriteLine("error with given input!");
                continue;
            }

            Console.WriteLine(numbers.All(num => num != 3) || numbers.All(num => num != 5));
        }
    }

    public void Exercise119()
    {
        while (true)
        {
            Console.WriteLine("Write an int array with a comma between each number. i.e 10,20,30,40,");

            string input = Console.ReadLine().Trim();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Wrong format");
                continue;
            }

            string[] parsedInput = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            List<int> numbers = new List<int>();

            bool errorOccured = false;
            foreach (var item in parsedInput)
            {
                if (int.TryParse(item, out int number))
                {
                    numbers.Add(number);
                }
                else
                {
                    errorOccured = true;
                    break;
                }
            }

            if (errorOccured)
            {
                Console.WriteLine("error with given input!");
                continue;
            }

            var numberThreeIndices = Enumerable.Range(0, numbers.Count).Where(i => numbers[i] == 3).ToList();
            var numberFiveIndices = Enumerable.Range(0, numbers.Count).Where(i => numbers[i] == 5).ToList();

            bool result = false;
            for (int index = 0; index < numberThreeIndices.Count - 1; index++)
            {
                if (numberThreeIndices[index + 1] - numberThreeIndices[index] == 1)
                {
                    result = true;
                    break;
                }
            }

            for (int index = 0; index < numberFiveIndices.Count - 1; index++)
            {
                if (numberFiveIndices[index + 1] - numberFiveIndices[index] == 1)
                {
                    result = true;
                    break;
                }
            }

            Console.WriteLine(result);
        }
    }

    public void Exercise12()
    {
        const string strToCompare = "C#";
        while (true)
        {
            Console.WriteLine("Enter a string. Enter -1 to quit!");

            string input = Console.ReadLine();

            if (input.Equals("-1"))
            {
                Console.WriteLine("Quitting...");
                break;
            }

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Input is not valid");
                continue;
            }

            Console.WriteLine(input.StartsWith(strToCompare));
        }
    }

    public void Exercise120()
    {
        while (true)
        {
            Console.WriteLine("Write an int array with a comma between each number. i.e 10,20,30,40,");

            string input = Console.ReadLine().Trim();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Wrong format");
                continue;
            }

            string[] parsedInput = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            List<int> numbers = new List<int>();

            bool errorOccured = false;
            foreach (var item in parsedInput)
            {
                if (int.TryParse(item, out int number))
                {
                    numbers.Add(number);
                }
                else
                {
                    errorOccured = true;
                    break;
                }
            }

            if (errorOccured)
            {
                Console.WriteLine("error with given input!");
                continue;
            }

            var numberFiveIndices = Enumerable.Range(0, numbers.Count).Where(i => numbers[i] == 5).ToList();

            bool result = false;

            for (int index = 0; index < numberFiveIndices.Count - 1; index++)
            {
                if (numberFiveIndices[index + 1] - numberFiveIndices[index] == 1 ||
                    numberFiveIndices[index + 1] - numberFiveIndices[index] == 2)
                {
                    result = true;
                    break;
                }
            }

            Console.WriteLine(result);
        }
    }

    public void Exercise121()
    {
        while (true)
        {
            Console.WriteLine("Write an int array with a comma between each number. i.e 10,20,30,40,");

            string input = Console.ReadLine().Trim();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Wrong format");
                continue;
            }

            string[] parsedInput = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            List<int> numbers = new List<int>();

            bool errorOccured = false;
            foreach (var item in parsedInput)
            {
                if (int.TryParse(item, out int number))
                {
                    numbers.Add(number);
                }
                else
                {
                    errorOccured = true;
                    break;
                }
            }

            if (errorOccured)
            {
                Console.WriteLine("error with given input!");
                continue;
            }

            int indexOf3 = numbers.FindIndex(num => num == 3);
            int indexOf5 = numbers.LastIndexOf(5);

            Console.WriteLine(indexOf3 != -1 && indexOf5 != -1
                && indexOf5 > indexOf3);
        }
    }

    public void Exercise122()
    {
        while (true)
        {
            Console.WriteLine("Write an int array with a comma between each number. i.e 10,20,30,40,");

            string input = Console.ReadLine().Trim();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Wrong format");
                continue;
            }

            string[] parsedInput = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            List<int> numbers = new List<int>();

            bool errorOccured = false;
            foreach (var item in parsedInput)
            {
                if (int.TryParse(item, out int number))
                {
                    numbers.Add(number);
                }
                else
                {
                    errorOccured = true;
                    break;
                }
            }

            if (errorOccured)
            {
                Console.WriteLine("error with given input!");
                continue;
            }

            bool success = false;
            for (int index = 0; index < numbers.Count - 1; index++)
            {
                if ((numbers[index] % 2 == 0 && numbers[index + 1] % 2 == 0) ||
                    (numbers[index] % 2 == 1 && numbers[index + 1] % 2 == 1))
                {
                    success = true;
                    break;
                }
            }

            Console.WriteLine(success);

        }
    }

    public void Exercise123()
    {
        while (true)
        {
            Console.WriteLine("Write an int array with a comma between each number. i.e 10,20,30,40,");

            string input = Console.ReadLine().Trim();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Wrong format");
                continue;
            }

            string[] parsedInput = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            List<int> numbers = new List<int>();

            bool errorOccured = false;
            foreach (var item in parsedInput)
            {
                if (int.TryParse(item, out int number))
                {
                    numbers.Add(number);
                }
                else
                {
                    errorOccured = true;
                    break;
                }
            }

            if (errorOccured)
            {
                Console.WriteLine("error with given input!");
                continue;
            }

            bool success = true;
            for (int index = 0; index < numbers.Count - 1; index++)
            {
                if (numbers[index] == 5 && numbers[index + 1] == 5)
                {
                    success = false;
                    break;
                }
            }

            Console.WriteLine(success && numbers.Count(num => num == 5) == 5);
        }
    }

    public void Exercise124()
    {
        while (true)
        {
            Console.WriteLine("Write an int array with a comma between each number. i.e 10,20,30,40,");

            string input = Console.ReadLine().Trim();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Wrong format");
                continue;
            }

            string[] parsedInput = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            List<int> numbers = new List<int>();

            bool errorOccured = false;
            foreach (var item in parsedInput)
            {
                if (int.TryParse(item, out int number))
                {
                    numbers.Add(number);
                }
                else
                {
                    errorOccured = true;
                    break;
                }
            }

            if (errorOccured)
            {
                Console.WriteLine("error with given input!");
                continue;
            }

            bool success = true;
            for (int index = 0; index < numbers.Count; index++)
            {
                if (numbers[index] == 5)
                {
                    if (index == 0)
                    {
                        if (numbers[index + 1] != 5)
                        {
                            success = false;
                            break;
                        }
                    }
                    else if (index == numbers.Count - 1)
                    {
                        if (numbers[index - 1] != 5)
                        {
                            success = false;
                            break;
                        }
                    }
                    else
                    {
                        if (numbers[index + 1] != 5 && numbers[index - 1] != 5)
                        {
                            success = false;
                            break;
                        }
                    }
                }
            }

            Console.WriteLine(success);
        }
    }

    public void Exercise125()
    {
        while (true)
        {
            Console.WriteLine("Write one int array and a number with a comma between each number and between array and number. " +
                "i.e { 10, 20, 40, 50 }, 2");

            string input = Console.ReadLine().Trim();
            input = Regex.Replace(input, " ", "");

            if (string.IsNullOrWhiteSpace(input) || input.Count(chr => chr == '{') != 1 || input.Count(chr => chr == '}') != 1)
            {
                Console.WriteLine("Wrong format");
                continue;
            }

            string inputArray = input.Trim().Substring(1, input.Trim().IndexOf('}') - 1);
            string lastChar = input.Trim().Substring(input.Trim().LastIndexOf(',') + 1);

            string[] parsedInput = inputArray.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            List<int> numbers = new List<int>();

            bool errorOccured = false;
            foreach (var item in parsedInput)
            {
                if (int.TryParse(item, out int number))
                {
                    numbers.Add(number);
                }
                else
                {
                    errorOccured = true;
                    break;
                }
            }

            bool isLastCharAnInt = int.TryParse(lastChar, out int lastCharInt);

            if (errorOccured || !isLastCharAnInt)
            {
                Console.WriteLine("error with given input!");
                continue;
            }

            Console.WriteLine(numbers.Count(num => num == numbers.First()) == lastCharInt && numbers.Count(num => num == numbers.Last()) == lastCharInt);
        }
    }

    public void Exercise126()
    {
        while (true)
        {
            Console.WriteLine("Write an int array with a comma between each number. i.e 10,20,30,40,");

            string input = Console.ReadLine().Trim();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Wrong format");
                continue;
            }

            string[] parsedInput = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            List<int> numbers = new List<int>();

            bool errorOccured = false;
            foreach (var item in parsedInput)
            {
                if (int.TryParse(item, out int number))
                {
                    numbers.Add(number);
                }
                else
                {
                    errorOccured = true;
                    break;
                }
            }

            if (errorOccured || numbers.Count() < 3)
            {
                Console.WriteLine("error with given input!");
                continue;
            }

            bool success = false;

            for (int i = 0; i < numbers.Count() - 2; i++)
            {
                if (numbers[i] < numbers[i + 1] && numbers[i + 1] < numbers[i + 2])
                {
                    success = true;
                    break;
                }
            }

            Console.WriteLine(success);
        }
    }

    public void Exercise127()
    {
        while (true)
        {
            Console.WriteLine("Write an int array with a comma between each number. i.e 10,20,30,40,");

            string input = Console.ReadLine().Trim();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Wrong format");
                continue;
            }

            string[] parsedInput = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            List<int> numbers = new List<int>();

            bool errorOccured = false;
            foreach (var item in parsedInput)
            {
                if (int.TryParse(item, out int number))
                {
                    numbers.Add(number);
                }
                else
                {
                    errorOccured = true;
                    break;
                }
            }

            if (errorOccured)
            {
                Console.WriteLine("error with given input!");
                continue;
            }

            int numOfShifts = 1;
            int[] resultArr = new int[numbers.Count()];

            for (int i = 0; i < numbers.Count(); i++)
            {
                int newIndex = (i - numOfShifts + numbers.Count()) % numbers.Count();
                resultArr[newIndex] = numbers[i];
            }

            Console.WriteLine(string.Join(",", resultArr));
        }
    }

    public void Exercise128()
    {
        while (true)
        {
            Console.WriteLine("Write an int array with a comma between each number. i.e 10,20,30,40,");

            string input = Console.ReadLine().Trim();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Wrong format");
                continue;
            }

            string[] parsedInput = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            List<int> numbers = new List<int>();

            bool errorOccured = false;
            foreach (var item in parsedInput)
            {
                if (int.TryParse(item, out int number))
                {
                    numbers.Add(number);
                }
                else
                {
                    errorOccured = true;
                    break;
                }
            }

            if (errorOccured)
            {
                Console.WriteLine("error with given input!");
                continue;
            }

            int indexOfFive = numbers.IndexOf(5);

            if (indexOfFive != -1)
            {
                Console.WriteLine(string.Join(",", numbers.Take(indexOfFive)));
            }
            else
            {
                Console.WriteLine(string.Join(",", numbers));
            }
        }
    }

    public void Exercise129()
    {
        while (true)
        {
            Console.WriteLine("Write an int array with a comma between each number. i.e 10,20,30,40,");

            string input = Console.ReadLine().Trim();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Wrong format");
                continue;
            }

            string[] parsedInput = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            List<int> numbers = new List<int>();

            bool errorOccured = false;
            foreach (var item in parsedInput)
            {
                if (int.TryParse(item, out int number))
                {
                    numbers.Add(number);
                }
                else
                {
                    errorOccured = true;
                    break;
                }
            }

            if (errorOccured)
            {
                Console.WriteLine("error with given input!");
                continue;
            }

            int indexOfFive = numbers.IndexOf(5);

            if (indexOfFive != -1)
            {
                Console.WriteLine(string.Join(",", numbers.GetRange(indexOfFive + 1, numbers.Count() - indexOfFive - 1)));
            }
            else
            {
                Console.WriteLine(" ");
            }
        }
    }

    public void Exercise13()
    {
        while (true)
        {
            // Get two numbers from  user
            Console.WriteLine("Enter two numbers with a comma in between and q to quit!");
            string input = Console.ReadLine();

            if (input == "q")
            {
                Console.WriteLine("quitting");
                return;
            }

            // Parse input string
            List<string> parsedInput = input.Split(new char[] { ',' },
                StringSplitOptions.RemoveEmptyEntries).ToList();

            if (parsedInput.Count != 2)
            {
                Console.WriteLine("Error with the given input!");
                continue;
            }

            // Delete spaces
            parsedInput.ForEach((numberInString) => numberInString = numberInString.Replace(" ", ""));

            if (int.TryParse(parsedInput[0], out int number1) &&
                int.TryParse(parsedInput[1], out int number2))
            {
                Console.WriteLine(number1 < 0 && number2 > 100);
            }

            else
            {
                Console.WriteLine("Error with the given input!");
            }
        }
    }

    public void Exercise130()
    {
        while (true)
        {
            Console.WriteLine("Write an int array with a comma between each number. i.e 10,20,30,40,");

            string input = Console.ReadLine().Trim();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Wrong format");
                continue;
            }

            string[] parsedInput = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            List<int> numbers = new List<int>();

            bool errorOccured = false;
            foreach (var item in parsedInput)
            {
                if (int.TryParse(item, out int number))
                {
                    numbers.Add(number);
                }
                else
                {
                    errorOccured = true;
                    break;
                }
            }

            if (errorOccured)
            {
                Console.WriteLine("error with given input!");
                continue;
            }

            var indicesOfZero = Enumerable.Range(0, numbers.Count()).Where(i => numbers[i] == 0).ToList();

            if (indicesOfZero.Count() != 0)
            {
                for (int i = 0; i < indicesOfZero.Count(); i++)
                {
                    int temp = numbers[i];
                    numbers[i] = 0;
                    numbers[indicesOfZero[i]] = temp;
                }
            }

            Console.WriteLine(string.Join(",", numbers));
        }
    }

    public void Exercise131()
    {
        while (true)
        {
            Console.WriteLine("Write an int array with a comma between each number. i.e 10,20,30,40,");

            string input = Console.ReadLine().Trim();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Wrong format");
                continue;
            }

            string[] parsedInput = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            List<int> numbers = new List<int>();

            bool errorOccured = false;
            foreach (var item in parsedInput)
            {
                if (int.TryParse(item, out int number))
                {
                    numbers.Add(number);
                }
                else
                {
                    errorOccured = true;
                    break;
                }
            }

            if (errorOccured)
            {
                Console.WriteLine("error with given input!");
                continue;
            }


            List<int> resultList = new List<int>();

            foreach (var num in numbers)
            {
                if (num != 5)
                {
                    resultList.Add(num);
                }
            }

            int numOfZeros = numbers.Count() - resultList.Count();

            resultList.AddRange(Enumerable.Repeat(0, numOfZeros).ToList());

            Console.WriteLine(string.Join(",", resultList));
        }
    }

    public void Exercise132()
    {
        while (true)
        {
            Console.WriteLine("Write an int array with a comma between each number. i.e 10,20,30,40,");

            string input = Console.ReadLine().Trim();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Wrong format");
                continue;
            }

            string[] parsedInput = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            List<int> numbers = new List<int>();

            bool errorOccured = false;
            foreach (var item in parsedInput)
            {
                if (int.TryParse(item, out int number))
                {
                    numbers.Add(number);
                }
                else
                {
                    errorOccured = true;
                    break;
                }
            }

            if (errorOccured)
            {
                Console.WriteLine("error with given input!");
                continue;
            }
            int count = numbers.Count();
            for (int i = 0; i < count; i++)
            {
                if (numbers[i] % 2 == 1)
                {
                    int temp = numbers[i];
                    numbers.RemoveAt(i);
                    numbers.Add(temp);
                    i--;
                    count--;
                }
            }

            Console.WriteLine(string.Join(",", numbers));
        }
    }

    public void Exercise133()
    {
        while (true)
        {
            Console.WriteLine("Write an int array with a comma between each number. i.e 10,20,30,40,");

            string input = Console.ReadLine().Trim();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Wrong format");
                continue;
            }

            string[] parsedInput = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            List<int> numbers = new List<int>();

            bool errorOccured = false;
            foreach (var item in parsedInput)
            {
                if (int.TryParse(item, out int number))
                {
                    numbers.Add(number);
                }
                else
                {
                    errorOccured = true;
                    break;
                }
            }

            if (errorOccured)
            {
                Console.WriteLine("error with given input!");
                continue;
            }

            bool success = true;

            for (int i = 0; i < numbers.Count() - 1; i++)
            {
                if (numbers[i] > numbers[i + 1])
                {
                    success = false;
                    break;
                }
            }
            Console.WriteLine(success);
        }
    }

    public void Exercise134()
    {
        while (true)
        {
            Console.WriteLine("Write an int array with a comma between each number. i.e 10,20,30,40,");

            string input = Console.ReadLine().Trim();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Wrong format");
                continue;
            }

            string[] parsedInput = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            List<int> numbers = new List<int>();

            bool errorOccured = false;
            foreach (var item in parsedInput)
            {
                if (int.TryParse(item, out int number))
                {
                    numbers.Add(number);
                }
                else
                {
                    errorOccured = true;
                    break;
                }
            }

            if (errorOccured)
            {
                Console.WriteLine("error with given input!");
                continue;
            }

            bool success = false;

            for (int i = 0; i < numbers.Count() - 1; i++)
            {
                if (numbers[i] == 15 && numbers[i + 1] == 15)
                {
                    success = true;
                    break;
                }
            }
            Console.WriteLine(success);
        }
    }

    public void Exercise135()
    {
        while (true)
        {
            Console.WriteLine("Write an int array with a comma between each number. i.e 10,20,30,40,");

            string input = Console.ReadLine().Trim();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Wrong format");
                continue;
            }

            string[] parsedInput = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            List<int> numbers = new List<int>();

            bool errorOccured = false;
            foreach (var item in parsedInput)
            {
                if (int.TryParse(item, out int number))
                {
                    numbers.Add(number);
                }
                else
                {
                    errorOccured = true;
                    break;
                }
            }

            if (errorOccured)
            {
                Console.WriteLine("error with given input!");
                continue;
            }

            var firstHalf = numbers.GetRange(0, numbers.Count() / 2);
            var secondHalf = numbers.GetRange(numbers.Count() / 2, numbers.Count() - numbers.Count() / 2);

            Console.WriteLine((new int[] { (int)firstHalf.Average(), (int)secondHalf.Average() }).Max());

        }
    }

    public void Exercise136()
    {
        while (true)
        {
            Console.WriteLine("Write an array of string with a comma between each number and an int. i.e {'a', 'b', 'bb'}, 1");

            string input = Console.ReadLine().Trim();
            input = Regex.Replace(input, " ", "");
            input = Regex.Replace(input, "\"", "");

            if (string.IsNullOrWhiteSpace(input) || input.Count(chr => chr == '{') != 1 || input.Count(chr => chr == '}') != 1)
            {
                Console.WriteLine("Wrong format");
                continue;
            }

            string inputArray = input.Trim().Substring(1, input.Trim().IndexOf('}') - 1);
            string lastChar = input.Trim().Substring(input.Trim().LastIndexOf(',') + 1);

            string[] parsedInput = inputArray.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            bool success = int.TryParse(lastChar, out int numOfChars);
            if (!success || parsedInput.Count() == 0)
            {
                Console.WriteLine("error with given input!");
                continue;
            }

            Console.WriteLine(parsedInput.Count(str => str.Count() == numOfChars));
        }
    }

    public void Exercise137()
    {
        while (true)
        {
            Console.WriteLine("Write an array of string with a comma between each number and an int. i.e {'a', 'b', 'bb'}, 1");

            string input = Console.ReadLine().Trim();
            input = Regex.Replace(input, " ", "");
            input = Regex.Replace(input, "\"", "");

            if (string.IsNullOrWhiteSpace(input) || input.Count(chr => chr == '{') != 1 || input.Count(chr => chr == '}') != 1)
            {
                Console.WriteLine("Wrong format");
                continue;
            }

            string inputArray = input.Trim().Substring(1, input.Trim().IndexOf('}') - 1);
            string lastChar = input.Trim().Substring(input.Trim().LastIndexOf(',') + 1);

            string[] parsedInput = inputArray.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            bool success = int.TryParse(lastChar, out int numOfStrs);
            if (!success || parsedInput.Count() == 0)
            {
                Console.WriteLine("error with given input!");
                continue;
            }

            Console.WriteLine(string.Join(" ", parsedInput.Take(numOfStrs).ToList()));
        }
    }

    public void Exercise138()
    {
        while (true)
        {
            Console.WriteLine("Write an array of string with a comma between each number and an int. i.e {'a', 'b', 'bb'}, 1");

            string input = Console.ReadLine().Trim();
            input = Regex.Replace(input, " ", "");
            input = Regex.Replace(input, "\"", "");

            if (string.IsNullOrWhiteSpace(input) || input.Count(chr => chr == '{') != 1 || input.Count(chr => chr == '}') != 1)
            {
                Console.WriteLine("Wrong format");
                continue;
            }

            string inputArray = input.Trim().Substring(1, input.Trim().IndexOf('}') - 1);
            string lastChar = input.Trim().Substring(input.Trim().LastIndexOf(',') + 1);

            string[] parsedInput = inputArray.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            bool success = int.TryParse(lastChar, out int numOfStrs);
            if (!success || parsedInput.Count() == 0)
            {
                Console.WriteLine("error with given input!");
                continue;
            }

            Console.WriteLine(string.Join(" ", parsedInput.Where(str => str.Count() == numOfStrs)));
        }
    }

    public void Exercise139()
    {
        while (true)
        {
            Console.WriteLine("Enter an int. i.e. 1");

            string input = Console.ReadLine().Trim();
            bool success = int.TryParse(input, out _);

            if (!success)
            {
                Console.WriteLine("error with given input!");
                continue;
            }

            Console.WriteLine(input.Contains('2'));
        }
    }

    public void Exercise14()
    {
        while (true)
        {
            // Get two numbers from  user
            Console.WriteLine("Enter two numbers with a comma in between and q to quit!");
            string input = Console.ReadLine();

            if (input == "q")
            {
                Console.WriteLine("quitting");
                return;
            }

            // Parse input string
            List<string> parsedInput = input.Split(new char[] { ',' },
                StringSplitOptions.RemoveEmptyEntries).ToList();

            if (parsedInput.Count != 2)
            {
                Console.WriteLine("Error with the given input!");
                continue;
            }

            // Delete spaces
            parsedInput.ForEach((numberInString) => numberInString = numberInString.Replace(" ", ""));

            if (int.TryParse(parsedInput[0], out int number1) &&
                int.TryParse(parsedInput[1], out int number2))
            {
                Console.WriteLine((number1 >= 0 && number1 <= 100) ||
                    (number2 >= 0 && number2 <= 100));
            }

            else
            {
                Console.WriteLine("Error with the given input!");
            }
        }
    }

    public void Exercise140()
    {
        while (true)
        {
            Console.WriteLine("Write one int array and a number with a comma between each number and between array and number. " +
                "i.e { 10, 20, 40, 50 }, 2");

            string input = Console.ReadLine().Trim();
            input = Regex.Replace(input, " ", "");

            if (string.IsNullOrWhiteSpace(input) || input.Count(chr => chr == '{') != 1 || input.Count(chr => chr == '}') != 1)
            {
                Console.WriteLine("Wrong format");
                continue;
            }

            string inputArray = input.Trim().Substring(1, input.Trim().IndexOf('}') - 1);
            string lastChar = input.Trim().Substring(input.Trim().LastIndexOf(',') + 1);

            string[] parsedInput = inputArray.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            List<int> numbers = new List<int>();

            bool errorOccured = false;
            foreach (var item in parsedInput)
            {
                if (int.TryParse(item, out int number))
                {
                    numbers.Add(number);
                }
                else
                {
                    errorOccured = true;
                    break;
                }
            }

            bool isLastCharAnInt = int.TryParse(lastChar, out int lastCharInt);

            if (errorOccured || !isLastCharAnInt)
            {
                Console.WriteLine("error with given input!");
                continue;
            }

            var oddNumbers = numbers.Where(num => num % 2 == 1).ToList();

            Console.WriteLine(string.Join(" ", oddNumbers.Take(lastCharInt)));
        }
    }

    public void Exercise141()
    {
        while (true)
        {
            Console.WriteLine("Write an int array with a comma between each number. i.e 10,20,30,40,");

            string input = Console.ReadLine().Trim();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Wrong format");
                continue;
            }

            string[] parsedInput = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            List<int> numbers = new List<int>();

            bool errorOccured = false;
            foreach (var item in parsedInput)
            {
                if (int.TryParse(item, out int number))
                {
                    numbers.Add(number);
                }
                else
                {
                    errorOccured = true;
                    break;
                }
            }

            if (errorOccured)
            {
                Console.WriteLine("error with given input!");
                continue;
            }

            List<int> resultList = numbers.Select(num => num * 3).ToList();

            Console.WriteLine(string.Join(" ", resultList));
        }
    }

    public void Exercise142()
    {
        while (true)
        {
            Console.WriteLine("Write an int array with a comma between each number. i.e 10,20,30,40,");

            string input = Console.ReadLine().Trim();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Wrong format");
                continue;
            }

            string[] parsedInput = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            List<int> numbers = new List<int>();

            bool errorOccured = false;
            foreach (var item in parsedInput)
            {
                if (int.TryParse(item, out int number))
                {
                    numbers.Add(number);
                }
                else
                {
                    errorOccured = true;
                    break;
                }
            }

            if (errorOccured)
            {
                Console.WriteLine("error with given input!");
                continue;
            }

            List<int> resultList = numbers.Select(num => (int)Math.Pow(num, 3)).ToList();

            Console.WriteLine(string.Join(" ", resultList));
        }
    }

    public void Exercise143()
    {
        while (true)
        {
            Console.WriteLine("Write a string array with a comma between each string. i.e \"1\", \"2\", \"3\", \"4\"");

            string input = Console.ReadLine().Trim();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Wrong format");
                continue;
            }
            input = Regex.Replace(input, "\"", "");
            string[] parsedInput = input.Trim().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            if (parsedInput.Count() == 0)
            {
                Console.WriteLine("error with given input!");
                continue;
            }

            var trimParsedInput = parsedInput.Select(str => str = str.Trim()).ToArray();
            var resultArr = trimParsedInput.Select(str => str.Insert(0, "#").Insert(str.Length + 1, "#")).ToList();

            Console.WriteLine(string.Join(" ", resultArr));
        }
    }

    public void Exercise144()
    {
        while (true)
        {
            Console.WriteLine("Write a string array with a comma between each string. i.e \"1\", \"2\", \"3\", \"4\"");

            string input = Console.ReadLine().Trim();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Wrong format");
                continue;
            }
            input = Regex.Replace(input, "\"", "");
            string[] parsedInput = input.Trim().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            if (parsedInput.Count() == 0)
            {
                Console.WriteLine("error with given input!");
                continue;
            }
            var resultArr = parsedInput.Select(str => new string(str.Trim()[0], 4)).ToList();

            Console.WriteLine(string.Join(" ", resultArr));
        }
    }

    public void Exercise145()
    {
        while (true)
        {
            Console.WriteLine("Write an int array with a comma between each number. i.e 10,20,30,40,");

            string input = Console.ReadLine().Trim();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Wrong format");
                continue;
            }

            string[] parsedInput = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            List<int> numbers = new List<int>();

            bool errorOccured = false;
            foreach (var item in parsedInput)
            {
                if (int.TryParse(item, out int number))
                {
                    numbers.Add(number);
                }
                else
                {
                    errorOccured = true;
                    break;
                }
            }

            if (errorOccured)
            {
                Console.WriteLine("error with given input!");
                continue;
            }

            List<int> resultList = numbers.Select(num => 5 * (num + 2)).ToList();

            Console.WriteLine(string.Join(" ", resultList));
        }
    }

    public void Exercise146()
    {
        while (true)
        {
            Console.WriteLine("Write an int array with a comma between each number. i.e 10,20,30,40,");

            string input = Console.ReadLine().Trim();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Wrong format");
                continue;
            }

            List<string> parsedInput = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            parsedInput = parsedInput.Select(str => str.Trim()).ToList();


            bool errorOccured = false;
            foreach (var item in parsedInput)
            {
                if (!int.TryParse(item, out int number))
                {
                    errorOccured = true;
                    break;
                }
            }

            if (errorOccured)
            {
                Console.WriteLine("error with given input!");
                continue;
            }

            Console.WriteLine(string.Join(" ", parsedInput.Select(str => str[str.Length - 1]).ToList()));
        }
    }

    public void Exercise147()
    {
        while (true)
        {
            Console.WriteLine("Write a string array with a comma between each string. i.e \"Abc\", \"cdef\", \"js\"");

            string input = Console.ReadLine().Trim();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Wrong format");
                continue;
            }
            input = Regex.Replace(input, "\"", "");
            string[] parsedInput = input.Trim().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            if (parsedInput.Count() == 0)
            {
                Console.WriteLine("error with given input!");
                continue;
            }

            Console.WriteLine(string.Join(" ", parsedInput.Select(str => str.ToUpper())));
        }
    }

    public void Exercise148()
    {
        while (true)
        {
            Console.WriteLine("Write a string array with a comma between each string. i.e \"Abc\", \"cdef\", \"js\"");

            string input = Console.ReadLine().Trim();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Wrong format");
                continue;
            }
            input = Regex.Replace(input, "\"", "");
            string[] parsedInput = input.Trim().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            if (parsedInput.Count() == 0)
            {
                Console.WriteLine("error with given input!");
                continue;
            }

            Console.WriteLine(string.Join(" ", parsedInput.Select(str => str.Replace("a", ""))));
        }
    }

    public void Exercise149()
    {
        while (true)
        {
            Console.WriteLine("Write an int array with a comma between each number. i.e 10,20,30,40,");

            string input = Console.ReadLine().Trim();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Wrong format");
                continue;
            }

            string[] parsedInput = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            List<int> numbers = new List<int>();

            bool errorOccured = false;
            foreach (var item in parsedInput)
            {
                if (int.TryParse(item, out int number))
                {
                    numbers.Add(number);
                }
                else
                {
                    errorOccured = true;
                    break;
                }
            }

            if (errorOccured)
            {
                Console.WriteLine("error with given input!");
                continue;
            }

            Console.WriteLine(string.Join(" ", numbers.Where(num => num < 4)));
        }
    }

    public void Exercise15()
    {
        while (true)
        {
            // Get two numbers from  user
            Console.WriteLine("Enter three numbers with a comma in between and q to quit!");
            string input = Console.ReadLine();

            if (input == "q")
            {
                Console.WriteLine("quitting");
                return;
            }

            // Parse input string
            List<string> parsedInput = input.Split(new char[] { ',' },
                StringSplitOptions.RemoveEmptyEntries).ToList();

            if (parsedInput.Count != 3)
            {
                Console.WriteLine("Error with the given input!");
                continue;
            }

            // Delete spaces
            parsedInput.ForEach((numberInString) => numberInString = numberInString.Replace(" ", ""));

            List<int> inputNumbers = new List<int>();

            bool errorOccured = false;

            foreach (var numberInString in parsedInput)
            {
                if (!int.TryParse(numberInString, out int numberInInt))
                {
                    Console.WriteLine("Error with the given input!");
                    errorOccured = true;
                    break;
                }

                inputNumbers.Add(numberInInt);
            }

            if (errorOccured)
            {
                continue;
            }


            Console.WriteLine(inputNumbers.Any((number) =>
            {
                return number >= 20 && number <= 50;
            }
            ));
        }
    }

    public void Exercise150()
    {
        while (true)
        {
            Console.WriteLine("Write an int array with a comma between each number. i.e 10,20,30,40,");

            string input = Console.ReadLine().Trim();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Wrong format");
                continue;
            }

            string[] parsedInput = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            List<int> numbers = new List<int>();

            bool errorOccured = false;
            foreach (var item in parsedInput)
            {
                if (int.TryParse(item, out int number))
                {
                    numbers.Add(number);
                }
                else
                {
                    errorOccured = true;
                    break;
                }
            }

            if (errorOccured)
            {
                Console.WriteLine("error with given input!");
                continue;
            }

            List<string> inputStrList = numbers.Select(num => num.ToString()).ToList();

            Console.WriteLine(string.Join(" ", inputStrList.Where(str => str[str.Length - 1] != '7')));
        }
    }

    public void Exercise16()
    {
        const int numberOfInputs = 2;

        while (true)
        {
            int[] inputs = new int[numberOfInputs];

            bool inputsAreCorrect = AliihsanHelperClass.GetIntInputsWithCommaBetween(ref inputs, out bool quit);

            if (quit)
            {
                Console.WriteLine("Quitting...");
                break;
            }

            if (!inputsAreCorrect)
            {
                Console.WriteLine("Error with the given input!");
                continue;
            }

            Console.WriteLine((inputs[0] >= 20 && inputs[0] <= 50) || (inputs[1] >= 20 && inputs[1] <= 50));
        }
    }
    public void Exercise17()
    {
        while (true)
        {
            Console.WriteLine("Enter a string");

            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Wrong format!");
                continue;
            }

            if (input.IndexOf("yt") == 1)
            {
                input = input.Remove(1, 2);
            }
            Console.WriteLine(input);
        }

    }
    public void Exercise18()
    {
        const int numOfInputs = 3;
        while (true)
        {
            int[] inputs = new int[numOfInputs];

            bool areInputsCorrect = AliihsanHelperClass.GetIntInputsWithCommaBetween(ref inputs, out bool quit);

            if (quit)
            {
                Console.WriteLine("Quitting");
                break;
            }

            if (!areInputsCorrect)
            {
                Console.WriteLine("Wrong Format!");
                continue;
            }

            int largestNum = inputs[0];

            for (int i = 1; i < numOfInputs; i++)
            {
                if (inputs[i] > largestNum)
                {
                    largestNum = inputs[i];
                }
            }

            Console.WriteLine(largestNum);
        }
    }

    public void Exercise19()
    {

        while (true)
        {
            int[] inputs = new int[2];

            bool areInputsCorrect = AliihsanHelperClass.GetIntInputsWithCommaBetween(ref inputs, out bool quit);

            if (quit)
            {
                Console.WriteLine("quitting");
                break;
            }

            if (!areInputsCorrect)
            {
                Console.WriteLine("Input format is not correct!");
                continue;
            }

            if (inputs[0] == inputs[1])
            {
                Console.WriteLine(0);
            }

            else
            {
                int result = (Math.Abs(100 - inputs[0]) > Math.Abs(100 - inputs[1])) ? inputs[1] : inputs[0];

                Console.WriteLine(result);
            }
        }
    }

    public void Exercise2()
    {
        const int numToCompare = 51;
        while (true)
        {
            // Get two numbers from  user
            Console.WriteLine("Enter  a number, press key 'a' to quit");
            string input = Console.ReadLine();

            // Check if user wants to quit
            if (input.ToLower() == "a")
            {
                return;
            }

            bool parseResult = int.TryParse(input, out int inputInInt);

            if (!parseResult)
            {
                Console.WriteLine("Error with input!");
                continue;
            }

            if (inputInInt > numToCompare)
            {

                Console.WriteLine(Math.Abs(inputInInt - numToCompare) * 3);
            }
            else
            {
                Console.WriteLine(Math.Abs(inputInInt - numToCompare));
            }
        }
    }

    public void Exercise20()
    {
        while (true)
        {
            int[] inputs = new int[2];

            bool areInputsCorrect = AliihsanHelperClass.GetIntInputsWithCommaBetween(ref inputs, out bool quit);

            if (quit)
            {
                Console.WriteLine("quitting");
                break;
            }

            if (!areInputsCorrect)
            {
                Console.WriteLine("Input format is not correct!");
                continue;
            }

            Console.WriteLine(((inputs[0] >= 40 && inputs[0] <= 50) && (inputs[1] >= 40 && inputs[1] <= 50))
                || ((inputs[0] >= 50 && inputs[0] <= 60) && (inputs[1] >= 50 && inputs[1] <= 60)));
        }
    }

    public void Exercise21()
    {
        while (true)
        {
            int[] inputs = new int[2];

            bool areInputsCorrect = AliihsanHelperClass.GetIntInputsWithCommaBetween(ref inputs, out bool quit);

            if (quit)
            {
                Console.WriteLine("quitting");
                break;
            }

            if (!areInputsCorrect)
            {
                Console.WriteLine("Input format is not correct!");
                continue;
            }

            bool IsInRange(int num)
            {
                return (num >= 20 && num <= 30);
            }

            if (!IsInRange(inputs[0]) && !IsInRange(inputs[1]))
            {
                Console.WriteLine(0);
            }
            else if (IsInRange(inputs[0]) && !IsInRange(inputs[1]))
            {
                Console.WriteLine(inputs[0]);
            }
            else if (!IsInRange(inputs[0]) && IsInRange(inputs[1]))
            {
                Console.WriteLine(inputs[1]);
            }
            else
            {
                Console.WriteLine(inputs[0] > inputs[1] ? inputs[0] : inputs[1]);
            }
        }
    }

    public void Exercise22()
    {
        while (true)
        {
            Console.WriteLine("String gir amk");
            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Input format is not correct!");
                continue;
            }

            int numOfZ = input.Count((c) => c == 'z');

            Console.WriteLine(numOfZ >= 2 && numOfZ <= 4);
        }
    }

    public void Exercise23()
    {
        while (true)
        {
            int[] inputs = new int[2];

            bool areInputsCorrect = AliihsanHelperClass.GetIntInputsWithCommaBetween(ref inputs, out bool quit);

            if (quit)
            {
                Console.WriteLine("quitting");
                break;
            }

            if (!areInputsCorrect)
            {
                Console.WriteLine("Input format is not correct!");
                continue;
            }

            Console.WriteLine(inputs[0].ToString().Last() == inputs[1].ToString().Last());
        }
    }

    public void Exercise24()
    {
        while (true)
        {
            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("amk");
                continue;
            }

            var startIndex = Math.Max(0, input.Length - 3);
            var endingIndex = input.Length - 1;

            string upperCase3Digits = input.Substring(startIndex, endingIndex - startIndex + 1).ToUpper();
            input = input.Remove(startIndex, endingIndex - startIndex + 1);

            Console.WriteLine(input + upperCase3Digits);
        }
    }

    public void Exercise25()
    {
        while (true)
        {
            string input = Console.ReadLine();

            var inputs = input.Split(new char[] { ',' });

            if (inputs.Length != 2 || !int.TryParse(inputs[1], out int numOfRepeat) || numOfRepeat < 0)
            {
                Console.WriteLine("Wrong Format!");
                continue;
            }

            Console.WriteLine(string.Concat(Enumerable.Repeat(inputs[0], numOfRepeat)));
        }
    }

    public void Exercise26()
    {
        while (true)
        {
            string input = Console.ReadLine();

            var inputs = input.Split(new char[] { ',' });

            if (inputs.Length != 2 || !int.TryParse(inputs[1], out int numOfRepeat))
            {
                Console.WriteLine("Wrong Format!");
                continue;
            }

            int startIndex = 0;
            int endIndex = Math.Min(3, inputs[0].Length);

            Console.WriteLine(string.Concat(Enumerable.Repeat(inputs[0].Substring(startIndex, endIndex - startIndex), numOfRepeat)));
        }
    }

    public void Exercise27()
    {
        const string pattern = "aa";
        while (true)
        {
            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Wrong input format!");
                continue;
            }

            int numOfOccurunces = 0;

            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input.Substring(i, 2).Equals(pattern))
                {
                    numOfOccurunces++;
                }
            }

            Console.WriteLine(numOfOccurunces);
        }

    }

    public void Exercise28()
    {
        while (true)
        {
            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Wrong input format!");
                continue;
            }

            Console.WriteLine((input.IndexOf("aa") == input.IndexOf('a')) && (input.IndexOf('a') != -1));
        }
    }

    public void Exercise29()
    {
        while (true)
        {
            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Wrong input format!");
                continue;
            }

            for (int i = 0; i < input.Length; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(input.ElementAt(i));
                }
            }
            Console.WriteLine();
        }
    }

    public void Exercise3()
    {
        while (true)
        {
            // Get two numbers from  user
            Console.WriteLine("Enter two numbers with a comma in between");
            string input = Console.ReadLine();

            // Parse input string
            List<string> parsedInput = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            if (parsedInput.Count != 2)
            {
                Console.WriteLine("Error at the given input!");
                continue;
            }

            // Delete spaces
            parsedInput.ForEach((numberInString) => numberInString = numberInString.Replace(" ", ""));

            // Convert inputs from string to int
            List<int> intInputs = new List<int>();

            bool errorOccured = false;
            foreach (var numberInString in parsedInput)
            {
                bool parsingResult = int.TryParse(numberInString, out int numberInInt);
                if (!parsingResult)
                {
                    Console.WriteLine("Error at the given input!");
                    errorOccured = true;
                    break;
                }
                intInputs.Add(numberInInt);
            }

            if (errorOccured)
            {
                continue;
            }


            if (intInputs[0] == 30 || intInputs[1] == 30 || intInputs.Sum() == 30)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
    }

    public void Exercise30()
    {
        while (true)
        {
            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Wrong input format!");
                continue;
            }

            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(input.Substring(0, i + 1));
            }
            Console.WriteLine();
        }
    }

    public void Exercise31()
    {
        while (true)
        {
            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Wrong input format!");
                continue;
            }

            if (input.Length <= 3)
            {
                Console.WriteLine(0);
                continue;
            }

            string lastTwoChars = input.Substring(input.Length - 2, 2);

            var matches = Regex.Matches(input, lastTwoChars);

            Console.WriteLine(matches.Count - 1);
        }
    }

    public void Exercise32()
    {
        while (true)
        {
            Console.WriteLine("Write input like {1,2,9,3}, 3");
            string input = Console.ReadLine();

            Stopwatch watch = Stopwatch.StartNew();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Wrong input format!");
                continue;
            }

            string[] parsedInput = input.Split(new char[] { '}' }, StringSplitOptions.RemoveEmptyEntries);

            if (parsedInput.Length != 2)
            {
                Console.WriteLine("Wrong input format!");
                continue;
            }

            string numToSearchInStr = parsedInput[1].Substring(1, parsedInput[1].Length - 1).Trim();

            if (!int.TryParse(numToSearchInStr, out int numberToSearchInInt))
            {
                Console.WriteLine("Wrong input format!");
                continue;
            }

            string numberSeriesInStr = parsedInput[0].Substring(1, parsedInput[0].Length - 1);
            string[] numberListInStr = numberSeriesInStr.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);


            List<int> numberListInInt = new List<int>();

            bool error = false;
            foreach (var numberInStr in numberListInStr)
            {
                if (!int.TryParse(numberInStr, out int numberInInt))
                {
                    error = true;
                    break;
                }
                numberListInInt.Add(numberInInt);
            }

            if (error)
            {
                Console.WriteLine("Wrong format!");
                continue;
            }

            Console.WriteLine(numberListInInt.Contains(numberToSearchInInt));
            watch.Stop();

            Console.WriteLine(watch.ElapsedTicks);
        }

    }

    public void Exercise33()
    {
        while (true)
        {
            Console.WriteLine("Write input like {1,2,9,3}, 3");
            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Wrong input format!");
                continue;
            }

            string[] parsedInput = input.Split(new char[] { '}' }, StringSplitOptions.RemoveEmptyEntries);

            if (parsedInput.Length != 2)
            {
                Console.WriteLine("Wrong input format!");
                continue;
            }

            string numToSearchInStr = parsedInput[1].Substring(1, parsedInput[1].Length - 1).Trim();

            if (!int.TryParse(numToSearchInStr, out int numberToSearchInInt))
            {
                Console.WriteLine("Wrong input format!");
                continue;
            }

            string numberSeriesInStr = parsedInput[0].Substring(1, parsedInput[0].Length - 1);
            string[] numberListInStr = numberSeriesInStr.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);


            List<int> numberListInInt = new List<int>();

            bool error = false;
            foreach (var numberInStr in numberListInStr)
            {
                if (!int.TryParse(numberInStr, out int numberInInt))
                {
                    error = true;
                    break;
                }
                numberListInInt.Add(numberInInt);
            }

            if (error)
            {
                Console.WriteLine("Wrong format!");
                continue;
            }

            int index = numberListInInt.FindIndex((num) => num == numberToSearchInInt);
            Console.WriteLine(index != -1 && index < 4);
        }
    }

    public void Exercise34()
    {
        while (true)
        {
            Console.WriteLine("Write input like {1,2,9,3}");
            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Wrong input format!");
                continue;
            }

            string[] parsedInput = input.Substring(1, input.Length - 2).Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            if (parsedInput.Length < 3)
            {
                Console.WriteLine(false);
                continue;
            }

            List<int> numberListInInt = new List<int>();
            bool error = false;

            foreach (var numberInStr in parsedInput)
            {
                if (!int.TryParse(numberInStr, out int numberInInt))
                {
                    error = true;
                    break;
                }
                numberListInInt.Add(numberInInt);
            }

            if (error)
            {
                Console.WriteLine("Wrong format!");
                continue;
            }

            bool sequenceFound = false;
            for (int index = 0; index < numberListInInt.Count - 2; index++)
            {
                int num1 = numberListInInt[index];
                int num2 = numberListInInt[index + 1];
                int num3 = numberListInInt[index + 2];

                if (num1 == 1 && num2 == 2 && num3 == 3)
                {
                    Console.WriteLine(true);
                    sequenceFound = true;
                    break;
                }
            }

            if (!sequenceFound)
            {
                Console.WriteLine(false);
            }
        }
    }

    public void Exercise35()
    {
        while (true)
        {
            Console.WriteLine("Write input like pqrstuvwx, pqkdiewx");
            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Wrong input format!");
                continue;
            }

            string[] parsedInput = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            if (parsedInput.Length != 2 || parsedInput[0].Length < 2 || parsedInput[1].Length < 2)
            {
                Console.WriteLine("Wrong input format!");
                continue;
            }

            List<string> string1Subsets = new List<string>();

            for (int index = 0; index < parsedInput[0].Length - 1; index++)
            {
                string subset = parsedInput[0][index].ToString() + parsedInput[0][index + 1].ToString();

                if (!string1Subsets.Contains(subset))
                {
                    string1Subsets.Add(subset);
                }
            }

            List<string> string2Subsets = new List<string>();
            for (int index = 0; index < parsedInput[1].Length - 1; index++)
            {
                string subset = parsedInput[1][index].ToString() + parsedInput[1][index + 1].ToString();

                if (!string2Subsets.Contains(subset))
                {
                    string2Subsets.Add(subset);
                }
            }

            int numOfSameSubstring = 0;

            foreach (var substring in string1Subsets)
            {
                if (string2Subsets.Contains(substring))
                {
                    numOfSameSubstring++;
                }
            }

            Console.WriteLine(numOfSameSubstring);
        }
    }

    public void Exercise36()
    {
        while (true)
        {
            Console.WriteLine("Write input like \"xxHxix\", \"x\"");
            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Wrong input format!");
                continue;
            }

            string[] parsedInput = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            if (parsedInput.Length != 2)
            {
                Console.WriteLine("Wrong input format!");
                continue;
            }

            string str = parsedInput[0].Trim().Replace("\"", "");
            string character = parsedInput[1].Trim().Replace("\"", "");

            if (character.Length != 1)
            {
                Console.WriteLine("Wrong input format!");
                continue;
            }

            Regex regex = new Regex(character);

            string output = regex.Replace(str, delegate (Match m)
               {
                   if (m.Index != 0 && m.Index != str.Length - 1)
                   {
                       return "";
                   }
                   return m.Value;
               });

            Console.WriteLine(output);
        }
    }

    public void Exercise37()
    {
        while (true)
        {
            Console.WriteLine("Write input like edipcanoktay");

            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Wrong input format!");
                continue;
            }

            StringBuilder strBuilder = new StringBuilder();


            for (int index = 0; 2 * index < input.Length; index += 2)
            {
                strBuilder.Append(input[2 * index]);

                if (2 * index + 1 < input.Length)
                {
                    strBuilder.Append(input[2 * index + 1]);
                }
            }

            Console.WriteLine(strBuilder.ToString());
        }
    }

    public void Exercise38()
    {
        while (true)
        {
            Console.WriteLine("Write input like { 5, 5, 2 }");

            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Wrong input format!");
                continue;
            }

            input = input.Replace(" ", "");

            string pattern1 = "5,5";
            string pattern2 = "5,6";

            int numOfMatches = 0;
            for (int index = 0; index < input.Length - 2; index++)
            {
                string substring = input.Substring(index, 3);
                if (substring.Equals(pattern1) || substring.Equals(pattern2))
                {
                    numOfMatches++;
                }
            }

            Console.WriteLine(numOfMatches);
        }
    }

    public void Exercise39()
    {
        while (true)
        {
            Console.WriteLine("Write input like { 5, 5, 2 }");

            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Wrong input format!");
                continue;
            }

            input = input.Substring(1, input.Length - 2).Replace(" ", "");

            string[] numbersInString = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            List<int> numbers = new List<int>();

            bool error = false;
            foreach (var numberInStr in numbersInString)
            {
                if (!int.TryParse(numberInStr, out int number))
                {
                    error = true;
                    break;
                }

                numbers.Add(number);
            }

            if (error)
            {
                Console.WriteLine("Wrong input format!");
                continue;
            }

            bool success = false;
            foreach (var number in numbers)
            {
                List<int> matches = numbers.FindAll((num) => num == number);

                if (matches.Count >= 3)
                {
                    int firstIndex = numbers.FindIndex((num) => num == number);
                    int secondIndex = numbers.FindIndex(firstIndex + 1, (num) => num == number);
                    int thirdIndex = numbers.FindIndex(secondIndex + 1, (num) => num == number);

                    if (secondIndex == firstIndex + 1 && thirdIndex == secondIndex + 1)
                    {
                        success = true;
                        break;
                    }
                }
            }

            Console.WriteLine(success);
        }
    }

    public void Exercise4()
    {
        while (true)
        {
            const int range = 10;

            // Get one number from  user
            Console.WriteLine("Enter one number");
            string input = Console.ReadLine();


            bool parsingResult = int.TryParse(input, out int numberInInt);

            if (!parsingResult)
            {
                Console.WriteLine("Error at the given input!");
                continue;
            }

            if (Math.Abs(numberInInt - 100) <= range || Math.Abs(numberInInt - 200) <= range)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
    }

    public void Exercise40()
    {
        while (true)
        {
            int[] inputNumbers = new int[2];

            bool success = AliihsanHelperClass.GetIntInputsWithCommaBetween(ref inputNumbers, out bool quit);

            if (quit)
            {
                Console.WriteLine("quitting...");
                break;
            }

            if (!success)
            {
                Console.WriteLine("Wrong input format!");
                continue;
            }

            if (inputNumbers.Sum() >= 10 && inputNumbers.Sum() <= 20)
            {
                Console.WriteLine(30);
            }

            else
            {
                Console.WriteLine(inputNumbers.Sum());
            }

        }
    }

    public void Exercise41()
    {
        while (true)
        {
            int[] inputNumbers = new int[2];

            bool success = AliihsanHelperClass.GetIntInputsWithCommaBetween(ref inputNumbers, out bool quit);

            if (quit)
            {
                Console.WriteLine("Quit...");
                return;
            }

            if (!success)
            {
                Console.WriteLine("Wrong  input format!");
                continue;
            }

            Console.WriteLine(inputNumbers.Any((num) => num == 5) ||
                inputNumbers.Sum() == 5 ||
                Math.Abs(inputNumbers[0] - inputNumbers[1]) == 5);
        }
    }

    public void Exercise42()
    {
        while (true)
        {
            int[] inputNumbers = new int[1];

            bool success = AliihsanHelperClass.GetIntInputsWithCommaBetween(ref inputNumbers, out bool quit);

            if (quit)
            {
                Console.WriteLine("Quit...");
                return;
            }

            if (!success)
            {
                Console.WriteLine("Wrong  input format!");
                continue;
            }

            int inputNumber = inputNumbers[0];

            if (inputNumber < 0)
            {
                Console.WriteLine("Wrong  input format!");
                continue;
            }

            Console.WriteLine((inputNumber % 13 == 0) ||
                (inputNumber % 13 == 1));
        }
    }

    public void Exercise43()
    {
        while (true)
        {
            int[] inputNumbers = new int[1];

            bool success = AliihsanHelperClass.GetIntInputsWithCommaBetween(ref inputNumbers, out bool quit);

            if (quit)
            {
                Console.WriteLine("Quit...");
                return;
            }

            if (!success || inputNumbers[0] < 0)
            {
                Console.WriteLine("Wrong  input format!");
                continue;
            }

            int inputNumber = inputNumbers[0];

            Console.WriteLine(inputNumber % 21 != 0
                && (inputNumber % 7 == 0 || inputNumber % 3 == 0));
        }
    }

    public void Exercise44()
    {
        while (true)
        {
            int[] inputNumbers = new int[1];

            bool success = AliihsanHelperClass.GetIntInputsWithCommaBetween(ref inputNumbers, out bool quit);

            if (quit)
            {
                Console.WriteLine("Quit...");
                return;
            }

            if (!success || inputNumbers[0] < 0)
            {
                Console.WriteLine("Wrong  input format!");
                continue;
            }


            int remainder = inputNumbers[0] % 10;

            Console.WriteLine(10 - remainder <= 2 || remainder <= 2);
        }
    }

    public void Exercise45()
    {
        while (true)
        {
            int[] inputNumbers = new int[2];

            bool success = AliihsanHelperClass.GetIntInputsWithCommaBetween(ref inputNumbers, out bool quit);

            if (quit)
            {
                Console.WriteLine("Quit...");
                return;
            }

            if (!success)
            {
                Console.WriteLine("Wrong  input format!");
                continue;
            }

            int result = inputNumbers.Any((num) => num >= 10 && num <= 20) ? 18 : inputNumbers.Sum();

            Console.WriteLine(result);
        }
    }

    public void Exercise46()
    {
        while (true)
        {
            Console.WriteLine("Enter a string amk");
            string input = Console.ReadLine().ToLower();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Wrong input!");
                continue;
            }

            string output;

            if (input.StartsWith("f") && input.EndsWith("b"))
            {
                output = "FizzBuzz";
            }

            else if (input.StartsWith("f"))
            {
                output = "Fizz";
            }
            else if (input.EndsWith("b"))
            {
                output = "Buzz";
            }
            else
            {
                output = input;
            }

            Console.WriteLine(output);
        }
    }

    public void Exercise47()
    {
        const int numOfInputs = 3;
        while (true)
        {

            int[] inputNumbers = new int[numOfInputs];

            bool success = AliihsanHelperClass.GetIntInputsWithCommaBetween(ref inputNumbers, out bool quit);

            if (quit)
            {
                Console.WriteLine("Quit...");
                return;
            }

            if (!success)
            {
                Console.WriteLine("Wrong  input format!");
                continue;
            }

            var inputNumbersList = inputNumbers.ToList();
            bool sumIsFound = false;
            for (int fixedIndex = 0; fixedIndex < numOfInputs - 1; fixedIndex++)
            {
                for (int runningIndex = fixedIndex + 1; runningIndex < numOfInputs; runningIndex++)
                {
                    int result = inputNumbersList[fixedIndex] + inputNumbersList[runningIndex];

                    if (inputNumbersList.Contains(result))
                    {
                        int firstIndex = inputNumbersList.IndexOf(result);
                        int lastIndex = inputNumbersList.LastIndexOf(result);

                        if ((firstIndex != -1 && firstIndex != runningIndex && firstIndex != fixedIndex) ||
                            (lastIndex != -1 && lastIndex != runningIndex && lastIndex != fixedIndex))
                        {
                            Console.WriteLine(true);
                            sumIsFound = true;
                            break;
                        }
                    }
                }
                if (sumIsFound)
                {
                    break;
                }
            }

            if (!sumIsFound)
            {
                Console.WriteLine(false);
            }

        }
    }

    public void Exercise48()
    {
        while (true)
        {
            int[] inputNumbers = new int[3];

            bool success = AliihsanHelperClass.GetIntInputsWithCommaBetween(ref inputNumbers, out bool quit);

            if (quit)
            {
                Console.WriteLine("Quit...");
                return;
            }

            if (!success)
            {
                Console.WriteLine("Wrong  input format!");
                continue;
            }

            Console.WriteLine((inputNumbers[2] > inputNumbers[1]) && (inputNumbers[1] > inputNumbers[0]));
        }
    }

    public void Exercise49()
    {
        while (true)
        {
            Console.WriteLine("write input like \"1, 2, 3, false\"");

            string input = Console.ReadLine();

            string[] parsedInput = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            if (parsedInput.Length != 4)
            {
                Console.WriteLine("Wrong input format aq");
                continue;
            }

            List<int> numbers = new List<int>();
            bool error = false;
            for (int i = 0; i < 3; i++)
            {
                if (int.TryParse(parsedInput[i], out int number))
                {
                    numbers.Add(number);
                }
                else
                {
                    error = true;
                    break;
                }
            }

            if (!bool.TryParse(parsedInput[3], out bool boolInput))
            {
                error = true;
            }

            if (error)
            {
                Console.WriteLine("Wrong input format aq");
                continue;
            }

            bool isSorted = numbers.SequenceEqual(numbers.OrderByDescending(num => num).Reverse());

            if (boolInput)
            {
                Console.WriteLine(isSorted || !numbers.Distinct().ToList().SequenceEqual(numbers));
            }

            else
            {
                Console.WriteLine(isSorted);
            }
        }
    }

    public void Exercise5()
    {
        while (true)
        {
            const string startingStr = "if";

            Console.WriteLine("Enter a string or enter -1 to quit");

            string inputStr = Console.ReadLine();

            if (inputStr == "-1")
            {
                break;
            }

            bool isStringStartWithIf;
            // Check if string starts with startingStr
            if (inputStr.Length < startingStr.Length)
            {
                isStringStartWithIf = false;
            }
            else if (inputStr.Substring(0, 2).ToUpper().Equals(startingStr.ToUpper()))
            {
                isStringStartWithIf = true;
            }

            else
            {
                isStringStartWithIf = false;
            }

            // Form output string
            string outputStr;
            if (isStringStartWithIf)
            {
                outputStr = inputStr;
            }

            else
            {
                outputStr = startingStr + " " + inputStr;
            }
            Console.WriteLine(outputStr);
        }
    }

    public void Exercise50()
    {
        while (true)
        {
            Console.WriteLine("write input like \"11, 21, 31\"");

            string input = Console.ReadLine();

            string[] parsedInput = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            if (parsedInput.Length != 3)
            {
                Console.WriteLine("Wrong input format aq");
                continue;
            }

            List<int> numbers = new List<int>();
            bool error = false;
            for (int i = 0; i < 3; i++)
            {
                if (int.TryParse(parsedInput[i], out int number))
                {
                    numbers.Add(number);
                }
                else
                {
                    error = true;
                    break;
                }
            }

            if (error)
            {
                Console.WriteLine("Wrong input format aq");
                continue;
            }

            List<int> lastDigits = new List<int>();
            foreach (var number in numbers)
            {
                lastDigits.Add(number % 10);
            }

            Console.WriteLine(!lastDigits.Distinct().ToList().SequenceEqual(lastDigits));
        }
    }

    public void Exercise51()
    {
        while (true)
        {
            int[] inputNumbers = new int[3];

            bool success = AliihsanHelperClass.GetIntInputsWithCommaBetween(ref inputNumbers, out bool quit);

            if (quit)
            {
                Console.WriteLine("Quit...");
                return;
            }

            if (!success)
            {
                Console.WriteLine("Wrong  input format!");
                continue;
            }


            bool pairFound = false;
            for (int fixedIndex = 0; fixedIndex < inputNumbers.Length - 1; fixedIndex++)
            {
                for (int runningIndex = fixedIndex + 1; runningIndex < inputNumbers.Length; runningIndex++)
                {
                    var result = Math.Abs(inputNumbers[fixedIndex] - inputNumbers[runningIndex]);
                    if (result >= 20)
                    {
                        pairFound = true;
                        break;
                    }
                }
                if (pairFound)
                {
                    break;
                }
            }

            Console.WriteLine(pairFound);
        }
    }

    public void Exercise52()
    {
        while (true)
        {
            int[] inputNumbers = new int[2];

            bool success = AliihsanHelperClass.GetIntInputsWithCommaBetween(ref inputNumbers, out bool quit);

            if (quit)
            {
                Console.WriteLine("Quit...");
                return;
            }

            if (!success)
            {
                Console.WriteLine("Wrong  input format!");
                continue;
            }

            int result;
            if (inputNumbers[0] % 7 == inputNumbers[1] % 7)
            {
                result = inputNumbers[0] > inputNumbers[1] ? inputNumbers[1] : inputNumbers[0];
            }
            else if (inputNumbers[0] == inputNumbers[1])
            {
                result = 0;
            }
            else
            {
                result = inputNumbers[0] > inputNumbers[1] ? inputNumbers[0] : inputNumbers[1];
            }

            Console.WriteLine(result);
        }
    }

    public void Exercise53()
    {
        while (true)
        {
            int[] inputNumbers = new int[2];

            bool success = AliihsanHelperClass.GetIntInputsWithCommaBetween(ref inputNumbers, out bool quit);

            if (quit)
            {
                Console.WriteLine("Quit...");
                return;
            }

            if (!success)
            {
                Console.WriteLine("Wrong  input format!");
                continue;
            }

            if (inputNumbers.Any(number => number >= 100 || number < 10))
            {
                Console.WriteLine("Wrong  input format!");
                continue;
            }

            string num1 = inputNumbers[0].ToString();
            string num2 = inputNumbers[1].ToString();


            Console.WriteLine(
                num1.Contains(num2[0]) ||
                num1.Contains(num2[1])
                );
        }
    }

    public void Exercise54()
    {
        while (true)
        {
            int[] inputNumbers = new int[2];

            bool success = AliihsanHelperClass.GetIntInputsWithCommaBetween(ref inputNumbers, out bool quit);

            if (quit)
            {
                Console.WriteLine("Quit...");
                return;
            }

            if (!success || inputNumbers[0] < 0 || inputNumbers[1] < 0)
            {
                Console.WriteLine("Wrong  input format!");
                continue;
            }

            int sum = inputNumbers.Sum();

            int result = sum.ToString().Count() == inputNumbers[0].ToString().Count() ?
                sum : inputNumbers[0];

            Console.WriteLine(result);
        }
    }

    public void Exercise55()
    {
        while (true)
        {
            int[] inputNumbers = new int[3];

            bool success = AliihsanHelperClass.GetIntInputsWithCommaBetween(ref inputNumbers, out bool quit);

            if (quit)
            {
                Console.WriteLine("Quit...");
                return;
            }

            if (!success)
            {
                Console.WriteLine("Wrong  input format!");
                continue;
            }

            if (inputNumbers.Distinct().Count() != inputNumbers.Count())
            {
                Console.WriteLine(inputNumbers[2]);
            }
            else
            {
                Console.WriteLine(inputNumbers.Sum());
            }
        }
    }

    public void Exercise56()
    {
        while (true)
        {
            int[] inputNumbers = new int[3];

            bool success = AliihsanHelperClass.GetIntInputsWithCommaBetween(ref inputNumbers, out bool quit);

            if (quit)
            {
                Console.WriteLine("quitting");
                break;
            }

            if (!success)
            {
                Console.WriteLine("Error withthe given input!");
                continue;
            }

            if (inputNumbers.Contains(13))
            {
                var inputNumbersList = inputNumbers.ToList();
                int sum = inputNumbersList.GetRange(0, inputNumbersList.FindIndex(num => num == 13)).Sum();
                Console.WriteLine(sum);
                continue;
            }

            Console.WriteLine(inputNumbers.Sum());
        }
    }

    public void Exercise57()
    {
        while (true)
        {
            int[] inputNumbers = new int[3];

            bool success = AliihsanHelperClass.GetIntInputsWithCommaBetween(ref inputNumbers, out bool quit);

            if (quit)
            {
                Console.WriteLine("Quit...");
                return;
            }

            if (!success)
            {
                Console.WriteLine("Wrong  input format!");
                continue;
            }

            if (inputNumbers.Any(num => num >= 10 && num <= 20))
            {
                int sum = inputNumbers.Sum((intNum) =>
                  {
                      if ((intNum >= 10 && intNum <= 20) && (intNum != 13 && intNum != 17))
                      {
                          return 0;
                      }

                      return intNum;
                  });

                Console.WriteLine(sum);
            }

            else
            {
                Console.WriteLine(inputNumbers.Sum());
            }
        }
    }

    public void Exercise58()
    {
        while (true)
        {
            int[] inputNumbers = new int[2];

            bool success = AliihsanHelperClass.GetIntInputsWithCommaBetween(ref inputNumbers, out bool quit);

            if (quit)
            {
                Console.WriteLine("Quit...");
                return;
            }

            if (!success)
            {
                Console.WriteLine("Wrong  input format!");
                continue;
            }

            int result;
            if (inputNumbers.All(num => num > 13))
            {
                result = 0;
            }
            else if (inputNumbers.Any(num => num > 13))
            {
                result = inputNumbers[0] > inputNumbers[1] ? inputNumbers[1] : inputNumbers[0];
            }
            else
            {
                result = (13 - inputNumbers[0]) > (13 - inputNumbers[1]) ?
                    inputNumbers[1] : inputNumbers[0];
            }
            Console.WriteLine(result);
        }
    }

    public void Exercise59()
    {
        while (true)
        {
            int[] inputNumbers = new int[3];

            bool success = AliihsanHelperClass.GetIntInputsWithCommaBetween(ref inputNumbers, out bool quit);

            if (quit)
            {
                Console.WriteLine("Quit...");
                return;
            }

            if (!success)
            {
                Console.WriteLine("Wrong  input format!");
                continue;
            }

            inputNumbers = inputNumbers.OrderByDescending(num => num).ToArray();

            Console.WriteLine(inputNumbers[2] - inputNumbers[1] ==
                inputNumbers[1] - inputNumbers[0]);
        }
    }

    public void Exercise6()
    {

        while (true)
        {
            Console.WriteLine("Enter a string between \" \"  and index to delete char with ',' in between. Enter -1 to quit!");

            string input = Console.ReadLine();

            if (input.Equals("-1"))
            {
                Console.WriteLine("Quitting...");
                break;
            }

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Input is not valid");
                continue;
            }

            string[] parsedInput = input.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);

            if (parsedInput.Length != 2 || !int.TryParse(parsedInput[1], out int index))
            {
                Console.WriteLine("Invalid input!");
                continue;
            }

            string output = parsedInput[0].Remove(parsedInput[0].Length - 1, 1).Remove(0, 1).Remove(index, 1);

            Console.WriteLine(output);
        }
    }

    public void Exercise60()
    {
        while (true)
        {
            Console.WriteLine("Enter two strings with a coma between.i.e \"Hi, Hello\" ");
            string input = Console.ReadLine();
            string[] parsedInput = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            if (parsedInput.Length != 2)
            {
                Console.WriteLine("Wrong input format!");
                continue;
            }

            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < 2; i++)
            {
                for (int strIndex = 0; strIndex < parsedInput.Length; strIndex++)
                {
                    stringBuilder = stringBuilder.Append(parsedInput[strIndex]);
                }
            }

            Console.WriteLine(stringBuilder);
        }
    }

    public void Exercise61()
    {
        while (true)
        {
            Console.WriteLine("Enter two strings with a coma between.i.e \"[[]], Hello\" ");
            string input = Console.ReadLine();
            string[] parsedInput = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            if (parsedInput.Length != 2 || parsedInput[0].Length != 4)
            {
                Console.WriteLine("Wrong input format!");
                continue;
            }

            Console.WriteLine(parsedInput[0].Insert(2, parsedInput[1]));
        }

    }

    public void Exercise62()
    {
        while (true)
        {
            Console.WriteLine("Enter one  string of length at least two\" ");
            string input = Console.ReadLine();

            if (input.Length < 2)
            {
                Console.WriteLine("Wrong input format!");
                continue;
            }

            Console.WriteLine(string.Concat(Enumerable.Repeat(input.Substring(input.Length - 2, 2), 3)));
        }
    }

    public void Exercise63()
    {
        while (true)
        {
            Console.WriteLine("Enter one string ");
            string input = Console.ReadLine();

            if (input.Length <= 2 || string.IsNullOrEmpty(input))
            {
                Console.WriteLine(input);
                continue;
            }

            Console.WriteLine(input.Substring(0, 2));
        }
    }

    public void Exercise64()
    {
        while (true)
        {
            Console.WriteLine("Enter one string with at least 2 characters.");
            string input = Console.ReadLine();

            if (input.Length < 2 || string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Wrong input format!");
                continue;
            }

            Console.WriteLine(input.Substring(0, input.Length / 2));
        }
    }

    public void Exercise65()
    {
        while (true)
        {
            Console.WriteLine("Enter a string with at  least 2 characters");
            string input = Console.ReadLine();

            if (input.Length < 2)
            {
                Console.WriteLine("Wrong input format!");
                continue;
            }
            Console.WriteLine(input.Remove(input.Length - 1).Remove(0, 1));
        }
    }

    public void Exercise66()
    {
        while (true)
        {
            Console.WriteLine("Enter two strings with a coma beween. i.e \"Hello, Hi\"");

            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input) ||
                input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Length != 2)
            {
                Console.WriteLine("Wrong input format!");
                continue;
            }

            string[] splittedInputs = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            string shortStr = splittedInputs[0].Length > splittedInputs[1].Length ? splittedInputs[1] : splittedInputs[0];
            string longStr = splittedInputs[0].Length > splittedInputs[1].Length ? splittedInputs[0] : splittedInputs[1];

            Console.WriteLine(longStr + shortStr + longStr);
        }
    }

    public void Exercise67()
    {
        while (true)
        {
            Console.WriteLine("Enter two strings with a coma beween. i.e \"Hello, Hi\"");

            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input) ||
                input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Length != 2)
            {
                Console.WriteLine("Wrong input format!");
                continue;
            }

            string[] splittedInputs = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < splittedInputs.Length; i++)
            {
                splittedInputs[i] = splittedInputs[i].Trim();
                splittedInputs[i] = splittedInputs[i].Remove(0, 1);
            }
            Console.WriteLine(string.Join("", splittedInputs));
        }
    }

    public void Exercise68()
    {
        while (true)
        {
            Console.WriteLine("Enter 1 string. i.e \"Hello\"");

            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input) ||
                input.Length < 2)
            {
                Console.WriteLine("Wrong input format!");
                continue;
            }

            string output = input.Substring(2, input.Length - 2) + input.Substring(0, 2);

            Console.WriteLine(output);
        }

    }

    public void Exercise69()
    {
        while (true)
        {
            Console.WriteLine("Enter 1 string. i.e \"Hello\"");

            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input) ||
                input.Length < 2)
            {
                Console.WriteLine("Wrong input format!");
                continue;
            }

            string output = input.Substring(input.Length - 2, 2) + input.Substring(0, input.Length - 2);

            Console.WriteLine(output);
        }
    }

    public void Exercise7()
    {
        while (true)
        {
            Console.WriteLine("Enter a string. Enter -1 to quit!");

            string input = Console.ReadLine();

            if (input.Equals("-1"))
            {
                Console.WriteLine("Quitting...");
                break;
            }

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Input is not valid");
                continue;
            }

            StringBuilder output = new StringBuilder(input);

            char firstChar = output[0];

            char lastChar = output[output.Length - 1];

            output[0] = lastChar;

            output[output.Length - 1] = firstChar;

            Console.WriteLine(output.ToString());
        }
    }

    public void Exercise70()
    {
        while (true)
        {
            Console.WriteLine("Enter 1 string. i.e \"Hello\"");

            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input) || input.Length <= 1)
            {
                Console.WriteLine("");
                continue;
            }

            Console.WriteLine(input.Remove(input.Length - 1, 1).Remove(0, 1));
        }

    }

    public void Exercise71()
    {
        while (true)
        {
            Console.WriteLine("Enter 1 string. i.e \"Hello\"");

            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input) || input.Length < 2)
            {
                Console.WriteLine("");
                continue;
            }

            int middleIndex = (input.Length / 2) - 1;

            Console.WriteLine(input.Substring(middleIndex, 2));
        }
    }

    public void Exercise72()
    {
        while (true)
        {
            Console.WriteLine("Enter 1 string. i.e \"Hello\"");

            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input) || input.Length < 2)
            {
                Console.WriteLine(false);
                continue;
            }


            Console.WriteLine(input.EndsWith("on"));
        }

    }

    public void Exercise73()
    {
        while (true)
        {
            Console.WriteLine("Enter 1 string and one number with  comma between. i.e \"Hello,2\"");

            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input) || input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Length != 2)
            {
                Console.WriteLine("Wrong format");
                continue;
            }

            string[] splittedInput = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            if (int.TryParse(splittedInput[1], out int numOfChars) && splittedInput[0].Length >= numOfChars && numOfChars >= 0)
            {
                Console.WriteLine(splittedInput[0].Substring(0, numOfChars) + splittedInput[0].Substring(splittedInput[0].Length - numOfChars, numOfChars));
            }
            else
            {
                Console.WriteLine("Wrong format");
                continue;
            }
        }

    }

    public void Exercise74()
    {
        while (true)
        {
            Console.WriteLine("Enter 1 string and one number with  comma between. i.e \"Hello,2\"");

            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input) || input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Length != 2)
            {
                Console.WriteLine("Wrong format");
                continue;
            }

            string[] splittedInput = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            if (int.TryParse(splittedInput[1], out int charStartingIndex) && splittedInput[0].Length - 1 > charStartingIndex && charStartingIndex >= 0)
            {
                Console.WriteLine(splittedInput[0].Substring(charStartingIndex, 2));
            }
            else
            {
                Console.WriteLine("Wrong format");
                continue;
            }
        }
    }

    public void Exercise75()
    {
        while (true)
        {
            Console.WriteLine("Enter 1 string. i.e \"Hello\"");

            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input) || input.Length < 3)
            {
                Console.WriteLine(false);
                continue;
            }

            int middleIndex = (input.Length / 2) - 1;

            Console.WriteLine(input.Substring(middleIndex, 3));
        }
    }

    public void Exercise76()
    {
        while (true)
        {
            Console.WriteLine("Enter 1 string. i.e \"Hello\"");

            string input = Console.ReadLine();

            if (input.Length < 2)
            {
                Console.WriteLine(input + new string('#', 2 - input.Length));
                continue;
            }
            Console.WriteLine(input.Substring(0, 2));
        }
    }

    public void Exercise77()
    {
        while (true)
        {
            Console.WriteLine("Enter two strings with a coma beween. i.e \"Hello, Hi\"");

            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input) ||
                input.Split(new char[] { ',' }).Length != 2)
            {
                Console.WriteLine("Wrong input format!");
                continue;
            }

            var splittedInput = input.Split(new char[] { ',' });

            for (int i = 0; i < splittedInput.Length; i++)
            {
                splittedInput[i] = (new StringBuilder(splittedInput[i])).Append('#').ToString();
            }

            Console.WriteLine("" + splittedInput[0][0] + splittedInput[1][0]);
        }
    }

    public void Exercise78()
    {
        while (true)
        {
            Console.WriteLine("Enter two strings with a coma beween. i.e \"Hello, Hi\"");

            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input) ||
                input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Length != 2)
            {
                Console.WriteLine("Wrong input format!");
                continue;
            }

            string output = string.Join("", input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries));

            for (int i = 0; i < output.Length - 1; i++)
            {
                if (output[i] == output[i + 1])
                {
                    output = output.Remove(i, 1);
                    i--;
                }
            }
            Console.WriteLine(output);
        }
    }

    public void Exercise79()
    {
        while (true)
        {
            Console.WriteLine("Enter 1 string. i.e \"Hello\"");

            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Wrong format");
                continue;
            }

            if (input.Length < 2)
            {
                Console.WriteLine(input);
                continue;
            }

            StringBuilder output = new StringBuilder(input.Substring(0, input.Length - 2));
            output = output.Append(new char[] { input[input.Length - 1], input[input.Length - 2] });

            Console.WriteLine(output);
        }
    }

    public void Exercise8()
    {
        const int CopyTimes = 4;

        while (true)
        {
            Console.WriteLine("Enter a string. Enter -1 to quit!");

            string input = Console.ReadLine();

            if (input.Equals("-1"))
            {
                Console.WriteLine("Quitting...");
                break;
            }

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Input is not valid");
                continue;
            }

            if (input.Length < 2)
            {
                Console.WriteLine(input);
                continue;
            }

            string strToCopy = input.Substring(0, 2);

            StringBuilder outputStringBuilder = new StringBuilder();


            for (int i = 0; i < CopyTimes; i++)
            {
                outputStringBuilder.Append(strToCopy);
            }

            Console.WriteLine(outputStringBuilder);
        }
    }

    public void Exercise80()
    {
        while (true)
        {
            Console.WriteLine("Enter 1 string. i.e \"Hello\"");

            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Wrong format");
                continue;
            }

            if (input.Length < 3)
            {
                Console.WriteLine("");
                continue;
            }

            string[] startingStrings = new string[] { "xyz", "abc" };
            bool stringStartsWith = false;

            for (int strIndex = 0; strIndex < startingStrings.Length; strIndex++)
            {
                if (input.StartsWith(startingStrings[strIndex]))
                {
                    Console.WriteLine(startingStrings[strIndex]);
                    stringStartsWith = true;
                    continue;
                }
            }

            if (!stringStartsWith)
                Console.WriteLine("");
        }
    }

    public void Exercise81()
    {
        while (true)
        {
            Console.WriteLine("Enter 1 string with the length of two at least. i.e \"Hello\"");

            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input) || input.Length < 2)
            {
                Console.WriteLine("Wrong format");
                continue;
            }

            Console.WriteLine(input.Substring(0, 2).Equals(input.Substring(input.Length - 2, 2)));
        }
    }

    public void Exercise82()
    {
        while (true)
        {
            Console.WriteLine("Enter 2 strings with a comma between. i.e \"Hello,osman\"");

            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input) || input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Length != 2)
            {
                Console.WriteLine("Wrong format");
                continue;
            }

            string[] splittedInput = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            int maxLengthAllowed = splittedInput.Min(str => str.Length);

            Console.WriteLine(splittedInput[0].Substring(0, maxLengthAllowed) + splittedInput[1].Substring(0, maxLengthAllowed));
        }
    }

    public void Exercise83()
    {
        while (true)
        {
            Console.WriteLine("Enter 1 string with a comma between. i.e \"Hello\"");

            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Wrong format");
                continue;
            }

            string output;

            if (input.Length < 2)
            {
                output = string.Concat(Enumerable.Repeat(input, 3));
            }
            else
            {
                output = string.Concat(Enumerable.Repeat(input.Substring(0, 2), 3));
            }

            Console.WriteLine(output);
        }
    }

    public void Exercise84()
    {
        while (true)
        {
            Console.WriteLine("Enter 1 string with the length of 2 at least. i.e \"Hello\"");

            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input) || input.Length < 2)
            {
                Console.WriteLine("Wrong format");
                continue;
            }

            string output;

            if (input[0] == input[input.Length - 1])
            {
                output = input.Substring(2, input.Length - 2);
            }
            else
            {
                output = input;
            }

            Console.WriteLine(output);
        }
    }

    public void Exercise85()
    {
        while (true)
        {
            Console.WriteLine("Enter 1 string with the length of 2 at least. i.e \"Hello\"");

            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input) || input.Length < 2)
            {
                Console.WriteLine("Wrong format");
                continue;
            }

            string output;

            if (input[0] == 'p' && input[1] == 'y')
            {
                output = input;
            }
            else if (input[0] == 'p')
            {
                output = input.Remove(1, 1);
            }
            else if (input[1] == 'y')
            {
                output = input.Substring(1, input.Length - 1);
            }
            else
            {
                output = input.Substring(2, input.Length - 2);
            }

            Console.WriteLine(output);
        }
    }

    public void Exercise86()
    {
        while (true)
        {
            Console.WriteLine("Enter 1 string. i.e \"Hello\"");

            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Wrong format");
                continue;
            }

            if (input.Length == 1 && input == "a")
            {
                Console.WriteLine("");
                continue;
            }
            else if (input.Length == 1)
            {
                Console.WriteLine(input);
                continue;
            }

            string output;

            if (input[0] == 'a' && input[input.Length - 1] == 'a')
            {
                output = input.Substring(1, input.Length - 2);
            }
            else if (input[0] == 'a')
            {
                output = input.Remove(0, 1);
            }
            else if (input[input.Length - 1] == 'a')
            {
                output = input.Substring(0, input.Length - 2);
            }
            else
            {
                output = input;
            }

            Console.WriteLine(output);
        }
    }

    public void Exercise87()
    {
        while (true)
        {
            Console.WriteLine("Enter 1 string. i.e \"Hello\"");

            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Wrong format");
                continue;
            }

            if (input.Length == 1 && input == "a")
            {
                Console.WriteLine("");
                continue;
            }
            else if (input.Length == 1)
            {
                Console.WriteLine(input);
                continue;
            }

            string output;

            if (input[0] == 'a' && input[1] == 'a')
            {
                output = input.Substring(2, input.Length - 2);
            }
            else if (input[0] == 'a')
            {
                output = input.Remove(0, 1);
            }
            else
            {
                output = input;
            }

            Console.WriteLine(output);
        }
    }

    public void Exercise88()
    {
        while (true)
        {
            Console.WriteLine("Write an int array with a comma between each number. i.e 10,20,30,40,");

            string input = Console.ReadLine().Trim();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Wrong format");
                continue;
            }

            string[] parsedInput = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            List<int> numbers = new List<int>();

            bool errorOccured = false;
            foreach (var item in parsedInput)
            {
                if (int.TryParse(item, out int number))
                {
                    numbers.Add(number);
                }
                else
                {
                    errorOccured = true;
                    break;
                }
            }

            if (errorOccured)
            {
                Console.WriteLine("error with given input!");
                continue;
            }

            Console.WriteLine(numbers.First() == 10 || numbers.Last() == 10);
        }
    }

    public void Exercise89()
    {
        while (true)
        {
            Console.WriteLine("Write an int array with a comma between each number. i.e 10,20,30,40,");

            string input = Console.ReadLine().Trim();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Wrong format");
                continue;
            }

            string[] parsedInput = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            List<int> numbers = new List<int>();

            bool errorOccured = false;
            foreach (var item in parsedInput)
            {
                if (int.TryParse(item, out int number))
                {
                    numbers.Add(number);
                }
                else
                {
                    errorOccured = true;
                    break;
                }
            }

            if (errorOccured)
            {
                Console.WriteLine("error with given input!");
                continue;
            }

            Console.WriteLine(numbers.First() == numbers.Last());
        }
    }

    public void Exercise9()
    {
        while (true)
        {
            Console.WriteLine("Enter a string. Enter -1 to quit!");

            string input = Console.ReadLine();

            if (input.Equals("-1"))
            {
                Console.WriteLine("Quitting...");
                break;
            }

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Input is not valid");
                continue;
            }

            StringBuilder outputSB = new StringBuilder(input);

            char lastChar = input[input.Length - 1];

            outputSB = outputSB.Insert(0, lastChar).Append(lastChar);

            Console.WriteLine(outputSB);
        }
    }

    public void Exercise90()
    {
        while (true)
        {
            Console.WriteLine("Write two int arrays with a comma between each number and paranthesis around each array. " +
                "i.e { 10, 20, 40, 50 }, { 10, 20, 40, 50 }");

            string input = Console.ReadLine().Trim();
            input = Regex.Replace(input, " ", "");

            if (string.IsNullOrWhiteSpace(input) || input.Count(chr => chr == '{') != 2 || input.Count(chr => chr == '}') != 2)
            {
                Console.WriteLine("Wrong format");
                continue;
            }

            string[] inputArrays = new string[2];
            inputArrays[0] = input.Substring(1, input.IndexOf('}') - 1);
            inputArrays[1] = input.Substring(input.LastIndexOf('{') + 1, input.LastIndexOf('}') - input.LastIndexOf('{') - 1);

            int[][] intArrays = new int[2][];

            bool errorOccured = false;
            for (int arrayIndex = 0; arrayIndex < inputArrays.Length; arrayIndex++)
            {
                string[] parsedIntArray = inputArrays[arrayIndex].Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                intArrays[arrayIndex] = new int[parsedIntArray.Length];

                for (int strIndex = 0; strIndex < parsedIntArray.Length; strIndex++)
                {
                    if (int.TryParse(parsedIntArray[strIndex], out int intVal))
                    {
                        intArrays[arrayIndex][strIndex] = intVal;
                    }
                    else
                    {
                        errorOccured = true;
                        break;
                    }
                }

                if (errorOccured)
                {
                    break;
                }
            }

            if (errorOccured)
            {
                Console.WriteLine("problem with given input");
                continue;
            }

            Console.WriteLine(intArrays[0][0] == intArrays[1][0] || intArrays[0][intArrays[0].Length - 1] == intArrays[1][intArrays[1].Length - 1]);
        }
    }

    public void Exercise91()
    {
        while (true)
        {
            Console.WriteLine("Write an int array with a comma between each number. i.e 10,20,30,40,");

            string input = Console.ReadLine().Trim();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Wrong format");
                continue;
            }

            string[] parsedInput = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            List<int> numbers = new List<int>();

            bool errorOccured = false;
            foreach (var item in parsedInput)
            {
                if (int.TryParse(item, out int number))
                {
                    numbers.Add(number);
                }
                else
                {
                    errorOccured = true;
                    break;
                }
            }

            if (errorOccured)
            {
                Console.WriteLine("error with given input!");
                continue;
            }

            Console.WriteLine(numbers.Sum());
        }
    }

    public void Exercise92()
    {
        const int numOfShifting = 1;
        while (true)
        {
            Console.WriteLine("Write an int array with a comma between each number. i.e 10,20,30,40,");

            string input = Console.ReadLine().Trim();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Wrong format");
                continue;
            }

            string[] parsedInput = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            List<int> numbers = new List<int>();

            bool errorOccured = false;
            foreach (var item in parsedInput)
            {
                if (int.TryParse(item, out int number))
                {
                    numbers.Add(number);
                }
                else
                {
                    errorOccured = true;
                    break;
                }
            }

            if (errorOccured)
            {
                Console.WriteLine("error with given input!");
                continue;
            }

            int length = numbers.Count;
            int[] newArr = new int[length];

            for (int index = 0; index < length; index++)
            {
                int newIndex = (index - numOfShifting + length) % length;
                newArr[newIndex] = numbers[index];
            }

            for (int i = 0; i < length; i++)
            {
                Console.Write(newArr[i] + ",");
            }

            Console.WriteLine();
        }
    }

    public void Exercise93()
    {
        while (true)
        {
            Console.WriteLine("Write an int array with a comma between each number. i.e 10,20,30,40,");

            string input = Console.ReadLine().Trim();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Wrong format");
                continue;
            }

            string[] parsedInput = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            List<int> numbers = new List<int>();

            bool errorOccured = false;
            foreach (var item in parsedInput)
            {
                if (int.TryParse(item, out int number))
                {
                    numbers.Add(number);
                }
                else
                {
                    errorOccured = true;
                    break;
                }
            }

            if (errorOccured)
            {
                Console.WriteLine("error with given input!");
                continue;
            }

            numbers.Reverse();

            foreach (var num in numbers)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine();
        }
    }

    public void Exercise94()
    {
        while (true)
        {
            Console.WriteLine("Write an int array with a comma between each number. i.e 10,20,30,40,");

            string input = Console.ReadLine().Trim();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Wrong format");
                continue;
            }

            string[] parsedInput = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            List<int> numbers = new List<int>();

            bool errorOccured = false;
            foreach (var item in parsedInput)
            {
                if (int.TryParse(item, out int number))
                {
                    numbers.Add(number);
                }
                else
                {
                    errorOccured = true;
                    break;
                }
            }

            if (errorOccured)
            {
                Console.WriteLine("error with given input!");
                continue;
            }

            int maxElement = numbers.Max();

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.Write(maxElement + " ");
            }

            Console.WriteLine();
        }
    }

    public void Exercise95()
    {
        while (true)
        {
            Console.WriteLine("Write two int arrays with a comma between each number and paranthesis around each array. " +
                "i.e { 10, 20, 40, 50 }, { 10, 20, 40, 50 }");

            string input = Console.ReadLine().Trim();
            input = Regex.Replace(input, " ", "");

            if (string.IsNullOrWhiteSpace(input) || input.Count(chr => chr == '{') != 2 || input.Count(chr => chr == '}') != 2)
            {
                Console.WriteLine("Wrong format");
                continue;
            }

            string[] inputArrays = new string[2];
            inputArrays[0] = input.Substring(1, input.IndexOf('}') - 1);
            inputArrays[1] = input.Substring(input.LastIndexOf('{') + 1, input.LastIndexOf('}') - input.LastIndexOf('{') - 1);

            int[][] intArrays = new int[2][];

            bool errorOccured = false;
            for (int arrayIndex = 0; arrayIndex < inputArrays.Length; arrayIndex++)
            {
                string[] parsedIntArray = inputArrays[arrayIndex].Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                intArrays[arrayIndex] = new int[parsedIntArray.Length];

                for (int strIndex = 0; strIndex < parsedIntArray.Length; strIndex++)
                {
                    if (int.TryParse(parsedIntArray[strIndex], out int intVal))
                    {
                        intArrays[arrayIndex][strIndex] = intVal;
                    }
                    else
                    {
                        errorOccured = true;
                        break;
                    }
                }

                if (errorOccured)
                {
                    break;
                }
            }

            if (errorOccured)
            {
                Console.WriteLine("problem with given input");
                continue;
            }

            Console.WriteLine(intArrays[0][intArrays[0].Length / 2] + " " + intArrays[1][intArrays[1].Length / 2]);
        }
    }

    public void Exercise96()
    {
        while (true)
        {
            Console.WriteLine("Write an int array with a comma between each number. i.e 10,20,30,40,");

            string input = Console.ReadLine().Trim();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Wrong format");
                continue;
            }

            string[] parsedInput = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            List<int> numbers = new List<int>();

            bool errorOccured = false;
            foreach (var item in parsedInput)
            {
                if (int.TryParse(item, out int number))
                {
                    numbers.Add(number);
                }
                else
                {
                    errorOccured = true;
                    break;
                }
            }

            if (errorOccured)
            {
                Console.WriteLine("error with given input!");
                continue;
            }

            Console.WriteLine(numbers.First() + " " + numbers.Last());
        }
    }

    public void Exercise97()
    {
        while (true)
        {
            Console.WriteLine("Write an int array with a comma between each number. i.e 10,20,30,40,");

            string input = Console.ReadLine().Trim();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Wrong format");
                continue;
            }

            string[] parsedInput = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            List<int> numbers = new List<int>();

            bool errorOccured = false;
            foreach (var item in parsedInput)
            {
                if (int.TryParse(item, out int number))
                {
                    numbers.Add(number);
                }
                else
                {
                    errorOccured = true;
                    break;
                }
            }

            if (errorOccured)
            {
                Console.WriteLine("error with given input!");
                continue;
            }

            Console.WriteLine(numbers.Contains(15) || numbers.Contains(20));
        }
    }

    public void Exercise98()
    {
        while (true)
        {
            Console.WriteLine("Write an int array with a comma between each number. i.e 10,20,30,40,");

            string input = Console.ReadLine().Trim();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Wrong format");
                continue;
            }

            string[] parsedInput = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            List<int> numbers = new List<int>();

            bool errorOccured = false;
            foreach (var item in parsedInput)
            {
                if (int.TryParse(item, out int number))
                {
                    numbers.Add(number);
                }
                else
                {
                    errorOccured = true;
                    break;
                }
            }

            if (errorOccured)
            {
                Console.WriteLine("error with given input!");
                continue;
            }

            Console.WriteLine(!numbers.Contains(15) && !numbers.Contains(20));
        }
    }

    public void Exercise99()
    {
        while (true)
        {
            Console.WriteLine("Write an int array with a comma between each number. i.e 10,20,30,40,");

            string input = Console.ReadLine().Trim();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Wrong format");
                continue;
            }

            string[] parsedInput = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            List<int> numbers = new List<int>();

            bool errorOccured = false;
            foreach (var item in parsedInput)
            {
                if (int.TryParse(item, out int number))
                {
                    numbers.Add(number);
                }
                else
                {
                    errorOccured = true;
                    break;
                }
            }

            if (errorOccured)
            {
                Console.WriteLine("error with given input!");
                continue;
            }

            Console.Write(numbers.First() + " ");
            for (int i = 0; i < numbers.Count * 2 - 1; i++)
            {
                Console.Write(0 + " ");
            }
            Console.WriteLine();
        }
    }
}
