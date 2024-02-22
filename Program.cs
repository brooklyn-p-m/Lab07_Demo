char[] grid = new char[100];

int playerX = 0;
int playerY = 0;
char player = '@';

bool restart = false;

Console.Clear();
Console.CursorLeft = 0;
Console.CursorTop = 0;
int counter = 1;
for (int i = 0; i < grid.Length; i++)
{
    grid[i] = '.';
    if (counter % 10 == 0) Console.WriteLine(grid[i]);
    else Console.Write(grid[i]);
    counter++;
}

while (true)
{
    //Printing board
    if (restart)
    {
        Console.Clear();
        Console.CursorLeft = 0;
        Console.CursorTop = 0;
        counter = 1;
        for (int i = 0; i < grid.Length; i++)
        {
            grid[i] = '.';
            if (counter % 10 == 0) Console.WriteLine(grid[i]);
            else Console.Write(grid[i]);
            counter++;
        }
        restart = false;
    }

    //Printing Player
    Console.CursorLeft = playerX;
    Console.CursorTop = playerY;
    Console.Write(player);

    //Get Movement
    ConsoleKeyInfo userInput = Console.ReadKey(true);
    ConsoleKey key = userInput.Key;

    //Perform Movement
    switch (key)
    {
        case ConsoleKey.W:
            Console.CursorLeft = playerX;
            Console.CursorTop = playerY;
            Console.Write("#");
            if (playerY > 0)
                playerY--;
            break;
        case ConsoleKey.S:
            Console.CursorLeft = playerX;
            Console.CursorTop = playerY;
            Console.Write("#");
            if (playerY < 9)
                playerY++;
            break;
        case ConsoleKey.A:
            Console.CursorLeft = playerX;
            Console.CursorTop = playerY;
            Console.Write("#");
            if (playerX > 0)
                playerX--;
            break;
        case ConsoleKey.D:
            Console.CursorLeft = playerX;
            Console.CursorTop = playerY;
            Console.Write("#");
            if (playerX < 9)
                playerX++;
            break;
        case ConsoleKey.Escape:
            restart = true;
            break;
    }


}