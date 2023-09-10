namespace Iths_csharp_uppgifter_del3_metoder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EvenOrOdd(7);
            EvenOrOdd(10);
            DetermineAgeBracket(7);
            DetermineAgeBracket(-9);
            DetermineAgeBracket(13);
            DetermineAgeBracket(47);
            DetermineAgeBracket(147);
            AssignGrade(7);
            AssignGrade(67);
            AssignGrade(77);
            AssignGrade(87);
            AssignGrade(97);
            AssignGrade(107);
            Console.WriteLine("Max är " + FindMax(9, 12, 7));
            GetMaxOfThree(99, 77, 107);
            CheckNumberType(0);
            CheckNumberType(-9);
            CheckNumberType(90);
            DetermineNumberType(0);
            DetermineNumberType(-10);
            DetermineNumberType(110);

            double discount = CalculateDiscount(4000, 50);
            Console.WriteLine("Rabatten blir " + discount);

            GetDiscountedAmount(5000, 10);

            PrintDayOfWeek(1);
            PrintDayOfWeek(2);
            PrintDayOfWeek(3);
            PrintDayOfWeek(4);
            PrintDayOfWeek(5);
            PrintDayOfWeek(6);
            PrintDayOfWeek(7);
            PrintDayOfWeek(10);

            Console.WriteLine(IsValidPassword("123abc"));
            Console.WriteLine(IsValidPassword("abc123"));

            CheckPassword("123abc");
            CheckPassword("abc123");

            PerformTemperatureConversion(111, true);
            PerformTemperatureConversion(111, false);



            Console.ReadKey();
        }

        static void EvenOrOdd(int number)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine(number + " is even.");
            }
            else
            {
                Console.WriteLine(number + " is odd.");
            }
        }

        static void DetermineAgeBracket(int age)
        {
            if ((age < 13) && (age > 0))
            {
                Console.WriteLine("You are a child!");
            }
            else if ((age >= 13) && (age < 19))
            {
                Console.WriteLine("You are a teenager!");
            }
            else if ((age >= 19) && (age < 125))
            {
                Console.WriteLine("You are an adult!");
            }
            else
            {
                Console.WriteLine("You are probably not human...");
            }
        }

        static void AssignGrade(int score)
        {
            if ((score < 60))
            {
                Console.WriteLine($"You got {score} points and your grade is F");
            }
            else if (score <= 69)
            {
                Console.WriteLine($"You got {score} points and your grade is D");
            }
            else if (score <= 79)
            {
                Console.WriteLine($"You got {score} points and your grade is C");
            }
            else if (score <= 89)
            {
                Console.WriteLine($"You got {score} points and your grade is B");
            }
            else if (score <= 100)
            {
                Console.WriteLine($"You got {score} points and your grade is A");
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }
        static int FindMax(int a, int b, int c)
        {
            int max;

            if ((a > b || a == b) && (b > c || b == c))
            {
                max = a;
            }
            else if ((b > a || b == a) && (b > c || b == c))
            {
                max = b;
            }
            else
            {
                max = c;
            }

            return max;
        }

        static void GetMaxOfThree(int a, int b, int c)
        {
            int max = FindMax(a, b, c);
            Console.WriteLine("Max is " + max);
        }

        static void CheckNumberType(int tal)
        {
            if (tal == 0)
            {
                Console.WriteLine($"{tal} is zero!");
            }
            else if (tal > 1)
            {
                Console.WriteLine($"{tal} is positive!");
            }
            else
            {
                Console.WriteLine($"{tal} is negative!");
            }
        }

        static void DetermineNumberType(int tal)
        {
            CheckNumberType(tal);
        }

        static double CalculateDiscount(double amount, double discountInProcent)
        {
            double discount = amount * (discountInProcent / 100);
            return discount;
        }

        static void GetDiscountedAmount(double amount, double discountInProcent)
        {
            double finalAmount = amount - CalculateDiscount(amount, discountInProcent);
            Console.WriteLine("Final amount after discount is: " + finalAmount);
        }

        static string GetDayOfWeek(int dayNumber)
        {
            string day;
            switch (dayNumber)
            {
                case 1:
                    day = "Monday";
                    break;
                case 2:
                    day = "Tuesday";
                    break;
                case 3:
                    day = "Wednesday";
                    break;
                case 4:
                    day = "Thursday";
                    break;
                case 5:
                    day = "Friday";
                    break;
                case 6:
                    day = "Saturday";
                    break;
                case 7:
                    day = "Sunday";
                    break;
                default:
                    day = "Error! Pick a nomber between 1 and 7!";
                    break;
            }

            return day;
        }

        static void PrintDayOfWeek(int dayNumber)
        {
            string day = GetDayOfWeek(dayNumber);
            Console.WriteLine("Today is: " + day + "!");
        }

        static bool IsValidPassword(string password)
        {
            string thePassword = "abc123";
            bool isValidPassword = (thePassword == password);
            return isValidPassword;
        }

        static void CheckPassword(string password)
        {
            if (IsValidPassword(password))
            {
                Console.WriteLine("Access granted!");
            }
            else
            {
                Console.WriteLine("Access denied!");
            }
        }

        static double ConvertToTemperature(double temperature, bool toCelsius)
        {
            double temperatureValue;

            if (toCelsius)
            {
                temperatureValue = ((temperature - 32) * 5) / 9;
            }
            else
            {
                temperatureValue = ((temperature * 9) / 5) + 32;
            }

            return temperatureValue;
        }

        static void PerformTemperatureConversion(double temperature, bool toCelcius)
        {
            double temperatureValue = ConvertToTemperature(temperature, toCelcius);
            Console.WriteLine("The converted temperature is: " + temperatureValue);
        }
    }
}