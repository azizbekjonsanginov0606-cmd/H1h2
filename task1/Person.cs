namespace task1;

public class Person
{
    public string FirstName;

    public string LastName;

    public int Age;

    public string Address;

    public string GetFullName()
    {
        return $"My name is {FirstName} {LastName}";
    }

    public int GetBirthYear()
    {
        return 2026-Age;
    }
}
