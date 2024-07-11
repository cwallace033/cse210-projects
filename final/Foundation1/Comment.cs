class Comment
{
    private string _commentName;
    private string _comment;

    public Comment(string commentName, string comment)
    {
        _commentName = commentName;
        _comment = comment;
    }

    public string GetCommentName()
    {
        return _commentName;
    }

    public string GetComment()
    {
        return _comment;
    }
}