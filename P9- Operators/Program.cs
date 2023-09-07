// See https://aka.ms/new-console-template for more information

// Exercise 1: 
Console.WriteLine("speed in kilometerPerHour:");
double KilometerPerHour = double.Parse(Console.ReadLine());
double meterPerSec = KilometerPerHour * 1000 / 60 *60;
Console.WriteLine($"Speed in meterPerSec");


// Exercise 2:
Console.WriteLine("minutes");
int Input = int.Parse(Console.ReadLine());
int result = Input;
int minutes = 60;
minutes = minutes * 60;
Console.WriteLine($"{minutes} minutes = {minutes * 60} seconds");


// Exercise 10: 
Console.WriteLine("Give me a number of seconds");

int seconds = Convert.ToInt32(Console.ReadLine());
double d = Convert.ToDouble(seconds);
float totalDays = (float) seconds / (24 * 3500);

int days = seconds / (24 * 3600);
seconds = seconds % (24 * 3600);

int hours = seconds / 3600;
seconds = seconds % 3600;

minutes = seconds / 60;
seconds = seconds % 60; 

Console.WriteLine($"seconds: {seconds}");
Console.WriteLine($"minutes: {minutes}");
Console.WriteLine($"hours: {hours}");
Console.WriteLine($"days: {days}");

Console.WriteLine($"{days}.{hours}:{minutes}:{seconds}");

Console.WriteLine($"In total, that's {totalDays} Days.");

// Group exercise: 
Console.WriteLine("?");
string a = Console.ReadLine();
float b = float.Parse(a);

Console.WriteLine("?");


    









          
