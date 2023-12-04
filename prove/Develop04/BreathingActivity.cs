using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

public class BreathingActivity : Activity
{


  public BreathingActivity(string name, string descripton, int duration) : base(name, descripton, duration)
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





