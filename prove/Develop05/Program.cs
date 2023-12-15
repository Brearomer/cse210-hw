class program
{
  static void Main(string[] args)
  {
    GoalManager goalManager = new GoalManager();
    string filename = "";

    Console.WriteLine("Welcome to the Goal Program!!");
    while (true)
    {  
       goalManager.DisplayScore();

      Console.WriteLine("Menu options:");
      Console.WriteLine("1 View Goals");
      Console.WriteLine("2. Create a goal");
      Console.WriteLine("3. Record a event");
      Console.WriteLine("4. Save File");
      Console.WriteLine("5. Load");
      Console.WriteLine("6. Exit");

      Console.Write("Select a choice from the menu:");
      string userInput = Console.ReadLine(); 
      
      switch (input)
      {
         case "1":
          goalManager.DisplayGoals();
          break;

        case "2":
          goalManager.CreateGoal();
          break;

        case "3":
          goalManager.RecordEvent();
          break;

        case "4":
          Console.Write("Enter the name of the file: ");
          filename = Console.ReadLine();
          goalManager.Save(filename);
          break;

        case "5":
          Console.Write("Enter the name of the file: ");
          filename = Console.ReadLine();
          goalManager.Load(filename);
          break;
       case "6":
        Console.Write("Enter the name of the file: ");
        filename = Console.ReadLine();
        goalManager.Save(filename);
        Console.WriteLine("Thank you for using the Goal Tracker program!");
        return;

      default:
        Console.WriteLine("Invalid input. Please enter a number from 1 to 6.");
        break;
      }







    }
  }
}









