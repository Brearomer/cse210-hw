using System;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;


 public class Activity 
{

    
    private string _name;
    private string _description;
    private int _duration;
    public Activity(string name , string descripton, int duration)
{
        _name = name;
        _description = descripton; 
        
}
    public void DisplayStartingMessage()
   {
        System.Console.WriteLine($"Welcome to the {_name} activity");
        System.Console.WriteLine(_description);
        System.Console.WriteLine("How long, in seconds, would you like for our session? ");
        System.Console.WriteLine(_duration);
         
        // Hint _duration = int.parse
   }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Good Job !! {_name} for {_duration}");
    }



    public void ShowSpinner()
    {
    }

    public void ShowCountdown()
    {

        Console.Write("5");
        Thread.Sleep(1000);
        Console.Write("/b");
        Console.Write("4");
        Thread.Sleep(1000);
        Console.Write("/b");
        Console.Write("3");
        Thread.Sleep(1000);
        Console.Write("2");
        Console.Write("/b");
        Thread.Sleep(1000);
        Console.Write("1");


        Console.WriteLine("Done!!");
    }




}