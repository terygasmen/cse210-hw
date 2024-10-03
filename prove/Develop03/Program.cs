using System;

class Program
{
    public static void Main(string[] args){
        Reference reference = new Reference("John", 3, 16);
        Scripture scripture = new Scripture("For God so loved the world...", reference);
        Console.WriteLine("Scripture Memorization Program");
    }
}