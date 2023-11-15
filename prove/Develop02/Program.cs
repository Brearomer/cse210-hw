using System;
using System.IO.Enumeration;
class Program
{
    public static void Main(string[] args)
    {
        Journal journal = new();
        while (true)
        {
            Console.WriteLine("Welcome to the Journal program!\n" +
                "1 Add Entry\n" +
                "2 Display All Entries\n" +
                "3 Save\n" +
                "4 Load\n" +
                "5 Quit\n");

            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    journal.AddEntry();
                    break;
                case "2":
                    journal.DisplayEntries();
                    break;

                case "3":
                    // PUT "Enter the filename: "
                    // filename = GET
                    Console.WriteLine("Enter the file name: ");
                    string filename = Console.ReadLine();
                    journal.Save(filename);
                    break;

                case "4":
                    // PUT "Enter the filename: "
                    // filename = GET
                    Console.WriteLine("Enter the file name: ");
                    filename = Console.ReadLine();
                    journal.Load(filename);
                    break;

                case "5":
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid input...");
                    break;

            }
        }


        //     if (option == "1")
        //     {
        //         journal.AddEntry();
        //     }
        //     else if (option == "2")
        //     {
        //         journal.DisplayEntries();
        //     }
        //     // //...
        //     else
        //     {
        //         Console.WriteLine("Invalid input...");
        //     }
    }
}