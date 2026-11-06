// Practice Midterm
// Name: Freya Lane Rumble

const string MENU = """
    ********************************
    *       Practice Midterm       *
    *                              *
    *   A - Meeting Planner        *
    *   B - Tree Growth            *
    *   Q - Quit                   *
    ********************************
    """;

// Put your constants here


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
            // TODO: Option A, Meeting Planner
            const int MAX_LENGTH = 600;     // max meeting length
            const int MIN_PER_HOUR = 60;    // minutes in an hour
            const int HR_PER_DAY = 24;      // hours in a day
            const int CLK_MAX_HR = 23;      // max hour on a 24 hour clock
            const int CLK_MIN_HR = 0;       // min hour on a 24 hour clock
            const int MORNING_END = 12;     // 
            const int AFTERNOON_END = 17;   //
            const int BREAK_AFTER = 90;

            int startHour;
            Console.Write("Enter the meeting start hour(0-23): ");
            while (!int.TryParse(Console.ReadLine(), out startHour) || startHour < CLK_MIN_HR || startHour > CLK_MAX_HR) 
            {
                Console.Write("Enter a valid hour (0-23)");
            }

            int startMin;
            Console.Write("Enter the meeting start Minute(0-59): ");
            while (!int.TryParse(Console.ReadLine(), out startMin) || startMin < 0 || startMin > 59) 
            {
                Console.Write("Enter a valid hour (0-23)");
            } 

            int lengthMin;
            Console.Write("Enter the meeting length, in minutes(1-600): ");
            while (!int.TryParse(Console.ReadLine(), out lengthMin) || lengthMin < 1 || lengthMin > 600) 
            {
            Console.Write("Enter a valid length (1-600)");
            }

            int endHr = (startHour * MIN_PER_HOUR + startMin + lengthMin) / MIN_PER_HOUR;
            int endMin = (startHour * MIN_PER_HOUR + startMin + lengthMin) % MIN_PER_HOUR;

            string nextDay = "";
            if (endHr > CLK_MAX_HR) {
                nextDay = " (next day)";
                endHr %= HR_PER_DAY;
            }

            string tod = "";
                if (endHr < MORNING_END) {
                    tod = "morning";
                } else if (endHr < AFTERNOON_END) {
                    tod = "afternoon";
                } else {
                    tod = "evening";
                }

                result = $"Start: {startHour}:{startMin:D2} {Environment.NewLine}";
                result += $"Length: {lengthMin} minutes{Environment.NewLine}";
                result += $"End: {endHr}:{endMin:D2}{nextDay}, {tod}{Environment.NewLine}";
                if (lengthMin > 90) {
                    result += $"Schedule a beak.{Environment.NewLine}";
                }
                else{ 
            }


        break;
        case "B": {
                const double GROW_RATE = 0.15;
                const double MIN_GROW = 2.0;
                const int MIN_START_HT = 10;
                const int MAX_START_HT = 200;
                const int MAX_HT = 1000;
                
                // ---------------- get user input ----------------------
                int startHeight;
                Console.Write($"Enter the tree's starting height({MIN_START_HT}-{MAX_START_HT}) cm: ");
                while (!int.TryParse(Console.ReadLine(), out startHeight) || startHeight < MIN_START_HT || startHeight > MAX_START_HT) {
                    Console.Write($"Enter a valid whole number from {MIN_START_HT} to {MAX_START_HT}:");
                }

                int targetHeight;
                Console.Write($"Enter the tree's target height({startHeight}-{MAX_HT}) cm: ");
                while (!int.TryParse(Console.ReadLine(), out targetHeight) || targetHeight <= startHeight || targetHeight > MAX_HT) {
                    Console.Write($"A valid target is taller than {startHeight}cm, up to {MAX_HT}cm:");
                }

                // --------------- process input -------------------------

                double currentTreeHeight = startHeight;
                int yrCounter = 0;

                // result string header line
                result = $"Growing from {startHeight} cm to {targetHeight} cm:{Environment.NewLine}";                                                                                                                       

                // sentinal based loop,
                // keep going until tree reaches target hight
                while (currentTreeHeight < targetHeight) {
                    
                    // calculate growth for one year
                    double grow = currentTreeHeight * GROW_RATE;  
                    if (grow < MIN_GROW) {                        
                        grow = MIN_GROW;
                    }

                    currentTreeHeight += grow;
                    yrCounter += 1;

                    // add years growth to result string
                    result += $"Year {yrCounter}: {currentTreeHeight:F1} cm{Environment.NewLine}";
                }

                // add summary to end of result string
                result += $"Years to reach {targetHeight} cm: {yrCounter}{Environment.NewLine}";
            }
            break;
        case "Q":
            hasQuit = true;
            break;
        default:
            result = $"{selection} isn't an option. Please choose from the menu.";
            break;
    }
}

Console.WriteLine("Goodbye");