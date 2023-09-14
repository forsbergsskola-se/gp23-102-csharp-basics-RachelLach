// Exercise 1: P09_01SpeedConverter
Console.WriteLine("Converting km/h to m/s");
Console.WriteLine("Write a number in kilometer/hour");
string userInput = Console.ReadLine();
float number = float.Parse(userInput);
float x = number / 60 / 60 * 1000;
Console.WriteLine($"Then {x} m/s.");

// Exercise 2: P09_02MinutesToSeconds
Console.WriteLine("Converting minutes to seconds");
string sec = Console.ReadLine();
int seconds = int.Parse(sec); 
int minutes = seconds / 60 ;
float rest = seconds % 60;
Console.WriteLine($"Minutes: {minutes} Seconds: {rest}" );

// Exercise 3: P09_03Division
Console.WriteLine("Write me a number");
int x1 = int.Parse(Console.ReadLine());
Console.WriteLine("Write me a new number");
int y1 = int.Parse(Console.ReadLine());
float result = (float) x1 / y1;
Console.WriteLine($"The result is {result}");

// Exercise 4: P09_04Remainder
Console.WriteLine("write 2 numbers");
string input1 = Console.ReadLine();
int numberOne = int.Parse(input1);
string input2 = Console.ReadLine();
int numberTwo = int.Parse(input2);
int finalResult = numberOne % numberTwo;
Console.WriteLine($"{finalResult}");

// Exercise 5: P09_05CircleArea
Console.WriteLine("Write a number");
float radius = float.Parse(Console.ReadLine());
double pi = 3.14159265359;
double area = pi * radius * radius;
Console.WriteLine($"{area}");

// Exercise 6: P09_06Negation
Console.WriteLine("Type an input");
string input = Console.ReadLine();
int i = int.Parse(input);
int change = -i;
Console.WriteLine($"{x}");

// Exersice 7: P09_07Product
Console.WriteLine("Type 2 wholenumbers");
string firstInput = Console.ReadLine();
int one = int.Parse(firstInput);
string secondInput = Console.ReadLine();
int two = int.Parse(secondInput);
int theResult = one * two;
Console.WriteLine($"{theResult}");

// Exersice 8: P09_08BMI
Console.WriteLine("What is your weight in kg");
string kilograms = Console.ReadLine();
float kilo = float.Parse(kilograms);
Console.WriteLine("What is your height in meters");
string height = Console.ReadLine();
float h = float.Parse(height);
float BMI = kilo / (h * h);
Console.WriteLine($"{BMI}");

// Exersice 9: P09_09Hypotenuse
Console.WriteLine("Write one length of a side");
string oneSide = Console.ReadLine();
float a = float.Parse(oneSide);
Console.WriteLine("Write the length of the other side");
string anotherSide = Console.ReadLine();
float b = float.Parse(anotherSide);
float final = (a * a) + (b * b);
double tot = Math.Sqrt(final);
Console.WriteLine($"{tot}");

// Exercise 10: P09_10SecondsToMinutes
Console.WriteLine("Give me a number of seconds");
int totalSeconds = int.Parse(Console.ReadLine());
int min = totalSeconds / 60 ;
int second = totalSeconds % 60;
Console.WriteLine($"Minutes: {min} Seconds: {second}" );


//GOAL: 

Console.WriteLine("Give me a number of seconds");

seconds = Convert.ToInt32(Console.ReadLine());
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












          
