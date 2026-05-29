public class Comment
{
    private string _username;

    private string _commentText;

    public Comment(string username, string commentText)
    {
        _username = username;
        _commentText = commentText;

    }

    public string DisplayComments()
    {
        string commentInfo = ($"{_username} commented '{_commentText}'");
        return commentInfo;
    }
}