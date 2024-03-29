
using racing_program.Classes;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.Serialization.Json;
using System.Security.Cryptography.X509Certificates;

//drivers
Driver verstappen = new Driver("Verstappen", 25);
Driver alonso = new Driver("Alonso", 23);
Driver russell = new Driver("Russell", 24);
Driver sainz = new Driver("Sainz", 24);
Driver perez = new Driver("Perez", 23);
Driver bearman = new Driver("Bearman", 21);
Driver norris = new Driver("Norris", 22);

//teams
F1_car redBull = new F1_car("RedBull", 349);
F1_car astonMartin = new F1_car("Aston Martin", 327);
F1_car mercedes = new F1_car("Mercedes", 334);
F1_car ferrari = new F1_car("Ferrari", 341);
F1_car mcLaren = new F1_car("McLaren", 332);

//drivers list
Driver[] driversListing = new Driver[7];
driversListing[0] = verstappen;
driversListing[1] = alonso;
driversListing[2] = russell;
driversListing[3] = sainz;
driversListing[4] = perez;
driversListing[5] = bearman;
driversListing[6] = norris;

//teams list
F1_car[] carsListing = new F1_car[5];
carsListing[0] = redBull;
carsListing[1] = astonMartin;
carsListing[2] = mercedes;
carsListing[3] = ferrari;
carsListing[4] = mcLaren;

Driver[] driversRacing = new Driver[2];
F1_car[] carsRacing = new F1_car[2];

//iteration
for (int i = 0; i < driversRacing.Length; i++)
{
    bool correctData = true;
    while(correctData)
    {
        Console.WriteLine($"Driver&car no.{i + 1}");
        Console.WriteLine($"Please choose driver no.{i + 1} for the sprint race:");
        foreach (var driver in driversListing)
        {
            Console.WriteLine(driver.Name);
        }
        Console.Write("Please enter drivers name: ");
        string insertName = Console.ReadLine();
        bool checkDriver = false;

        foreach (var driver in driversListing)
        {
            if (driver.Name.ToLower() == insertName.ToLower())
            {
                checkDriver = true;
                driversRacing[i] = driver;
                correctData = false;
                break;
            }
        }
        if (checkDriver)
        {
            Console.WriteLine($"The driver is {driversRacing[i].Name} and has {driversRacing[i].Skill} driving skill");
            Console.WriteLine($"Driver no.{i + 1} is checked for the sprint - {checkDriver}");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Your inserted driver was not found");
            Console.WriteLine($"Driver is checked for the sprint - {checkDriver}");
            Console.ReadLine();
            correctData = true;
            continue;
        }

        Console.WriteLine($"Please choose car no.{i + 1} for the sprint race");
        foreach (var car in carsListing)
        {
            Console.WriteLine(car.Team);
        }
        Console.Write("Please enter team name: ");
        string insertCar = Console.ReadLine();
        bool checkCar = false;

        foreach (var car in carsListing)
        {
            if (car.Team.ToLower() == insertCar.ToLower())
            {
                checkCar = true;
                carsRacing[i] = car;
                correctData = false;
                break;
            }
        }
        if (checkCar)
        {
            Console.WriteLine($"The speed of F1 car is {carsRacing[i].Speed}km/h for {carsRacing[i].Team} racing team");
            Console.WriteLine($"The car is checked for the race - {checkCar}");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Your inserted F1 team was not found");
            Console.WriteLine($"Car is checked for the race - {checkCar}");
            correctData = true;
            Console.ReadLine();
        }
    }
}

//time&date
DateTime currentDateTime = DateTime.Now;
string datetimetoShow = string.Format("The sprint has been started at {0:t}, on {0:dd-MM-yyyy}", currentDateTime);
Console.WriteLine(datetimetoShow);
Console.ReadLine();

//values
int ckDriver1 = driversRacing[0].Skill * carsRacing[0].Speed;
Console.WriteLine($"{driversRacing[0].Name} has the sprint race result {ckDriver1}");//only for check
int ckDriver2 = driversRacing[1].Skill * carsRacing[1].Speed;
Console.WriteLine($"{driversRacing[1].Name} has the sprint race result {ckDriver2}");//only for check
Console.ReadLine();

//method
static void F1SprintRace(Driver[] driversRacing, F1_car[] carsRacing, int ckDriver1, int ckDriver2)
{
    if (ckDriver1 > ckDriver2)
    {
        Console.WriteLine($"The driver {driversRacing[0].Name} for {carsRacing[0].Team} racing team has won the race");
    }
    else if (ckDriver1 < ckDriver2)
    {
        Console.WriteLine($"The driver {driversRacing[1].Name} for {carsRacing[1].Team} racing team has won the race");
    }
    else
    {
        Console.WriteLine("The drivers are draw");
    }
}

//call
F1SprintRace(driversRacing, carsRacing, ckDriver1, ckDriver2);
Console.ReadLine();
