const double planCost = 35.00;
const int dataAmount = 5000;
const double overCharge = 8.00;
const double billCap = 75.00;

double stillCost = 0;
double blocks = 0;
double bill;

Console.WriteLine("Please enter the amount of data (0MB-20000MB)");
int dataUsed = Convert.ToInt32(Console.ReadLine());

if (dataUsed - dataAmount <= 1000)
{
    stillCost = overCharge;
}
else
{
    blocks = (dataUsed - dataAmount) / 1000.0;
}

bill = planCost + stillCost + (blocks * overCharge);

if (bill > billCap)
{
    bill = billCap;
    Console.WriteLine($"Data Used: {dataUsed} MB");
    Console.WriteLine($"Extra Blocks: {blocks}");
    Console.WriteLine($"Bill: ${bill:F2} (bill cap)");
}
else
{
    Console.WriteLine($"Data Used: {dataUsed} MB");
    Console.WriteLine($"Extra Blocks: {blocks}");
    Console.WriteLine($"Bill: ${bill:F2}");
}