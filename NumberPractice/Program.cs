using System.Security.Cryptography.X509Certificates;

const string MENU = """
********************************
* Number Tools *
* *
* A - Divisor checker *
* B - Digit-izer *
* C - Palindrome checker *
* Q - Quit *
********************************
""";

bool hasquit = false;
string result = "";

while (!hasquit) {
    Console.Clear();
    Console.WriteLine(MENU);
    Console.WriteLine(result);
    Console.WriteLine();

    Console.WriteLine("Enter your selection: ");
    string menuSelection = Console.ReadLine();
    string selection = menuSelection.ToUpper();

    int number;
    int divisor;

    switch (selection)
    {
        case "A":
            Console.WriteLine("Please enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter a divisor: ");
            divisor = Convert.ToInt32(Console.ReadLine());

            if(number % divisor == 0)
            {
                result = $"{number} is divisible by {divisor}";
            }
            else
            {
                result = $"{number} is not divisible by {divisor}";
            }
            break;

        case "B":
            Console.WriteLine("Please enter a number greater than 0");
            number = Convert.ToInt32(Console.ReadLine());

            if (number < 0)
            {
                Console.WriteLine("Please enter a number that is zero or more");
            }
            else
            {
                string digits = "";

                if (number == 0)
                {
                    digits = "0";
                }
                else
                {
                    while (number > 0)
                    {
                        int digit = number % 10;

                        digits = $"{digit} {digits}";

                        number = number / 10;
                    }
                }

                result = $"{digits.Trim()}";
            }
            break;

        case "C":
            Console.WriteLine("Please enter a number greater than 0");
            number = Convert.ToInt32(Console.ReadLine());

            int originalNumber = number;
            int reversedNumber = 0;

            while (number > 0)
            {
            int digit = number % 10;

            reversedNumber = reversedNumber * 10 + digit;

            number = number / 10;
            }

            if (originalNumber == reversedNumber)
            {
                result = $"{originalNumber} is a palindrome.";
            }
            else
            {
                result = $"{originalNumber} is not a palindrome.";
            }
            break;

        case "Q":
            hasquit = true;
            break;
    }
}
Console.WriteLine("Goodbye!");