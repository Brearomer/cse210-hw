using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

public class BreathingActivity : Activity
{
  private string _name;
  private string _description;

  private int _duration;
  public BreathingActivity() : base()
  {
    _name = "Breathing";
    _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
  }

  public void BreathingExercise()
  {
    DateTime startTime = DateTime.Now;
    DateTime futureTime = startTime.AddSeconds(_duration);
    if (DateTime.Now < futureTime)
    {
       Console.WriteLine("Breathe in ...");
       ShowCountdown();
      
        Console.WriteLine("Breathe out...");
    } 
  }  
   public void BreathingRun()
   {
      DisplayStartingMessage();
      BreathingExercise(); 
      ShowCountdown();
      DisplayEndingMessage();
     
   }
   
     
  
   
   


}











