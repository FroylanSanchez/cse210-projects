class Video
{
    private string _videoTitle;
    private string _videoAuthor;
    private double _videoLength;
    private List<Comment> _comments = new List<Comment>();

    public void SetTitle(string title)
    {
        _videoTitle = title;
    }

    public void SetAuthor(string author)
    {
        _videoAuthor = author;
    }

    public void SetLength(double length)
    {
        _videoLength = length;
    }

    public string GetTitle()
    {
        return _videoTitle;
    }

    public string GetAuthor()
    {
        return _videoAuthor;
    }

    public double GetLength()
    {
        return _videoLength;
    }

    public void AddComment(Comment c)
    {
        _comments.Add(c);
    }

    public int GetCommentCount()
    {
        return _comments.Count;
    }

    public List<Comment> GetComments()
    {
        return _comments;
    }
}
