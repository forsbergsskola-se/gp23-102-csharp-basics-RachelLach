using System.Threading.Channels;
using static System.Console;

WriteLine("What is your age?");
string ageInput = ReadLine();
double d = double.Parse(ageInput);

int age = int.Parse(ageInput);
bool ischild = age < 12;
bool isTeenager = age >= 13 && age <= 19; 
bool isAdult = age > 19; 

WriteLine($"you are a child:{ischild}");
WriteLine($"you are a teenager:{isTeenager}");
WriteLine($"You are an adult:{isAdult}");

