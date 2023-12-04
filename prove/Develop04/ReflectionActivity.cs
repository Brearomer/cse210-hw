using System;
using System.Diagnostics.Contracts;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

public class ReflectionActivity : Activity
{
     private List<string> _prompts;
     private List<string> _questions;


     public ReflectionActivity(string name, string descripton, int duration ) : base(name, descripton, duration) 
     {
         

         
               public string GetRandomPrompt()
               {
                 return $"{_prompts}";
               }
               



               public string GetRandomQuestion(string _questions)
               {
                    Console.WriteLine($"Why was this experience meaningful to you?");
                    Console.WriteLine($"Have you ever done anythng like this before? ");
                    Console.WriteLine($"How did you get started? ");
                    Console.WriteLine($"How did you feel when it was complete? ");
                    Console.WriteLine($"What maade this time different than other times when you were not as successful? ");
                    Console.WriteLine($"What is your favorite thing about this experience? ");
                    Console.WriteLine($"What could you learn from this expereience that applies to other situations? ");
                    Console.WriteLine($"What did you learn about yourself through this experience? ");
                    Console.WriteLine($"How can you keep this experience in mind in the future?");

               } 
               Console.WriteLine(" Few seconds to ")
               

                DisplayPrompt()
               {
                    Console.WriteLine("Think of a time when you stood up for someone else");
                    Console.WriteLine("Think of a time when you did something really difficult.");
                    Console.WriteLine("Think of a time when you help someoone in need");
                    Console.WriteLine("Think of a time when you dod something truly selfiess");

               }

                DisplayQuestions()
               {
               }
               public void run()
               {
               }
          }









     }
     }
     