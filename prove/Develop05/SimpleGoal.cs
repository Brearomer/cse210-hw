

using System.Runtime.CompilerServices;

public class SimpleGoal : Goal
    {
     private bool _isComplete;
      private string name;
    private int scoreValue;

    public bool Completed { get; }

    public SimpleGoal(string shortName, string description, int points) : base(shortName, description, points)
    {
        Completed = false;
    }
    

    

    public override void  RecordEvent()  
        {
        }

        public override bool IsComplete()
        {
           return true;
        }
        

        public override string  GetStringRepresentation() 
        { 
            return "";
        }
    }
