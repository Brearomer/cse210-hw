using System.Security.Cryptography.X509Certificates;

public abstract class ChecklistGoal
{ 
   private int _amountCompleted;
   private int _target;
   private int _bonus;



    public void RecordEvent() //(override)
    {
    } 
    
   public bool IsComplete() //(override)
   {
   }
   
   public string GetDetailsString() //(override)
   {
   }
   
   public string GetStringRepresentation() // (override)
   {
   }







}