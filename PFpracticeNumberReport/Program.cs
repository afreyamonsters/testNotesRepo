const int MIN_NUMBER = 1;
const int MAX_NUMBER = 100;
const int CHECK_DIVISOR = 3;
int start;
int end;

Console.Write($"Start number ({MIN_NUMBER} to {MAX_NUMBER}): ");
    while (!int.TryParse(Console.ReadLine(), out start) || start < MIN_NUMBER || start > MAX_NUMBER)
    {
    Console.WriteLine($"That isn't a whole number from {MIN_NUMBER} to {MAX_NUMBER}. Try again.");
    Console.Write($"Start number ({MIN_NUMBER} to {MAX_NUMBER}): ");
    }
Console.Write($"End number ({start} to {MAX_NUMBER}): ");
    while (!int.TryParse(Console.ReadLine(), out end) || end < start || end > MAX_NUMBER)
    {
    Console.WriteLine($"That isn't a whole number from {start} to {MAX_NUMBER}. Try again.");
    Console.Write($"End number ({start} to {MAX_NUMBER}): ");
    }
int evenCount = 0;
int oddCount = 0;
int multipleOfThreeCount = 0;
int sum = 0;
    for (int number = start; number <= end; number++)
    {
    if (number % 2 == 0)
    {
    evenCount++;
    }
    else
    {
    oddCount++;
    }
    if (number % CHECK_DIVISOR == 0)
    {
    multipleOfThreeCount++;
    }
    sum += number;
    }
    
string report = $"Report for {start} to {end}:\n";
report += $"Evens: {evenCount}\n";
report += $"Odds: {oddCount}\n";
report += $"Multiples of {CHECK_DIVISOR}: {multipleOfThreeCount}\n";
report += $"Sum: {sum}";
Console.WriteLine(report);