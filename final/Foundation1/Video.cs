using System;

public class Video{

    private string _title;
    private string _author;
    private int _videoLength;
    private List<Comment> _comments;

    public Video(string title, string author, int videoLength){

        _title = title;
        _author = author;
        _videoLength = videoLength;

        _comments = new List<Comment>();

    }

    public int NumberOfComments(){

        return _comments.Count;
    }

    public void DisplayInfo(){

        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_videoLength} seconds");
        Console.WriteLine($"Number of comments: {NumberOfComments()}");
   
    }

    public void DisplayComments(){

        foreach(Comment comment in _comments){

            comment.DisplayInfo();
            Console.WriteLine();
        }
   
    }

    public void AddComment(Comment comment){

        _comments.Add(comment);

    }


}