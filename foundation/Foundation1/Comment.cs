class Comment
{
    private string _commenterName;
    private string _comment;

    public Comment(string commenterName, string comment)
    {
        _commenterName = commenterName;
        _comment = comment;
    }

    public void DisplayComment()
    {
        Console.WriteLine($"{_commenterName}: {_comment}");
    }
}