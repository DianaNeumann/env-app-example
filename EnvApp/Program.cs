using System;

class Program
{
    static void Main(string[] args)
    {
        var name = Environment.GetEnvironmentVariable("MAJUGA") ?? "foobar";
        Console.WriteLine($"env: {name}!");
    }
}