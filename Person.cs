public class Person
{
    public Person(DateOnly dob)
    {
        _age = DateTime.Now.Year - DateOfBirth.Year;
        DateOfBirth = dob;
    }

    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public DateOnly DateOfBirth { get; set; }
    public decimal Salary { get; set; }
    public char Gender { get; set; }
    public bool IsWorking { get; set; }

    private readonly int _age;

    public int GetNumberOfWorkingYearsRemaining()
    {
        return Constants.RetirementAge - _age;
    }

    public DateOnly GetEstimatedRetirementDate()
    {
        return DateOnly.FromDateTime(DateTime.Now.AddYears
            (GetNumberOfWorkingYearsRemaining()));
    }

    public int GetAge()
    {
        return _age;
    }

    public override string ToString()
    {
        return $"{FirstName} {LastName}";
    }

    public static class Constants
    {
        public static int RetirementAge { get; internal set; }
    }
}

