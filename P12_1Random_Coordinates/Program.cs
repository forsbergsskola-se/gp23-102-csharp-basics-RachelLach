Random random = new Random();
int worldSize = 100;

int enemyX = random.Next(worldSize);
int enemyY = random.Next(worldSize);

Console.WriteLine($"Enemy Coordinates: X:{enemyX} Y:{enemyY}");
Console.ReadLine();

