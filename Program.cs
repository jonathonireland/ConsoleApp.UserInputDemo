// Declare variables
string? firstName = string.Empty;
string lastName = string.Empty;
int age;
int retirementAge = 65;
decimal salary = 0;
char gender;
bool working = false;

Console.Write("Please enter your first name:");
firstName = Console.ReadLine();

Console.Write("Please enter your last name:");
lastName = Console.ReadLine();

Console.Write("Please enter your age:");
age = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter your salary:");
salary = Convert.ToDecimal(Console.ReadLine());

Console.Write("Please enter your gnder (M or F):");
gender = Convert.ToChar(Console.ReadLine());

Console.Write("Are you working? (true or false):");
working = Convert.ToBoolean(Console.ReadLine());

// process the data
int workingYearsRemaining = retirementAge - age;

// Output the results to the user
Console.WriteLine($"Full name: {firstName} {lastName}");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"Your Salary is: {salary}");
Console.WriteLine($"Your Gender is: {gender}");
Console.WriteLine($"You Are Employed: {working}");
Console.WriteLine($"Number of Working years remaining: {workingYearsRemaining}");


