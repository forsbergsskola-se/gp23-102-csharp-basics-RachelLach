Random random = new Random();
int myNumber = random.Next(1, 101);

Console.WriteLine("Welcome to the Number Guessing Game!");
Console.WriteLine("I'm thinking of a number between 1 and 100.");
Console.WriteLine("Try to guess it!");
Console.Write("Enter your guess: ");
int guess = int.Parse(Console.ReadLine());
if (guess < myNumber)
{
    Console.WriteLine("Guess higher!");
}
else if (guess > myNumber)
{
    Console.WriteLine("Guess lower!");
}
else
{
    Console.WriteLine("Congratulations! You guessed the number correctly. You win!");
}

    
// P13-1Dollars
Console.Write("How many Dollars do you want? Enter a number: ");
if (int.TryParse(Console.ReadLine(), out int dollarCount) && dollarCount >= 0)
    Console.WriteLine(new string('$', dollarCount));
else
    Console.WriteLine("Please enter a non-negative number.");


