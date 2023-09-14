Random random = new Random();
int myNumber = random.Next(1, 101);

Console.WriteLine("Welcome to my first game called Number Guessing. Are you good at guessing?");
Console.WriteLine("I chosed a number between 1 and 100. ");
Console.Write("Are you ready? so guess which number I chosed and enter your number");
int inputGuess = int.Parse(Console.ReadLine());
myNumber = 51;

gussingRound:

if (inputGuess < myNumber)
{
    Console.WriteLine("Guess higher!");
    goto gussingRound;
}
Console.WriteLine("Guess another number");
if (inputGuess > myNumber)
{
    Console.WriteLine("Guess lower!");
    goto gussingRound;
}
else
{
    Console.WriteLine("Congratulations! You guessed the number correctly. You win!");
} 






