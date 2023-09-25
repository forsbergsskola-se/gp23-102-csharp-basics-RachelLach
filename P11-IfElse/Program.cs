// Ask the user for his age

using System.ComponentModel.Design;

Console.Write("Please enter your age: ");
string ageInput = Console.ReadLine();
int age = int.Parse(ageInput);

// Determine age group: 
/* Print one of these statements (the correct one):
You are an adult
You are a child
You are a teenager */

string ageGroup;
if (age < 13)
{
    Console.WriteLine("you are a child.");
}
else if (age >= 19)
{
    Console.WriteLine("you are an adult.");
}
else
{
    Console.WriteLine("you are a teenager");
}


// Ask the user for another integer
Console.Write("Please enter another integer: ");
string numberInput = Console.ReadLine();
int number = int.Parse(numberInput);
var max = number > age ? number : age;
Console.WriteLine($"The maximum is {max}.");
if (max % 2 == 0)
{
    Console.WriteLine("It's an even number.");
}
else
{
    Console.WriteLine("It's an odd number.");  
}


//P11-1Grades

Console.Write("Enter your numerical grade: ");
int numericalGrade = int.Parse(Console.ReadLine());

string letterGrade;

if (numericalGrade >= 90 && numericalGrade <= 100)
{
    letterGrade = "A";
}
else if (numericalGrade >= 80 && numericalGrade < 90)
{
    letterGrade = "B";
}
else if (numericalGrade >= 70 && numericalGrade < 80)
{
    letterGrade = "C";
}
else if (numericalGrade >= 60 && numericalGrade < 70)
{
    letterGrade = "D";
}
else
{
    letterGrade ="E";
}

Console.WriteLine($"Your letter grade is: {letterGrade}");

Console.ReadLine(); // Pause to see the result

Random random = new Random();
Console.WriteLine(random.NextDouble());






