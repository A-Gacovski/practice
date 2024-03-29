//Objects

Console.WriteLine("Enter dogs name: ");
string dogName = Console.ReadLine();

Console.WriteLine("Enter dogs race: ");
string dogRace = Console.ReadLine();

Console.WriteLine("Enter dogs color: ");
string dogColor = Console.ReadLine();

Dog dog = new Dog()
{
    Name = dogName,
    Race = dogRace,
    Color = dogColor
};

while (true)
{
    Console.WriteLine("Choose one of the actions:" +
                        "\n if You want dog to eat write - eat" +
                        "\n if you want dog to play write - play" +
                        "\n if you want dog to chase it's tail write - chase");
    string userInput = Console.ReadLine();
    switch (userInput)
    {
        case "eat":
            Console.WriteLine(dog.Eat());
            break;
        case "play":
            Console.WriteLine(dog.Play());
            break;
        case "chase":
            Console.WriteLine(dog.ChaseTail());
            break;
        case "quit":
            return;
        default:
            Console.WriteLine("Incorrect input. Please chose one of the actions!!");
            break;
    }
}

