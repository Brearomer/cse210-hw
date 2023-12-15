using System;

public class Video
{
   public string _title;
   public string _author;
   public int _length; 
   public List<Comment> _comments = new List<Comment>();

   public Video(string title, string author, int length)
   {
      _title = title;
      _author = author;
      _length = length;
   } 
  
   public void AddComment(string commenterName, string commentText)
   {
      Comment newComment = new Comment(commenterName, commentText);
      _comments.Add(newComment);
   }

   public int GetNumberOfComments()
   {
      return _comments.Count;
   }
   


  


}





// to track the title, author, length(in sec) of the video. 
// creates 3-4 videos, sets the appropriate values 