Random random = new Random();
int myNumber = random.Next(1, 101);

Console.WriteLine("Welcome to my first game called Number Guessing. Are you good at guessing?");
Console.WriteLine("I chose a number between 1 and 100. ");
Console.Write("Are you ready? so guess which number I chose and enter your number");

myNumber = 51;

guessingRound:
int inputGuess = int.Parse(Console.ReadLine());
if (inputGuess < myNumber)
{
    Console.WriteLine("Guess higher!");
    goto guessingRound;
}
Console.WriteLine("Guess another number");
if (inputGuess > myNumber)
{
    Console.WriteLine("Guess lower!");
    goto guessingRound;
}
else
{
    Console.WriteLine("Congratulations! You guessed the number correctly. You win!");
} 






