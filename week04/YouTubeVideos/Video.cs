using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

public class Video
{
    public  string _title;
    public string _author;
    public  int _length;
    public List<Comments>_comments;


    public Video(string title, string author , int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comments>();
    }

    public void AddComments(Comments comment)
    {
        _comments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    public void DisplayComments()
    {
        Console.WriteLine($"Comments for video '{_title}':");
        foreach (var comment in _comments)
        {
            Console.WriteLine($"- {comment._nameOfPerson}: {comment._commentText}");
        }
    }




}