Console.WriteLine("Please enter a start number(1-99)");
int startNum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please enter an end number(startNum-99)");
int endNum = Convert.ToInt32(Console.ReadLine());

int zaps = 0;
int firstNumber;
int lastNumber;

for (int i = startNum; i <= endNum; i++)
{
    firstNumber = i / 10;
    lastNumber = i % 10;

    if (firstNumber + lastNumber == 10 && i >= 10)
    {
        Console.WriteLine("zap");
        zaps++;
    }
    else if (i % 2 == 0 && i % 7 == 0)
    {
        Console.WriteLine("pingpong");
    }
    else if (i % 2 == 0)
    {
        Console.WriteLine("ping");
    }
    else if (i % 7 == 0)
    {
        Console.WriteLine("pong");
    }
    else
    {
        Console.WriteLine($"{i}");
    }
}

Console.WriteLine($"Zaps: {zaps}");