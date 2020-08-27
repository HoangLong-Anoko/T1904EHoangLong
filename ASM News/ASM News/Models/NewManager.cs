using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace ASM_News.Models
{
    class NewManager
    {
        private static List<New> GetNews()
        {
            var News = new List<New>();
            News.Add(new New(NewsCategory.Politics, "Opinion_Trump gets an extreme makeover at the RNC"));
            News.Add(new New(NewsCategory.Politics, "RNC Day 4 Trump to accept nom at White House"));

            News.Add(new New(NewsCategory.Weather, "Why coastal communities should fear storm surge"));
            News.Add(new New(NewsCategory.Weather, "Laura updates Hurricane weakens to Category 2"));

            News.Add(new New(NewsCategory.Technology, "Dem, GOP conventions will be like none before"));
            News.Add(new New(NewsCategory.Technology, "Galaxy Note 20 costs $300 less than the Ultra"));

            News.Add(new New(NewsCategory.Entertainment, "What to watch on Thursday"));
            News.Add(new New(NewsCategory.Entertainment, "Macaulay Culkin Trolls Fans"));

            return News;
        }

        public static void GetAllNews(ObservableCollection<New> news)
        {
            var allnews =  GetNews();
            news.Clear();
            allnews.ForEach(p => news.Add(p));
        }

        public static void GetNewByCategory(ObservableCollection<New> news, NewsCategory category)
        {
            var allnews = GetNews();
            var filteredNews = allnews.Where(p => p.Category == category).ToList();
            news.Clear();
            filteredNews.ForEach(p => news.Add(p));
        }

        public static void GetNewByTile(ObservableCollection<New> news, string tile)
        {
            var allnews = GetNews();
            var filteredNews = allnews.Where(p => p.Tile.Contains(tile)).ToList();
            news.Clear();
            filteredNews.ForEach(p => news.Add(p));
        }
    }
}
