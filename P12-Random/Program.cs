//Printing output:
Console.WriteLine("Please pass me a seed (integer):");

// console input && variable && type
int seed = int.Parse(Console.ReadLine());


// more control cause we have a seed
Random random = new Random(seed);

Console.WriteLine("Three integers between 0 and 5:");
int number = random.Next (0, 5);
Console.WriteLine(number);

number = random.Next (0, 5);
Console.WriteLine(number);

number = random.Next (0, 5);
Console.WriteLine(number);

Console.WriteLine("Three numbers between 0.0 and 0.5:");
double secondNumber = random.NextDouble() * 0.5;
number = random.Next();
double secondNnumber = random.NextDouble() * 0.5;
Console.WriteLine(secondNnumber);

secondNnumber = random.NextDouble() * 0.5;
Console.WriteLine(secondNnumber);

secondNnumber = random.NextDouble() * 0.5;
Console.WriteLine(secondNnumber);


Console.WriteLine("Three numbers between 0.2 and 0.7:");
double thirdNumber = random.NextDouble() * 0.5;
thirdNumber= 0.2  + random.NextDouble() * 0.5;
Console.WriteLine(thirdNumber);

thirdNumber= 0.2 + random.NextDouble() * 0.5;
Console.WriteLine(thirdNumber);

thirdNumber= 0.2 + random.NextDouble() * 0.5;
Console.WriteLine(thirdNumber);


Console.WriteLine("Give me a crit chance between 0.0 (0%) and 1.0 (100%):");
double critChance = double.Parse(Console.ReadLine());
critChance = random.NextDouble() * 0.5;
if (random.NextDouble() <= critChance)
{
Console.WriteLine("Crit");
}
else
{
    Console.WriteLine("No Crit");
}

critChance = random.NextDouble() * 0.5;
if (random.NextDouble() <= critChance)
{
    Console.WriteLine("Crit");
}
else
{
    Console.WriteLine("No Crit");
}

critChance = random.NextDouble() * 0.5;
if (random.NextDouble() <= critChance)
{
    Console.WriteLine("Crit");
}
else
{
    Console.WriteLine("No Crit");
}

critChance = random.NextDouble() * 0.5;
if (random.NextDouble() <= critChance)
{
    Console.WriteLine("Crit");
}
else
{
    Console.WriteLine("No Crit");
}


