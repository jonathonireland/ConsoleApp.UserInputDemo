﻿using System.Globalization;

// Declare variables


const int retirementAge = 65;

string? firstName = string.Empty;
string lastName = string.Empty;
int age;
DateOnly dob = new DateOnly();
decimal salary = 0;
char gender;
bool working = false;

Console.Write("Please enter your first name:");
firstName = Console.ReadLine();

Console.Write("Please enter your last name:");
lastName = Console.ReadLine();

Console.Write("Please enter your date of birth (dd/mm/yyyy):");
dob = DateOnly.ParseExact(Console.ReadLine(), "dd/mm/yyyy", CultureInfo.InvariantCulture);

age = DateTime.Now.Year - dob.Year;

Console.Write("Please enter your salary:");
salary = Convert.ToDecimal(Console.ReadLine());

Console.Write("Please enter your gnder (M or F):");
gender = Convert.ToChar(Console.ReadLine());

Console.Write("Are you working? (true or false):");
working = Convert.ToBoolean(Console.ReadLine());

// process the data
int workingYearsRemaining = retirementAge - age;

var estimatedRetirementYear = DateTime.Now.AddYears(workingYearsRemaining);

// Output the results to the user
Console.WriteLine($"Full name: {firstName} {lastName}");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"Your Salary is: {salary.ToString("C")}");
Console.WriteLine($"Your Gender is: {gender}");
Console.WriteLine($"You Are Employed: {working}");
Console.WriteLine($"Number of Working years remaining: {workingYearsRemaining}");
Console.WriteLine($"Estimated Retirement year: {estimatedRetirementYear.Year}");


