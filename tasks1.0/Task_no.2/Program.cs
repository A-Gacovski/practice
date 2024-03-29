//ternary operator

//exercise#1
Console.WriteLine("Please enter no.1");
int numberOne = int.Parse(Console.ReadLine());
string stringOne = $"Number {numberOne} is greater";

Console.WriteLine("Please enter no.2");
int numberTwo = int.Parse(Console.ReadLine());
string stringTwo = $"Number {numberTwo} is greater";

string stringEqual = "Numbers are equal";

string evenNumbers = (numberOne > numberTwo) ? stringOne
                                         : (numberOne < numberTwo) ? stringTwo
                                         : stringEqual;
Console.WriteLine(evenNumbers);
Console.ReadLine();


//exercise#2
while (true)
{
    Console.WriteLine("Please enter a number");
    string strNumber = Console.ReadLine();
    bool numberThree = int.TryParse(strNumber, out int checkNumber);

    if (numberThree)
    {
        bool isTrue = (checkNumber % 2 == 0) ? true : false;
        Console.WriteLine($"It is {isTrue} that the number is even");
    }
    else
    {
        Console.WriteLine("Please enter valid number");
        break;
    }
}





