using System.Diagnostics.Contracts;

public  class ChecklistGoal : Goal
   {
      

      private int _amountCompleted;
      private int _target;
      private int _bonus;
    private static string shortName;
    private string shortName1;
    private int points;
    private object description;

    public ChecklistGoal(string name, int amountCompleted, int target, int bonus) : base (shortName, "checklist",bonus)
      {
         _amountCompleted = 0;
         _target = target;
         _bonus = bonus;
      }

    

    public override void RecordEvent()
      { 
          
      }
       
          
      
      
      public override bool IsComplete() 
      {
         return true;
      }
      
      
      
         

      public override  string GetDetailsString() 
      {
          return " ";  
      }

      public  override string  GetStringRepresentation()
      {
        return "";
      } 
      
      
      
      

   }





