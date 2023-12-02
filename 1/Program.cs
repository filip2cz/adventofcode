using System.Diagnostics;
using System.Text.RegularExpressions;

string ExampleFilePath = "C:\\Users\\filip\\git\\adventofcode\\1\\example.txt";
string ExampleFilePath2 = "C:\\Users\\filip\\git\\adventofcode\\1\\example2.txt";

string testInputFilePath = "C:\\Users\\filip\\git\\adventofcode\\1\\testinput.txt";

string InputFilePath = "C:\\Users\\filip\\git\\adventofcode\\1\\input.txt";

Console.WriteLine("Which part? [1/2]");
Console.WriteLine("(Part 2 is broken right now)");
string input = Console.ReadLine();

if (input == "1")
{
    Console.WriteLine(FirstPart(InputFilePath));
}
else if (input == "2")
{
    Console.WriteLine(SecondPart(InputFilePath));
}
else
{
    Console.WriteLine("Wrong input");
}

static int FirstPart(string filePath)
{

    string[] input = File.ReadAllLines(filePath);

    string[] onlyNumbers = new string[input.Length];

    int i = 0;
    foreach (string item in input)
    {
        onlyNumbers[i++] = Regex.Replace(item, "[^0-9]", "");
    }

    int output = 0;

    foreach (string item in onlyNumbers)
    {
        output = output + Convert.ToInt16($"{item.Substring(0, 1)}{item[item.Length - 1]}");
    }

    return output;
}
static int SecondPart(string filePath)
{

    string[] input = File.ReadAllLines(filePath);

    string[] numbersWords = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

    /*
    while (x < input.Length)
    {
        i = 0;
        while (i < 10)
        {
            Debug.WriteLine("----------");
            Debug.WriteLine(numbersWords[i]);
            Debug.WriteLine(Convert.ToString(i));
            input[x] = input[x].Replace(numbersWords[i], Convert.ToString(i));
            Debug.WriteLine(input[x]);
            Debug.WriteLine("----------");
            i++;
        }
        x++;
    }
    */

    int i;
    int x = 0;
    string item;
    int z = 0;
    string workItem;
    // x je kolikátej řádek aktuálně dělám
    // i je kolikáte číslo aktuálně kontroluji
    // z je kolik znaků už jsem přidal ke kontrole
    while (x < input.Length)
    {
        item = input[x];
        workItem = string.Empty;
        while (z < input[x].Length)
        {
            workItem = $"{workItem}{item[z]}";
            i = 0;
            while (i < 10)
            {
                if (workItem != workItem.Replace(numbersWords[i], Convert.ToString(i)))
                {
                    workItem = workItem.Replace(numbersWords[i], Convert.ToString(i));
                    Debug.WriteLine(workItem);
                }
                i++;
            }
            z++;
        }

        input[x] = workItem;

        z = 0;
        x++;

        Debug.WriteLine("----------");
    }

    foreach (string thing in input)
    {
        Debug.WriteLine(thing);
    }

    Debug.WriteLine("---------------");

    string[] onlyNumbers = new string[input.Length];

    i = 0;
    foreach (string thing in input)
    {
        onlyNumbers[i++] = Regex.Replace(thing, "[^0-9]", "");
    }

    foreach (string thing in onlyNumbers)
    {
        Debug.WriteLine(thing);
    }

    Debug.WriteLine("---------------");

    int output = 0;

    i = 0;
    foreach (string thing in onlyNumbers)
    {
        Debug.Write(output);
        i = Convert.ToInt32($"{thing.Substring(0, 1)}{thing[thing.Length - 1]}");
        output = output + i;
        Debug.WriteLine($" + {i} = {output}");
    }

    return output;
}