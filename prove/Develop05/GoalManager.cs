using System.Linq.Expressions;
using System.Reflection;

public class GoalManager
   {  
      private List<Goal>_goals;
      private int _score; 
      
      public GoalManager()
      {
         _goals = new List<Goal>();
         _score = 0;
      }
      
      public void DisplayScore()
      {
         Console.WriteLine($" Your current score is: {_score}");
      }
      
      public void CreateGoals()
      {
         Console.WriteLine("Select the type of goals");
         Console.WriteLine("1. Simple Goal");
         Console.WriteLine("2. Eternal Goal");
         Console.WriteLine("3.Checklist Goal");
        
         int type = int.Parse(Console.ReadLine());
         Console.Write("Enter the name of the goal you would like to do: ");
         string name = Console.ReadLine();

          Goal newGoal;
          
          switch (type)
          {
               case 1:
                  Console.Write("Enter the score value:");
                  int scoreValue = int.Parse(Console.ReadLine());
                  newGoal = new SimpleGoal();
                  break;
               case 2:
                   Console.Write("Enter the score value: ");
                   scoreValue = int.Parse(Console.ReadLine());
                   newGoal = new EternalGoal();
                   break;
               case 3:
                   Console.Write("Enter the target count: ");
                   int targetCount = int.Parse(Console.ReadLine());
                   Console.Write("Enter the score value: ");
                   scoreValue = int.Parse(Console.ReadLine());
                   Console.Write("Enter the bonus value: ");
                   int bonusValue = int.Parse(Console.ReadLine());
                   newGoal = new ChecklistGoal();
                   break;

               default:
                   Console.WriteLine("Invalid option. Please try again.");
                   return;
  
          }
          
          _goals.Add(newGoal);
          Console.WriteLine($"Goal  '{name}' created successfully. ");


      }
      
      public void RecordEvent()
      {
          Console.Write("Please enter the name of the goal: ");
          string name = Console.ReadLine();

          Goal goal = _goals.Find(goal => goal._shortName == name);
          
          if (goal == null)
          {
             Console.WriteLine($"Goal '{name}' not found. Please try again. ");
             return;
          } 
          
         goal.IsComplete();
         _score += goal._points;
         Console.WriteLine($"Event recoreded for goal '{name}' . You have gained {goal._points} points; ");
      }
     
      public void DisplayGoal()
      {
         if (_goals.Count == 0)
         {
            Console.WriteLine("No goals are found");  
            return;
         } 
        Console.WriteLine("Current goals are :");
        foreach (Goal goal in _goals)
        {
          Console.WriteLine($"{char.ToUpper(goal._descrition[0]) + goal._description.Substring(1)} Goal '{goal._shortName}' with a score value of {goal._points}. "); 

        }
      }

      public void SaveProgrress()
      {
         using (StreamWriter writer = new StreamWriter(filePath))
         {
              writer.WriteLine(_score);

              foreach (Goal goal in _goals)
              {
                 writer.WriteLine(goal.GetDetailsString().ToString());
                 writer.WriteLine(goal._shortName);
                 writer.WriteLine(goal._points);
                 if (goal is EternalGoal)
                 {
                    writer.WriteLine(((EternalGoal)goal));
                 } 
                 else if (goal is ChecklistGoal)
                 {
                    writer.WriteLine(((ChecklistGoal)goal).IsComplete); 
                    writer.WriteLine(((ChecklistGoal)goal).GetStringRepresentation);

                 }
              }
         } 
         Console.WriteLine("Goals and score saved successfully.");
      }     

      public void Load(string filePath)
      {
         using (StreamReader reader = new StreamReader(filePath))
         {
             _score = int.Parse(reader.ReadLine());
             
             while (!reader.EndOfStream)
             {
                string type = reader.ReadLine();
                string _shortName = reader.ReadLine();
                int points = int.Parse(reader.ReadLine());
                Goal goal; 

               switch (type)
               {
                  case "SimpleGoal":
                     goal = new SimpleGoal();
                     break;  
                  
                  case "EternalGoal":
                     bool IsComplete = bool.Parse(reader.ReadLine()); 
                     goal = new EternalGoal();
                     break; 
                  
                  case "ChecklistGoal":
                     int targetCount = int.Parse(reader.ReadLine());
                     int bonusValue = int.Parse(reader.ReadLine());
                     goal = new ChecklistGoal(_shortName, points, description);
                     break;
                 
                  default:
                     Console.WriteLine("Invalid goal type found in file. Skipping");
                     continue;
               }  
               _goals.Add(goal);

               
             }
         } 
         Console.WriteLine("Goals and score loaded successfully.");
      }
 
      
   }
