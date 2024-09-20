using System;

class Program
{
    static void Main(string[] args)
    {
        // grade percentage
        Console.Write("Enter your grade percentage: ");
        string input = Console.ReadLine();
        int percentage = int.Parse(input);
        string letter = "";
        // letter grade
        if (percentage >= 90) {
            letter = "A";
        } else if (percentage >= 80) {
            letter = "B";
        } else if (percentage >= 70) {
            letter = "C";
        } else if (percentage >= 60) {
            letter = "D";
        } else {
            letter = "F";
        }
        // print
        Console.WriteLine($"Your letter grade is: {letter}");
        // determine if passed or not
        if (percentage >= 70) {
            Console.WriteLine ("Congratulations! You passed the course.");
        } else {
            Console.WriteLine("You did not pass. Better luck next time.");
        }
    }
}