using System.ComponentModel;
using System.Xml;

public class Video{

    private string _title;

    private string _author;

    private int _length;

    private List<Comment> _commentList = new List<Comment>();


    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;

    }

    public void AddComment(Comment comment)
    {
        _commentList.Add(comment);
    }
    public int GetCommentCount()
    {
        int commentCount = _commentList.Count;
        return commentCount;
    }
    public string DisplayDetails()
    {
        string videoInfo = ($"The video name of the video is: {_title} made by {_author} and is {_length} seconds long. There are {GetCommentCount()} comments.");
        return videoInfo;
    }


}