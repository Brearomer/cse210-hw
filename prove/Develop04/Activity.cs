using System;
using System.Diagnostics.Contracts;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;


 public class Activity 
{
    
    private List<string>_spinner;
    private string _name;
    private string _description;
    private int _duration;
    
    public void DisplayStartingMessage()
   {
        Console.WriteLine($"Welcome to the {_name} activity");
        Console.WriteLine(_description);
        Console.WriteLine("How long, in seconds, would you like for our session? ");
        Console.WriteLine(_duration);
        Console.WriteLine(_duration);
        _duration = int.Parse(Console.ReadLine());  
   }    

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Good Job !! {_name} for {_duration} seconds!");
    }

    

    public void ShowSpinner(int seconds)
    {
       for (int i = seconds; i > 0; i--)
       {
          foreach (string symbol in _spinner)
          {
              Console.Write(symbol);
              Thread.Sleep(250);
              Console.Write("\b \b");
          }
       }
       
        
          
       
    }

    

    public void ShowCountdown(int seconds)
    {
       for(int i =_duration; i >0; i--)
       {
          Console.Write(i);
          Thread.Sleep(1000);
          Console.Write("\b \b");

       }
    }







}