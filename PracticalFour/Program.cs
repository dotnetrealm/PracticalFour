using PracticalFour;

Student student = new Student();
Console.Write("Enter student name: ");
student.Name = Console.ReadLine()!;
Console.WriteLine();

for (int i = 0; i < 5; i++)
{
    Console.Write($"Enter marks of subject {i + 1}: ");
    while (!Decimal.TryParse(Console.ReadLine(), out student.Marks[i]) || student.Marks[i] > 100 || student.Marks[i] < 0)
    {
        Console.WriteLine("[ERROR]: marks of subject must numberic (range: 0 <= marks <= 100)\n");
        Console.Write($"Enter marks of subject {i + 1}: ");
    }
}
Console.WriteLine();

do
{
    int choice = GetUserChoice();

    string result = choice switch
    {
        (int)Options.Aggregate => student.CalculateAverageMarks().ToString(),
        (int)Options.MinMark => student.Marks.Min().ToString(),
        (int)Options.MaximumMark => student.Marks.Max().ToString(),
        (int)Options.Grade => student.CalculateGrade(student.CalculateAverageMarks()).ToString(),
        _ => "No case found"
    };

    Console.WriteLine($"{(Options)choice} : {result}");
    Console.Write("\nDo you want to repeat again?(y/n): ");
} while (Console.ReadKey().KeyChar.ToString().ToLower() == "y");

Console.ReadLine();

static int GetUserChoice()
{
    Console.WriteLine("\n==========================================================");
    Console.WriteLine("1 - Average marks");
    Console.WriteLine("2 - Displays the minimum mark");
    Console.WriteLine("3 - Displays the maximum mark");
    Console.WriteLine("4 - Displays grade");
    Console.WriteLine("==========================================================");
    Console.Write("Please enter your choice: ");

    short choice = 0;

    while (!Int16.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 4)
    {
        Console.WriteLine("[ERROR]: Invalid choice (range: 1 <= marks <= 4)\n");
        Console.Write("Please enter your choice: ");
    }

    return choice;
}