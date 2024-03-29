//Objects

Student Sime = new Student("Simeon", "FINKI", "F1");
Student Teona = new Student("Teona", "Qinshift", "G3");
Student Alex = new Student("Aleksandar", "Semos", "A1");

Student[] studentList = new Student[3];
studentList[0] = Sime;
studentList[1] = Teona;
studentList[2] = Alex;

while (true)
{
    Console.WriteLine("Please enter student's name:");
    string inputName = Console.ReadLine();

    bool isStudentFound = false;
    Student studentToDisplay = new Student();
    while (true)
    {
        foreach (var student in studentList)
        {
            if (student.Name.ToLower() == inputName.ToLower())
            {
                isStudentFound = true;
                studentToDisplay.Name = student.Name;
                studentToDisplay.Academy = student.Academy;
                studentToDisplay.Group = student.Group;
                break;
            }
        }
        if (isStudentFound)
        {
            Console.WriteLine($"{studentToDisplay.Name}, {studentToDisplay.Academy}, {studentToDisplay.Group}");
            break;
        }
        else
        {
            Console.WriteLine("An error occurred!");
            return;
        }
    }
}
