using System;
using System.Collections;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter your text");
        string sampleText = Console.ReadLine();
        var reverseText = StringReverse(sampleText);
        Console.WriteLine($"Reversed Text: {reverseText}");
    }
    public static string StringReverse(string str)
    {
        var reversedStr = "";
        Stack myStack = new Stack();
        foreach (var t in str)
            myStack.Push(t);
        while (myStack.Count > 0)
            reversedStr += myStack.Pop();
        return reversedStr;
    }
}