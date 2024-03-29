using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Dog
{
    public string? Name { get; set; }
    public string? Race { get; set; }
    public string? Color { get; set; }

    public string Eat()
    {
        string message = $"{Name} bread {Race} has {Color} color and is eating";
        return message;
    }

    public string Play()
    {
        string message = $"{Name} bread {Race} has {Color} color and makes roarr";
        return message;
    }

    public string ChaseTail()
    {
        string message = $"{Name} bread {Race} has {Color} color and is chasing it's tail";
        return message;
    }
}

