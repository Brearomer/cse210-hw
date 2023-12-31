using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;



    public abstract class Goal
    {
        private string _shortName;
        private string _description;
        private int _points;
    internal object _name;
    internal object _type;

    public Goal(string shortName, string description, int points)
        {
            _shortName = shortName;
            _description = description;
            _points = points;
        }
       
        
         
        public abstract void RecordEvent(); 
        
        
        
    


        public abstract bool IsComplete();

        

        public virtual string GetDetailsString()
        {
           return "";
        }
        
            

        

        public  abstract  string GetStringRepresentation(); 
        
        
    }
