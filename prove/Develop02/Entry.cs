using System;
using System.Runtime.CompilerServices;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    public PromptGenerator pGen = new();


    public void Write()
    {
        _date = DateTime.Now.ToShortDateString();
        _promptText = pGen.GetRandomPrompt();
        Console.WriteLine(_promptText);
        _entryText = Console.ReadLine();
    }



    public void Display()
    {
        Console.WriteLine($"{_date} {_promptText}{_entryText}");
    }

}






