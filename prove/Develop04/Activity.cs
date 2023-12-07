using System;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;


 public class Activity 
{

    
    private string _name;
    private string _description;
    private int _duration;
    public Activity()
    {
       
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
        Console.WriteLine($"Good Job !! {_name} for {_duration} 🤗");
    }

    

    public void ShowSpinner(int seconds)
    {
      
    }

    public void Run()
    {
    }

    public void ShowCountdown()
    {
       for(int i =5; i >0; i--)
       {
          Console.Write(i);
          Thread.Sleep(1000);
          Console.Write("\b \b");

       }
       Console.WriteLine("Done.🤗");

        

    }







}