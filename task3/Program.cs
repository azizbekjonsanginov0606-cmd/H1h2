// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using task3;
Student[] students = new Student[]
        {
            new Student
            {
                Name = "Shahrom Sharipov",
                GradeLevel = 9,
                TestScores = new int[] { 75, 80, 85, 100 }
            },
            new Student
            {
                Name = "Abdulloh Abdulloev",
                GradeLevel = 10,
                TestScores = new int[] { 70, 75, 80, 100 }
            },
            new Student
            {
                Name = "Nurullo Sulaymonov",
                GradeLevel = 11,
                TestScores = new int[] { 95, 98, 92, 100 }
            },
            new Student
            {
                Name = "Alijoni Zabiri",
                GradeLevel = 12,
                TestScores = new int[] { 95, 90, 92, 100 }
            },
            new Student
            {
                Name = "Olimjon Tojiev",
                GradeLevel = 9,
                TestScores = new int[] { 80, 85, 90, 100 }
            }
        };

foreach (Student student in students)
{
    double average = student.GetAverage();

    if (average > 85)
    {
        Console.WriteLine(
            $"Congratulations {student.Name} on achieving above average scores ({average:F1}) in grade {student.GradeLevel}!");
        Console.WriteLine("Keep up the good work!");
    }
    else if (average < 70)
    {
        Console.WriteLine(
            $"{student.Name}, if you're having difficulties with your studies, don't hesitate to");
        Console.WriteLine(
            $"seek help. Your current average score is ({average:F1}) in grade {student.GradeLevel}.");
    }
    else
    {
        Console.WriteLine(
            $"Congratulations {student.Name} on achieving an average score of ({average:F1}) in grade {student.GradeLevel}!");
        Console.WriteLine("Keep working hard for even better results!");
    }

    Console.WriteLine(new string('-', 48));
}