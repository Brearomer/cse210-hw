

   public class EternalGoal : Goal
   {
    private static int bonus;

    public int TotalPointsEarned{get; set;}
     
     public EternalGoal(string shortName, int points) : base(shortName, "eternal", bonus)
     {
       TotalPointsEarned = 0;
     }
          
  
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
