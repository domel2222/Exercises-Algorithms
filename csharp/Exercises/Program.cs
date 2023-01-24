// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;

Console.WriteLine("Hello, World!");

string input = "This is a test! String with$ special## characters.";
string output = Regex.Replace(input, "[^a-zA-Z]", "");
Console.WriteLine(output);
