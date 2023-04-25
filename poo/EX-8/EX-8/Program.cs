using System;

namespace EX_7;

public class Program
{
    static void Main(string[] args)
    {
        ShowText("Texto de teste", ConsoleColor.Magenta);
    }

    public static void ShowText()
    {
        string text = "Hello, World!";
        int width = Console.WindowWidth;

        Console.SetCursorPosition(width/2 - text.Length, 0);
        Console.WriteLine(text);
    }

    public static void ShowText(string text, ConsoleColor color)
    {
        int width = Console.WindowWidth;

        Console.SetCursorPosition(width/2 - text.Length, 0);
        Console.ForegroundColor = color;
        Console.Write(text);
    }
}