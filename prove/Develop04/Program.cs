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
    
        Console.WriteLine("How long, in seconds, would you like for your session");
        string duration = Console.ReadLine();
          int number = int.Parse(duration);
        BreathingActivity breathingActivity = new BreathingActivity();
        breathingActivity.DisplayStartingMessage();
        breathingActivity.DisplayEndingMessage();
      } 
        
       else if (response == 2)
      {
         Console.WriteLine("How long, in seconds, would you like for your session");
         string duration = Console.ReadLine();
         int count = int.Parse(duration);
          ListingActivity listingActivity = new ListingActivity();
        listingActivity.DisplayStartingMessage();
        listingActivity.DisplayEndingMessage();
       }

      
       else if (response == 3)
      {
        Console.WriteLine("How long, in seconds, would you like for your session");
        string duration = Console.ReadLine();
        ReflectionActivity reflectionActivity = new ReflectionActivity();
        reflectionActivity.DisplayStartingMessage();
        reflectionActivity.DisplayEndingMessage(); 

      }
      
      if (response ==4)
      {
          Console.WriteLine("Quit!!");
      }
      
   
   }
  }
}