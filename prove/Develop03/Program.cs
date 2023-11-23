using System;
using System.Dynamic;
using System.Runtime.InteropServices;

class Program
{

   static void Main(string[] args)
   {
      Random rng = new();
      Scripture scripture;
      string[][] scriptures = new string[][]
      {
         new string[]{"Let not mercy and truth forsake thee: bing them about thy neck; write them upon the table of thine heart:", "Proverbs", "3", "3"},
         new string[]{"And when the Lord was with the judge, and deliverd them out of the hand of their enemies all the days of the judge: for it repented the Lord because of their groanings by reason of them that oppressed them and vexed them", "Judges", "2", "18"},
         new string[]{"The Lord is my light and my salvation;whom shall I fear? the Lord is the strength of my life; of whom shall I be afraid?","Psalm","1"},
         new string[]{"And seeing the people in a state of such awful wickedness, and those Gadianton robbers filling the judgement-seat-having usurped the power and authority of the land; laying aside the commandments of God, and not in the least aright before him; doing no justice unto the children of men;","Helaman","4","5"},
         
         //new string[]{"Scripture", "Book", "Chapter", "Verse", "Optional End Verse"}
      };

      int index = rng.Next(scriptures.Length);
      if (scriptures[index].Length == 4)
      {
         scripture = new(scriptures[index][0], new Reference(scriptures[index][1], scriptures[index][2], scriptures[index][3]));
      }
      else
      {
         scripture = new(scriptures[index][0], new Reference(scriptures[index][1], scriptures[index][2], scriptures[index][3], scriptures[index][4]));
      }


      while (true)
      {
         Console.Clear();
         scripture.DisplayScripture();
         Console.Write("\n\nPress 'enter' to continue or type 'quit' to exit: ");
         string input = Console.ReadLine();
         if (input == "quit")
         {
            break;
         }

         if (scripture.CompletelyHidden())
         {
            break;
         }
         scripture.HideWords();
      }
   }
}




//  PSEUDOCODE KEYWORDS
//  GET         Console.ReadLine()
//  PUT         Console.Write() OR Console.WriteLine()
//  ->          =       Used for setting variable data: 'variable1 -> 1' MEANS 'variable1 = 1'