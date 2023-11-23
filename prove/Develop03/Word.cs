using System;
using Microsoft.VisualBasic;
public class Word
{
   private bool _hidden;               //Status of the word (Whether or not it is hidden)
   private string _text;               //Original word
   private string _hiddenText;         //Hidden version of the word (contains the "_")

   //  PUBLIC Word( text )
   public Word(string text)
   {
      _text = text;
      _hidden = false;

      foreach (char letter in text)
      {
         _hiddenText += '_';
      }
   }


   public string GetText()
   {
      if (_hidden)
         return _hiddenText;

      else
         return _text;
   }




   public bool GetHidden()
   {
      return _hidden;
   }



   public void Hide()
   {
      _hidden = true;
   }

}