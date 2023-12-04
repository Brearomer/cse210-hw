using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
public class ListingActivity
{
    // Attributes
    protected string _name;
    protected string _decription;
    protected string _activity;
    protected int _duration;
    private string descripton;
    private string v; 
    private int _count;
    private List<string> _prompts;

    // Behavior 
    public ListingActivity(string desription, string name, string startMessage, int duration, string activity)
    {
       _decription = descripton;
       _name = name;
       _duration = duration;
    }

    public ListingActivity(string v)
    {
        this.v = v;
    }

    public void ShowCountdown()
   {
   } 
   public void Duration()
   {
   } 
   public void StartMessage()
   {
      Console.WriteLine($"Welcome to {_name}");
   } 
   
   public void EndMessage()
   {
      Console.WriteLine($"Good Job !! {_name} for {_duration}");
   }
    
   public void run()
   {
   } 
   
   public string GetRandomPrompt()
   {

         return "";
   } 

  
}
