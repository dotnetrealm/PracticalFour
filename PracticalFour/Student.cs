namespace PracticalFour
{
    enum Options
    {
        Aggregate = 1,
        MinMark = 2,
        MaximumMark = 3,
        Grade = 4
    };
    public class Student
    {
        
        public string Name = default!;
        public decimal[] Marks = new decimal[5];

        public static decimal AverageMarks;

        public decimal CalculateAverageMarks()
        {
            return (Marks.Sum() / Marks.Length);
        }

        public string CalculateGrade(decimal marks) => marks switch
        {
            > 90 => "A",
            > 80 => "B",
            > 70 => "C",
            < 70 => "D",
            _ => throw new ArgumentOutOfRangeException(nameof(marks))
        };
    }
}
