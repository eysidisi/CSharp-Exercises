using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class LinQExercises : ILinQExerciseSet
{
    public void Exercise1()
    {
        int[] arr = new int[5];

        for (int i = 0; i < 5; i++)
        {
            arr[i] = i;
        }

        var resultArr = arr.Where(n => n % 2 == 0);

        foreach (var item in resultArr)
        {
            Console.Write(item + " ");
        }
    }

    public void Exercise10()
    {
        while (true)
        {
            Console.WriteLine("Input the number of members on the List");

            string arrayLengthStr = Console.ReadLine();

            if (!int.TryParse(arrayLengthStr, out int arrayLength) || arrayLength <= 0)
            {
                Console.WriteLine("Enter a valid value aq");
                continue;
            }

            int[] arr = new int[arrayLength];

            bool error = false;

            for (int i = 0; i < arrayLength; i++)
            {
                Console.WriteLine("Enter member " + i);

                string member = Console.ReadLine();

                if (!int.TryParse(member, out int newMember))
                {
                    Console.WriteLine("Enter a valid value aq");
                    error = true;
                    break;
                }
                arr[i] = newMember;
            }

            if (error)
            {
                continue;
            }

            Console.WriteLine("Input the value above you want to display the members of the List");

            string filterVal = Console.ReadLine();

            if (!int.TryParse(filterVal, out int filterValInt))
            {
                Console.WriteLine("Enter a valid value aq");
                continue;
            }

            var greatElements = arr.Where(n => n > filterValInt);

            Console.WriteLine($"The numbers greater than {filterValInt} are :");

            greatElements.ToList().ForEach(n => Console.WriteLine(n));

        }
    }

    public void Exercise11()
    {
        while (true)
        {
            List<int> numbers = new List<int>()
            {
                5,
                7,
                13,
                24,
                6 ,
                9 ,
                8 ,
                7
            };

            Console.WriteLine("How many records you want to display?");

            string input = Console.ReadLine();

            if (!int.TryParse(input, out int inputInt))
            {
                Console.WriteLine("Enter an integer!");
                continue;
            }

            numbers = numbers.OrderByDescending(n => n).ToList();

            numbers.Take(inputInt).ToList().ForEach(n => Console.WriteLine(n));
        }
    }

    public void Exercise12()
    {
        string str = "this IS a STRING";

        string[] parsedStr = str.Split(new char[] { ' ' });

        Console.WriteLine("Uppercase words: ");

        foreach (string word in parsedStr)
        {
            if (string.Compare(word, word.ToUpper()) == 0)
            {
                Console.WriteLine(word);
            }
        }
    }

    public void Exercise13()
    {

        while (true)
        {
            Console.WriteLine("Input number of strings to store in the array ");

            //Input 3 strings for the array :
            //Element[0] : cat
            //Element[1] : dog
            //Element[2] : rat
            //Expected Output:
            //Here is the string below created with elements of the above array :
            //cat, dog, rat
            string arrayLengthStr = Console.ReadLine();

            if (!int.TryParse(arrayLengthStr, out int arrayLength) || arrayLength <= 0)
            {
                Console.WriteLine("Enter a valid value aq");
                continue;
            }

            string[] arr = new string[arrayLength];

            for (int i = 0; i < arrayLength; i++)
            {
                Console.WriteLine("Enter member " + i);

                string member = Console.ReadLine();

                arr[i] = member;
            }


            Console.WriteLine("Here is the string below created with elements of the above array :");

            string output = string.Join(",", arr);

            Console.WriteLine(output);
        }

    }

    public void Exercise14()
    {
        throw new NotImplementedException();
    }

    public void Exercise15()
    {
        List<string> files = new List<string>()
            {
                "aaa.frx",
                "bbb.TXT",
                "xyz.dbf",
                "abc.pdf",
                "aaaa.PDF",
                "xyz.frt",
                "abc.xml",
                "ccc.txt",
                "zzz.txt"
            };

        var extensions = files.Select(s =>
          {
              var splitted = s.Split(new char[] { '.' });
              return splitted[splitted.Length - 1].ToUpper();
          }
         ).ToList();

        var distinctExtensions = extensions.Distinct().ToList();

        distinctExtensions.ForEach(ext =>
        Console.WriteLine($"number of extension {ext} is {extensions.Count(e => e == ext)}")
        );
    }

    public void Exercise16()
    {
        throw new NotImplementedException();
    }

    public void Exercise17()
    {
        List<char> chars = new List<char>()
            {
                'a',
                'b',
                'c',
                'd',
                'a'
            };

        chars.Remove('a');

        chars.ForEach(ch => Console.Write(ch));
    }

    public void Exercise18()
    {
        throw new NotImplementedException();
    }

    public void Exercise19()
    {
        throw new NotImplementedException();
    }

    public void Exercise2()
    {
        Random random = new Random();

        List<int> randomNumbers = new List<int>();

        foreach (var item in Enumerable.Range(0, 10))
        {
            randomNumbers.Add(random.Next(-20, 20));
        }

        List<int> resultList = randomNumbers.Where(n => n > 0 && n < 12).ToList();

        foreach (var item in resultList)
        {
            Console.Write(item + " ");
        }
    }

    public void Exercise20()
    {
        throw new NotImplementedException();
    }

    public void Exercise21()
    {
        List<char> chars = new List<char>()
            {
                'a',
                'b',
                'c',
                'd',
                'a'
            };

        chars.RemoveRange(2, 3);

        chars.ForEach(ch => Console.Write(ch));
    }

    public void Exercise22()
    {
        List<string> strList = new List<string>()
            {
                "bir",
                "iki",
                "osman",
                "edipcan",
                "oktay"
            };

        var zort = strList.Where(str => str.Length > 5).ToList();

        zort.ForEach(str => Console.WriteLine(str));
    }

    public void Exercise23()
    {

    }

    public void Exercise24()
    {
        throw new NotImplementedException();
    }

    public void Exercise25()
    {
        throw new NotImplementedException();
    }

    public void Exercise26()
    {
        throw new NotImplementedException();
    }

    public void Exercise27()
    {
        throw new NotImplementedException();
    }

    public void Exercise28()
    {
        List<string> list = new List<string>()
            {
                "ROME"      ,
                "PARIS"     ,
                "LONDON"    ,
                "ZURICH"    ,
                "Şikagon",
                "NAIROBI"   ,
                "ABU DHABI" ,
                "AMSTERDAM" ,
                "NEW DELHI" ,
                "CALIFORNIA",
                "Edipcan"
            };

        list = list.OrderBy(str => str.Length).ThenBy(st => st).ToList();

        list.ForEach(str => Console.WriteLine(str));
    }

    public void Exercise29()
    {
        throw new NotImplementedException();
    }

    public void Exercise3()
    {
        Random random = new Random();

        List<int> randomNumbers = new List<int>();

        foreach (var item in Enumerable.Range(0, 10))
        {
            randomNumbers.Add(random.Next(0, 20));
        }

        var result = randomNumbers.Select(n => $"num: {n} sqr: {n * n}");

        foreach (var item in result)
        {
            Console.WriteLine(item.ToString());
        }

    }

    public void Exercise30()
    {
        List<string> list = new List<string>()
            {
                "Biscuit",
                "Brade",
                "Butter",
                "Honey",
                "Biscuit",
                "Brade",
                "Butter",
                "Honey"
            };

        list = list.Distinct().ToList();

        list.Sort();

        list.ForEach(str => Console.WriteLine(str));
    }

    public void Exercise4()
    {
        Random random = new Random();

        List<int> randomNumbers = new List<int>();

        foreach (var item in Enumerable.Range(0, 20))
        {
            randomNumbers.Add(random.Next(0, 20));
        }

        var result = randomNumbers.
            Distinct().
            Select(n => $"num: {n} apeears {randomNumbers.Count(num => num == n)} times");

        randomNumbers.Sort();
        foreach (var num in randomNumbers)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
        foreach (var item in result)
        {
            Console.WriteLine(item.ToString());
        }
    }

    public void Exercise5()
    {
        Random random = new Random();

        List<char> randomNumbers = new List<char>();

        foreach (var item in Enumerable.Range(0, 20))
        {
            randomNumbers.Add((char)random.Next('a', 'z'));
        }

        var result = randomNumbers.
            Distinct().
            Select(n => $"num: {n} apeears {randomNumbers.Count(num => num == n)} times");

        randomNumbers.Sort();
        foreach (var num in randomNumbers)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
        foreach (var item in result)
        {
            Console.WriteLine(item.ToString());
        }
    }

    public void Exercise6()
    {
        IEnumerable<string> daysOfTheWeek = new string[]
        {
                "Sunday",
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday"
        };

        foreach (var day in daysOfTheWeek)
        {
            Console.WriteLine(day);
        }
    }

    public void Exercise7()
    {
        Random random = new Random();

        List<int> randomNumbers = new List<int>();

        foreach (var item in Enumerable.Range(0, 20))
        {
            randomNumbers.Add(random.Next(0, 20));
        }

        var result = randomNumbers.
            Distinct().
            Select(n => $"{n} {randomNumbers.Count(num => num == n) * n} {randomNumbers.Count(num => num == n)}");

        randomNumbers.Sort();
        foreach (var num in randomNumbers)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
        foreach (var item in result)
        {
            Console.WriteLine(item.ToString());
        }
    }

    public void Exercise8()
    {
        while (true)
        {

            string[] cities = new string[]
            {
                    "ROME","LONDON","NAIROBI","CALIFORNIA","ZURICH","NEW DELHI","AMSTERDAM","ABU DHABI","PARIS"
            };


            Console.WriteLine("Enter starting char");
            string startingChar = Console.ReadLine();

            Console.WriteLine("Enter ending char");
            string endingChar = Console.ReadLine();

            if (startingChar.Length != 1 || endingChar.Length != 1)
            {
                Console.WriteLine("Error with given input");
                continue;
            }
        }
    }

    public void Exercise9()
    {
        List<int> numbers = new List<int>()
            {
                55 ,200 ,740 ,76 ,230 ,482, 95
            };

        Console.WriteLine("Numbers are: ");
        numbers.ForEach(n => Console.WriteLine(n));

        var numbersGreaterThan80 = numbers.Where(n => n > 80).ToList();

        Console.WriteLine("Numbers greater than 80 are: ");
        numbersGreaterThan80.ForEach(n => Console.WriteLine(n));
    }
}
