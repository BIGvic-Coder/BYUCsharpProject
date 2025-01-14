using System;

class Program
{
    static void Main(string[] args)
    {
        // Prompt the user for their grade percentage
        Console.Write("Enter your grade percentage: ");
        int gradePercentage = int.Parse(Console.ReadLine());

        // Determine the letter grade
        string letter = "";
        string sign = "";

        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Determine the "+" or "-" sign (excluding A and F grades)
        if (letter != "F")
        {
            int lastDigit = gradePercentage % 10;

            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }

        // Handle special cases for A+ and F grades
        if (letter == "A" && sign == "+")
        {
            sign = ""; // No A+ grade
        }
        else if (letter == "F")
        {
            sign = ""; // No F+ or F- grades
        }

        // Display the final grade
        Console.WriteLine($"Your grade is: {letter}{sign}");

        // Determine if the user passed or failed
        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations, you passed the course!");
        }
        else
        {
            Console.WriteLine("Unfortunately, you did not pass. Better luck next time!");
        }
    }
}
