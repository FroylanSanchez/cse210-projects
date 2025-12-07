class Comment
{
    private string _creatorName;
    private string _content;

    public Comment(string creatorName, string content)
    {
        _creatorName = creatorName;
        _content = content;
    }

    public string GetName()
    {
        return _creatorName;
    }

    public string GetContent()
    {
        return _content;
    }
}
