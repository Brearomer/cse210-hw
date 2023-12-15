using System;

class Program
{
    private static object video;

    static void Main(string[] args)
    {
       List<Video> videos = new List<Video>();
       Video video1 = new Video("Our Last Summer","ABBA",415); 
       video1.AddComment("Frank","No matter where you in life,no matter what your emotions, there's an ABBA song the fits");
       video1.AddComment("Jonathan", "love this Song");

        Video video2 = new Video("The Best", "Tina Turner",409);
        video2.AddComment("Daniel","Only The Best TINA.always");
        video2.AddComment("Glorio","This song is powerful, with strong emotion, that uplifts the soul with encouraging words.This is the definition of blessing, when you simply say good to another");
     
        // Add videos to the list
        videos.Add(video1);
        videos.Add(video2);

        foreach(var video in videos)
        {
           Console.WriteLine($"Title:{video._title}");
           Console.WriteLine($"Author:{video._author}");
           Console.WriteLine($"Length:{video._length}");
           Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
        
        }

      foreach (var comment in video._comments)
      {
         Console.WriteLine($"Comment by {comment._commenterName}: {comment._commentText}");
      }


      Console.WriteLine();

    }
} 