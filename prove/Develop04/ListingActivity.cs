using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;


public class ListingActivity : Activity
{  
   
    private int _count;
    private string _prompt;
    private  List<string> _questions = new List<string>()

    {
       "Who are people that you appreciate?",
       "What are personal strengths of yours?",
       "Who are people that you have helped this week?",
       "When have you felt the Holy Ghost this month?",
       "Who are some of your personal heroes",
    };
     private string _description;
    public ListingActivity()
    {
       _count = 0;
       _description = "This activity will help you reflect oon the good things in your life by having you list as you can in a certain area.";

    }


    public List<string>questions = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?",
    };

    public void ListingExercise()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(30);
        if (DateTime.Now < futureTime)
        {
            Console.WriteLine("Start Now ...");
            ShowCountdown();

            Console.WriteLine("Stop!!...");
        } 
    }
    public Random rng = new();

    public string GetRandomQuestions()
    {
        int index = rng.Next(_questions.Count);
        return _questions[index];
    }
    
    public void RandomQuestions()
    { 

        DateTime futureTime = DateTime.Now.AddSeconds(5);
        _count++;
        
        while (DateTime.Now < futureTime )
        {
           Console.WriteLine($"What are your thoughts? ");
           Console.ReadLine(); 
             
        }
        Console.WriteLine("Done!!");
    }



    public void ListingRun()
    {
        DisplayStartingMessage();
        GetRandomQuestions();
        ListingExercise();
        ShowCountdown();
        DisplayEndingMessage();

    }





    // user lists as many items as they can until they reach the duration

    // displays back the number of items were entered









}
