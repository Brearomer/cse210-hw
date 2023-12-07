using System;
using System.Diagnostics.Contracts;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

public class ReflectionActivity : Activity
{
   


   private List<string> _prompts = new List<string>()
     {
        "Think of a time when you stood up for someoneelse",
        "Think of a time when you did something really difficult",
        "Think of a time when you helped someone in need",
        "Think of a time when you did something truly selfless.",
     };


     private List<string> _questions = new List<string>()
     {
        "Why was this experience meaningful to you ?",
        "Have you ever done anything like this before ?",
        "How did you get started?",
        "What did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience? ",
        "What could you learn from this experience that applies to other situation?",
        "What did you learn about yourself through this experience? ",
        "How can you keep this experience in mind in the future?",
     };



     public List<string>prompts = new List<string> 
     {
       "Think of a time when you stood up for someone else",
        "Think of a time when you did something difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless.",
      
     };

   public Random rng = new();
   public string GetRandomPrompts()
     {
      int index = rng.Next(_prompts.Count);
      return _prompts[index];
     }
     

    public List<string>questions = new List<string>
    {
      "Why was this experience meaningful to you ?",
        "Have you ever done anything like this before ?",
        "How did you get started?",
        "What did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience? ",
        "What could you learn from this experience that applies to other situation?",
        "What did you learn about yourself through this experience? ",
        "How can you keep this experience in mind in the future?",
     };
    
    
   
   public string GetRandomQuestions()
   {
      int index = rng.Next(_questions.Count);
      return _questions[index];
   } 

   public void ReflectionExercise()
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






    
     



   

}






