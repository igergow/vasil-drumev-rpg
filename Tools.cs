public class Tools
{
    public static void PrintTopLeftCorner(string message)
    {
        int x = Console.CursorLeft;
        int y = Console.CursorTop;
        Console.SetCursorPosition(0, 0);
        Console.Write(message);
        Console.SetCursorPosition(x, y);
    }

    public static void PrintTopRightCorner(string message)
    {
        int x = Console.CursorLeft;
        int y = Console.CursorTop;
        Console.SetCursorPosition(Console.WindowWidth - message.Length, 0);
        Console.Write(message);
        Console.SetCursorPosition(x, y);
    }

    public static void PrintBottomLeftCorner(string message)
    {
        int x = Console.CursorLeft;
        int y = Console.CursorTop;
        Console.SetCursorPosition(0, Console.WindowHeight - 1);
        Console.Write(message);
        Console.SetCursorPosition(x, y);
    }

    public static void PrintBattleInfo(string message)
    {
        int x = Console.CursorLeft;
        int y = Console.CursorTop;
        Console.SetCursorPosition(0, (Console.WindowHeight - 1) / 2);
        Console.Write(message.PadLeft((Console.WindowWidth + message.Length) / 2, ' ').PadRight(Console.WindowWidth, ' '));
        Console.SetCursorPosition(x, y);
    }
}