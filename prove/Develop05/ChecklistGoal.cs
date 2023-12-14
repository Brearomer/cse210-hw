   public  class ChecklistGoal : Goal
   {
      // That must Accomplished a certain number of times to be complete.
      // Each time the user records this goal  they gain some value, but when they achieve the desired amount they get an extra bonus


      private int _amountCompleted;
      private int _target;
      private int _bonus; 
      

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





