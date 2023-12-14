

   public class EternalGoal : Goal
   {
        
        //goals that never complete, but each time the user recoreds them  to gain points
        // ex everytime you read your scriptures you get 100 points
        public override void RecordEvent()
        { 
           
        }



        public override bool IsComplete()
        {
           return true; 
        }
        
          
        
      
      

      public override string GetStringRepresentation()
      {
        return "";
      }

   
}
