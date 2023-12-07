public abstract class Goal
{
    private string _shortName;
    private string _description;
    private int _points;

   public Goal(string description , string shortName, int points);

  
   public void RecordEvent() //(abstract)
   {
   } 


   public  bool  Iscomplete() //(abstract)
   {
   }

   public string GetDetailsString()
   {
   }

   public string GetStringRepresentation() //(abstract)
   {
   }
}