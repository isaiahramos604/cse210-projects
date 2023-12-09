using System;

class Comment
{
    protected string _commenterName;
    private string _commentText;
    public string GetName()
    {
        return _commenterName;
    }
    public void SetName(string commenterName)
    {
        _commenterName = commenterName;
    }
    public string GetCommenterText()
    {
        return _commentText;
    }
    public void SetCommenterText(string commenterText)
    {
        _commentText = commenterText;
    }
    public Comment(string commenterName, string commenterText)
    {
        _commenterName = commenterName;
        _commentText = commenterText;
    }

}

public class Video
{
    private string _titlemp4;
    private string _authormp4;
    private int _lengthinSeconds;
    public string GetTitle()
    {
        return _titlemp4;
    }
    public void SetTitle(string title)
    {
        _titlemp4 = title;
    }
    public string GetAuthor()
    {
        return _authormp4;
    }
    public void SetAuthor(string author)
    {
        _authormp4 = author;
    }
    public int GetLength()
    {
        return _lengthinSeconds;
    }
    public void SetLength(int length)
    {
        _lengthinSeconds = length;
    }
    private List<Comment> comments;
    public Video(string title, string author, int length)
    {
        _authormp4= author;
        _titlemp4 = title;
        _lengthinSeconds = length;
        comments = new List<Comment>();
        
    }

    public void AddComment(string commenterName, string commenterText)
    {
        Comment newComment = new Comment(commenterName, commenterText);
        comments.Add(newComment);
    }

    public int GetNumberOfComments()
    {
        return comments.Count;
    }

    public void DisplayVideoDetails()
    {
        Console.WriteLine($"Title: {_titlemp4}");
        Console.WriteLine($"Author {_authormp4}");
        Console.WriteLine($"Length: {_lengthinSeconds} seconds");
        Console.WriteLine($"Number of comments: {GetNumberOfComments()}");
        Console.WriteLine("Comments:");
        foreach(var comment in comments)
        {
            Console.WriteLine($"- {comment.GetName()}: {comment.GetCommenterText()}");
    }

    Console.WriteLine();
}
}




class Program
{
    static void Main(string[] args)
    {
        Video myVidoe = new Video("Making popcorn into a hotdog", "HotdogMan56", 30);
        myVidoe.AddComment("User 1", "Crazy Video");
        myVidoe.AddComment("User 2", "Thanks for Vid");
        myVidoe.AddComment("User 3", "Rated 5/5");
        myVidoe.DisplayVideoDetails();
        
        Console.WriteLine("Press Enter to show the next video");
        Console.ReadLine();
        Console.Clear();

        Video myVideo2 = new Video("Skate Board Trick", "JaneSkates", 40);
        myVideo2.AddComment("User 1", "Nice Video");
        myVideo2.AddComment("User 2", "Cool Trick");
        myVideo2.AddComment("User 3", "It was meh");
        myVideo2.DisplayVideoDetails();
        Console.WriteLine("Press Enter to show the next video");
        Console.ReadLine();
        Console.Clear();


        Video myVideo3 = new Video("Quick Clothing Show", "BobBillysClothes", 50);
        myVideo3.AddComment("User 1", "Nice Hat");
        myVideo3.AddComment("User 2", "Cool clothing style");
        myVideo3.AddComment("User 3", "Its to baggy in my opinion");
        myVideo3.DisplayVideoDetails();
        Console.WriteLine("End of video list, press enter to exit");
        Console.ReadLine();
        Console.Clear();

    }
}