using System.Linq.Expressions;

const double overCharge = 1.25;
const double passPrice = 12.00;
const int freeRideTime = 15;

double finalCost;
int blocks = 0;
int remainder = 0;

Console.WriteLine("Please provide the ride time in minutes(1-720)");
int rideTime = Convert.ToInt32(Console.ReadLine());

if (rideTime > freeRideTime)
{
    int minutesOver = rideTime - freeRideTime;
    blocks = minutesOver / 30;
    remainder = minutesOver % 30;
}

finalCost = (blocks * overCharge) + (remainder * overCharge);

Console.WriteLine($"Ride Length: {rideTime}");
Console.WriteLine($"Blocks Charged: {blocks + remainder}");

if(finalCost > passPrice)
{
    Console.WriteLine($"Cost: {finalCost}(day pass price)");
}
else
{
    Console.WriteLine($"Cost: {finalCost}");
}