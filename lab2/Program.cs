using System;

namespace lab2Space
{
    internal class Program
    {
        public static Article[] GetArticles(int totalArticles)
        {
            Article[] articles1 = new Article[totalArticles];
            for (int counter = 0; counter < articles1.Length; counter++) { 
                articles1[counter] = new Article(); }
            return articles1;
        }

        static void Main(string[] args)
        {
            Magazine NTimes = new Magazine();

            var articles = GetArticles(2);

           NTimes = new Magazine("Journal", Frequency.Daily, DateTime.UtcNow, 33, articles );
            Console.WriteLine(NTimes.ToFullString());
            Console.WriteLine(NTimes.ToShortSrting());
            NTimes.AddArticles(articles);
            Console.ReadKey();
            //
        }
    }
    
}