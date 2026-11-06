const string MENU = """
******************************
* Practice Test *
* *
* A - Bike Share *
* B - Snap Crackle Pop *
* Q - Quit *
******************************
""";
// Option A
const int MIN_RIDE_MINUTES = 1;
const int MAX_RIDE_MINUTES = 720;
const int FREE_MINUTES = 15;
const int MINUTES_PER_BLOCK = 30;
const decimal BLOCK_PRICE = 1.25m;
const decimal DAY_PASS_PRICE = 12.00m;
// Option B
const int MIN_NUMBER = 1;
const int MAX_NUMBER = 99;
const int SNAP_DIVISOR = 4;
const int CRACKLE_DIVISOR = 6;
bool hasQuit = false;
string result = "";
while (!hasQuit)
{
Console.Clear();
Console.WriteLine(MENU);
Console.WriteLine(result);
Console.WriteLine();
Console.Write("Enter your selection: ");
string selection = Console.ReadLine();
selection = selection.ToUpper();
switch (selection)
{
case "A":
int rideMinutes;
Console.Write($"Ride length in minutes ({MIN_RIDE_MINUTES} to {MAX_RIDE_MINUTES}): ");
while (!int.TryParse(Console.ReadLine(), out rideMinutes) || rideMinutes <
MIN_RIDE_MINUTES || rideMinutes > MAX_RIDE_MINUTES)
{
Console.WriteLine($"That isn't a whole number from {MIN_RIDE_MINUTES} to {MAX_RIDE_MINUTES}. Try again.");
Console.Write($"Ride length in minutes ({MIN_RIDE_MINUTES} to {MAX_RIDE_MINUTES}): ");
}
int blocksCharged = 0;
if (rideMinutes > FREE_MINUTES)
{
int chargedMinutes = rideMinutes - FREE_MINUTES;
blocksCharged = chargedMinutes / MINUTES_PER_BLOCK;
if (chargedMinutes % MINUTES_PER_BLOCK > 0)
{
blocksCharged++;
}
}
decimal rideCost = blocksCharged * BLOCK_PRICE;
string costNote = "";
if (rideCost > DAY_PASS_PRICE)
{
rideCost = DAY_PASS_PRICE;
costNote = " (day pass price)";
}
result = $"Ride length: {rideMinutes} minutes\n";
result += $"Blocks charged: {blocksCharged}\n";
result += $"Cost: {rideCost:C}{costNote}";
break;
case "B":
int startNumber;
int endNumber;
Console.Write($"Start number ({MIN_NUMBER} to {MAX_NUMBER}): ");
while (!int.TryParse(Console.ReadLine(), out startNumber) || startNumber < MIN_NUMBER ||
startNumber > MAX_NUMBER)
{
Console.WriteLine($"That isn't a whole number from {MIN_NUMBER} to {MAX_NUMBER}. Try again.");
Console.Write($"Start number ({MIN_NUMBER} to {MAX_NUMBER}): ");
}
Console.Write($"End number ({startNumber} to {MAX_NUMBER}): ");
while (!int.TryParse(Console.ReadLine(), out endNumber) || endNumber < startNumber ||
endNumber > MAX_NUMBER)
{
Console.WriteLine($"That isn't a whole number from {startNumber} to {MAX_NUMBER}. Try again.");
Console.Write($"End number ({startNumber} to {MAX_NUMBER}): ");
}
string calls = $"Snap Crackle Pop from {startNumber} to {endNumber}:\n";
int popCount = 0;
for (int number = startNumber; number <= endNumber; number++)
{
int tensDigit = number / 10;
int onesDigit = number % 10;
bool isSnap = number % SNAP_DIVISOR == 0;
bool isCrackle = number % CRACKLE_DIVISOR == 0;
// Pop wins over every other rule, so it is checked first.
if (tensDigit == onesDigit)
{
calls += "Pop\n";
popCount++;
}
else if (isSnap && isCrackle)
{
calls += "SnapCrackle\n";
}
else if (isSnap)
{
calls += "Snap\n";
}
else if (isCrackle)
{
calls += "Crackle\n";
}
else
{
calls += $"{number}\n";
}
}
calls += $"Pops: {popCount}";
result = calls;
break;
case "Q":
hasQuit = true;
break;
default:
result = $"{selection} isn't an option. Please choose from the menu.";
break;
}
}
Console.WriteLine("Goodbye!");