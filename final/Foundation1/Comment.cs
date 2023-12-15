using System;
using System.Transactions;
public class Comment
{
    public string _comments;
    public string _commeterName;
    public string _commentText;

    public Comment(string commenterName, string commentText)
    {
       
       _commeterName = commenterName;
        _commentText = commentText;
    }
     
}


