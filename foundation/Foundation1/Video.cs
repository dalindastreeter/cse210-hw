// _title: string
// _author:string
// _length: int
// _Comments: List<Comment>
//
// Video(title: string, author: string, length: int, comments: List<Comment>)
// AddComment (comment: Comment)
// Display(): string

using System.Net.Sockets;

class Video

{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
        
    }
    
    public void Display()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} seconds");
        Console.WriteLine($"Comments: {CountComments()}");
        foreach (var comment in _comments)
        {
            comment.Display();
        }
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int CountComments()
    {
        return _comments.Count;
    }
}    