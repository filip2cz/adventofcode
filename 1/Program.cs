using System.Text.RegularExpressions;

string filePath = "C:\\Users\\filip\\git\\adventofcode\\1\\input.txt";

string[] input = File.ReadAllLines(filePath);

string[] onlyNumbers = new string[input.Length];

int i = 0;
foreach (string thing in input)
{
    onlyNumbers[i++] = Regex.Replace(thing, "[^0-9]", "");
}

int output = 0;

foreach (string thing in onlyNumbers)
{
    output = output + Convert.ToInt16($"{thing.Substring(0, 1)}{thing[thing.Length - 1]}");
}

Console.WriteLine(output);