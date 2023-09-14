// Ask the user for his age
Console.Write("Please enter your age: "); 
int age = int.Parse(Console.ReadLine());

// Determine age group: 
/* Print one of these statements (the correct one):
You are an adult
You are a child
You are a teenager */

string ageGroup;
if (age >= 18)
{
    ageGroup = "adult";
}
else if (age >= 13)
{
    ageGroup = "teenager";
}
else
{
    ageGroup = "child";
}

Console.WriteLine("the end");


// Ask the user for another integer
Console.Write("Please enter another integer: ");
int secondNumber = int.Parse(Console.ReadLine());

// Compare the two numbers and find the greater one
int greaterNumber;

if (age > secondNumber)
{
    greaterNumber = age;
}
else
{
    greaterNumber = secondNumber;
}

//(Tell him, which is the greater number, the number just given, or his age

string evenOrOdd = (greaterNumber % 2 == 0) ? "even" : "odd";

// Print the results
Console.WriteLine($"You are a {ageGroup}");
Console.WriteLine($"The greater number between {age} and {secondNumber} is {greaterNumber}");
Console.WriteLine($"The greater number is {evenOrOdd}.");

Console.ReadLine(); 
// result



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






