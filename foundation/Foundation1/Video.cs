class Video
{
    private string _title;
    private string _author;
    private int _videoDuration;
    private List<Comment> _comments;

    public Video(string title, string author, int videoDuration)
    {
        _title = title;
        _author = author;
        _videoDuration = videoDuration;
        _comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetCommentCount()
    {
        return _comments.Count;
    }

    public void DisplayInformation()
    {
        Console.WriteLine("Title: " + _title);
        Console.WriteLine("Author: " + _author);
        Console.WriteLine("Duration: " + _videoDuration + " seconds");
        Console.WriteLine("Number of Comments: " + GetCommentCount());

        foreach (Comment comment in _comments)
        {
            comment.DisplayComment();
        }
    }
}