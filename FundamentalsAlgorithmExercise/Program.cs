namespace FundamentalsAlgorithmExercise
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Algorithm Practice Menu:");
                Console.WriteLine("1. Print a Tree");
                Console.WriteLine("2. Roman Numerals Conversion");
                Console.WriteLine("3. Fibonacci Sequence");
                Console.WriteLine("4. Palindrome Checker");
                Console.WriteLine("5. Find Minimum Number");
                Console.WriteLine("6. Find Maximum Number");
                Console.WriteLine("7. Calculate Sum of Numbers");
                Console.WriteLine("8. Sort Numbers");
                Console.WriteLine("9. Exit");
                Console.Write("Please select an option (1-8): ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter the height of the tree: ");
                        if (int.TryParse(Console.ReadLine(), out int height))
                        {
                            Algorithms.PrintTree(height);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter an integer.");
                        }
                        break;
                    case "2":
                        Console.WriteLine("Roman Numerals Conversion:");
                        Console.WriteLine("1. Roman to Integer");
                        Console.WriteLine("2. Integer to Roman");
                        Console.Write("Select an option (1 or 2): ");
                        string option = Console.ReadLine();
                        if (option == "1")
                        {
                            Console.Write("Enter a Roman numeral: ");
                            string roman = Console.ReadLine();
                            int result = Algorithms.RomanToInt(roman);
                            Console.WriteLine($"The integer value is: {result}");
                        }
                        else if (option == "2")
                        {
                            Console.Write("Enter an integer (1-3000): ");
                            if (int.TryParse(Console.ReadLine(), out int number))
                            {
                                string romanNumeral = Algorithms.IntToRoman(number);
                                Console.WriteLine($"The Roman numeral is: {romanNumeral}");
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Please enter an integer.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid selection.");
                        }
                        break;
                    case "3":
                        Console.Write("Enter how many Fibonacci numbers to generate: ");
                        if (int.TryParse(Console.ReadLine(), out int count))
                        {
                            List<int> fibonacciSequence = Algorithms.GenerateFibonacci(count);
                            Console.WriteLine("Fibonacci Sequence:");
                            Console.WriteLine(string.Join(", ", fibonacciSequence));
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter an integer.");
                        }
                        break;
                    case "4":
                        Console.Write("Enter a string to check for palindrome: ");
                        string input = Console.ReadLine();
                        bool isPalindrome = Algorithms.IsPalindrome(input);
                        if (isPalindrome)
                        {
                            Console.WriteLine("The entered string is a palindrome.");
                        }
                        else
                        {
                            Console.WriteLine("The entered string is not a palindrome.");
                        }
                        break;
                    case "5":
                        Console.Write("Enter a list of integers separated by spaces or commas: ");
                        string minInput = Console.ReadLine();
                        List<int> minNumbers = Algorithms.ParseNumbers(minInput);
                        if (minNumbers != null)
                        {
                            int min = Algorithms.FindMinimum(minNumbers);
                            Console.WriteLine($"The minimum number is: {min}");
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter integers separated by spaces or commas.");
                        }
                        break;
                    case "6":
                        Console.Write("Enter a list of integers separated by spaces or commas: ");
                        string maxInput = Console.ReadLine();
                        List<int> maxNumbers = Algorithms.ParseNumbers(maxInput);
                        if (maxNumbers != null)
                        {
                            int max = Algorithms.FindMaximum(maxNumbers);
                            Console.WriteLine($"The maximum number is: {max}");
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter integers separated by spaces or commas.");
                        }
                        break;
                    case "7":
                        Console.Write("Enter a list of integers separated by spaces or commas: ");
                        string sumInput = Console.ReadLine();
                        List<int> sumNumbers = Algorithms.ParseNumbers(sumInput);
                        if (sumNumbers != null)
                        {
                            int sum = Algorithms.CalculateSum(sumNumbers);
                            Console.WriteLine($"The sum of the numbers is: {sum}");
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter integers separated by spaces or commas.");
                        }
                        break;

                    case "8":
                        Console.Write("Enter a list of integers separated by spaces or commas: ");
                        string sortInput = Console.ReadLine();
                        List<int> unsortedNumbers = Algorithms.ParseNumbers(sortInput);
                        if (unsortedNumbers != null)
                        {
                            List<int> sortedNumbers = Algorithms.SortNumbers(unsortedNumbers);
                            Console.WriteLine("The sorted numbers are:");
                            Console.WriteLine(string.Join(", ", sortedNumbers));
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter integers separated by spaces or commas.");
                        }
                        break;
                    case "9":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid selection. Please choose a number between 1 and 9.");
                        break;
                }
                Console.WriteLine();
            }
        }
    }
}
