using System;
using System.Net;
using System.Runtime.ConstrainedExecution;

class Program
 {  
   static void Main(string[] args)
   {
    int response = 0;
   while (response != 4)
   {
     Console.WriteLine("Menu Options");
     Console.WriteLine("1. Breathing Activity");
     Console.WriteLine("2. Listing Activity");
     Console.WriteLine("3. Reflection Activity");
     Console.WriteLine("4. Quit");
     response = int.Parse(Console.ReadLine());
     Console.WriteLine($"Choose activities you want to do");
     

     
        


        if (response  == 1)
      {
  
        BreathingActivity breathingActivity = new BreathingActivity();
        breathingActivity.BreathingRun();
        
      } 
        
       else if (response == 2)
       {
        ListingActivity listingActivity = new ListingActivity();
        listingActivity.ListingRun();

      }


      
      
       else if (response == 3)
      {
        
        ReflectionActivity reflectionActivity = new ReflectionActivity();
        reflectionActivity.ReflectionRun();
    
      }
      
      if (response ==4)
      {
          Console.WriteLine("Quit!!");
      }
      
   
   }
  }
}