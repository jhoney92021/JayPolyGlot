using System.Diagnostics;

namespace CSharpBasics.Shared;

public class JayLogger
{
    public static void PrintObjectInBlueWithMethod(object toPrint)
    {
        StackTrace stackTrace = new StackTrace();
        var calledMethod = stackTrace?.GetFrame(1)?.GetMethod()?.Name;
        Console.ForegroundColor = ConsoleColor.Blue;        
        Console.WriteLine($"~~~ {calledMethod}  {toPrint} ~~~");
        Console.ForegroundColor = ConsoleColor.Gray;        
    }
}