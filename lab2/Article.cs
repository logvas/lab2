using System;

namespace lab2Space
{
class Article
{
    private double _rating;
    private Person _author;
    private string _title;
    public double Rating
    {
        get { return _rating; }
        set { _rating = value; }
    }
    public Person Author
    {
        get { return _author; }
        set { _author = value; }
    }
    public string Title
    {
        get { return _title; }
        set { _title = value; }
    }



    public Article()
    {
        Person authorTemp = new Person();
        authorTemp._name = "Sam";
        authorTemp._surname = "Ferguson";
        authorTemp._datuum = DateTime.Now;

        _author = authorTemp;
        _title = "Interesting paper";
        _rating = 10;

    }
    public Article(double rankConsructed, Person authorConstucted, string titleConstucted)
    {
        _rating = rankConsructed;
        _author = authorConstucted;
        _title = titleConstucted;
    }

    public string ToFullString()
    {
        string fullString;

        fullString = String.Join(Environment.NewLine, _rating, _title, _author.Name,
            _author._surname, _author._datuum);
            fullString = String.Join(Environment.NewLine, $"Title: {_title}", $"Rating: {_rating}",
 "Author", $"Name: {_author.Name}", $"Surname: {_author.Surname}", $"Date: {_author._datuum}", "");

        return fullString;
    }
    public override string ToString()
    {
        return ToFullString();
    }
}
}

