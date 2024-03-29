//references

//example#1
int[] integer1 = { 1, 4, 9, 16, 25 };
int[] integer2 = new int[10];

Array.Resize(ref integer1, 8);
Array.Resize(ref integer2, 12);

integer1[7] = 64;
integer2[11] = 144;

Console.WriteLine(integer1[7]);
Console.WriteLine(integer2[11]);

Console.ReadLine();

//example#2
static int Method(ref int refArgument)
{
    return refArgument += 100;
}

static int Method2(int number)
{
    return number += 100;
}

int numberOne = 1;
numberOne = Method2(numberOne);
Console.WriteLine(numberOne);

Console.ReadLine();

int numberTwo = Method(ref numberOne);
Console.WriteLine(numberOne);
Console.WriteLine(numberTwo);

Console.ReadLine();

numberTwo = 10;
Console.WriteLine(numberOne);
Console.WriteLine(numberTwo);


Console.ReadLine();