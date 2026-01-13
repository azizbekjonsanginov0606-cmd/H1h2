namespace task3;

public class Student
{
    public string Name;

    public int GradeLevel;

    public int[] TestScores;

    public double GetAverage()
    {
        int sum = 0;
        foreach (int score in TestScores)
        {
            sum += score;
        }
        return (double)sum / TestScores.Length;
    }
}
