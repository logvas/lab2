using System;

namespace lab2Space
{
    class Magazine
    {
        private string _name;
        private Frequency _frequency;
        private DateTime _date;
        private int _tirag;
        private Article[] _articles;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public Frequency Frequency
        {
            get { return _frequency; }
            set { _frequency = value; }
        }
        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }
        public int Tirag
        {
            get { return _tirag; }
            set { _tirag = value; }
        }
        public Article[] Articles
        {
            get { return _articles; }
            set { _articles = value; }
        }

        public Magazine()
        {
            Name = "Gazeta";
            Frequency = Frequency.Weekly;
            Date = DateTime.Now;
            Tirag = 0;
            Articles = new Article[0];

        }
        public Magazine(string nameConstructed, Frequency frequencyConstucted,
            DateTime dateConstructed, int tiragConstructed, Article[] articlesConstructed)
        {
            Name = nameConstructed;
            Frequency = frequencyConstucted;
            Date = dateConstructed;
            Tirag = tiragConstructed;
            Articles = articlesConstructed;
        }


        public Magazine AddArticles(Article[] addedArticles)
        {
            Article[] expandedArticles = new Article[Articles.Length + addedArticles.Length];
            int counter;
            foreach (Article addedArticle in addedArticles)
            {

                expandedArticles[Articles.Length] = addedArticle;

                for (counter = 0; counter < Articles.Length; counter++)
                { expandedArticles[counter] = Articles[counter]; }
            }
            Magazine res = new Magazine(Name, Frequency, Date, Tirag, expandedArticles);
            return res;
        }
        public string ToFullString()
        {
            int counter;
            string fullString = String.Join(Environment.NewLine, $"Name: {Name}", $"Tirag: {Tirag}",
                $"Date: {Date}", $"Frequency: {Frequency}","");
            for (counter = 0; counter < Articles.Length; counter++)
            {
                fullString = string.Join(Environment.NewLine,
                fullString,Articles[counter].ToFullString());
            }

            return fullString;
        }
        public string ToShortSrting()
        {
            double average = 0;
            int counter;
            for (counter = 0; counter < Articles.Length; counter++)
            { average += Articles[counter].Rating; }
            average = average / Articles.Length;
            string shortString = string.Join(Environment.NewLine, $"Name: {Name}", 
 $"Tirag: {Tirag}",$"Date: {Date}",$"Frequency: {Frequency}", $"Average rating: {average}", ""); 
            return shortString;
        }
    }
}
