using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Person
{
    public string? Name { get; set; }
    public string? Age { get; set; }
    public void Talk(string text)
    {
        Console.WriteLine($"{Name} is {Age} years old, is saying {text}.");
    }
}

