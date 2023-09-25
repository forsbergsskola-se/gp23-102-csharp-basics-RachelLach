// P11_1Grades
// Create a program that takes a numerical grade
//as input from the user and then displays a letter grade
// (A,B,C,D or F) based on the following scale: 
//A:90-100
//B:80-89
//C:70-79
//D:60-69
//E:<60
// Input:90
//Output:A

int grade = 50 - 100;
Console.WriteLine("Enter a number from 50 - 100:");
string userInput = Console.ReadLine();
int number = int.Parse(userInput);
bool gradenumber = number >60;
Console.WriteLine(gradenumber);
number = int.Parse(Console.ReadLine());

number = number <60 || number =100;;

if (number <= 100 || 90 <= number);
Console.WriteLine("{A}");

if else (number >= 80 && number < 90) 
{
Console.WriteLine("{B}");  
}
else if (number >= 70 && number < 80)
{ 
Console.WriteLine("{C}");
}
else if (number >= 60 && number < 70)
{
Console.WriteLine("{D}");
}
else if (number <60)
{
Console.WriteLine("{E}");
}


