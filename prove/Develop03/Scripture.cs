using System;
using System.Collections.Concurrent;
using Microsoft.VisualBasic;
public class Scripture
{
   private Reference _reference;
   private List<Word> _words = new();
   private string _scripture;
   private Random rng = new();


   public Scripture(string text, Reference reference)
   {
      _scripture = text;
      _reference = reference;

      string[] wordArray = text.Split();
      foreach (string wordString in wordArray)
      {
         Word wordObj = new Word(wordString);
         _words.Add(wordObj);
      }
   }


   public void DisplayScripture()
   {

      Console.Write(_reference.GetReferenceString() + " -");

      foreach (Word word in _words)
      {
         Console.Write(word.GetText() + " ");
      }

   }



   public void HideWords()
   {
      int counter = 0;
      while (counter < 3 && !CompletelyHidden())
      {
         int index;
         do
         {
            index = rng.Next(_words.Count);
         }while(_words[index].GetHidden());
         
         _words[index].Hide();
         counter++;

      }
   }


   public bool CompletelyHidden()
   {
      foreach (Word word in _words)
      {
         if (!word.GetHidden())
         {
            return false;
         }
      }
      return true;
   }
}