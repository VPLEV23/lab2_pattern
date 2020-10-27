using System;
using System.Collections.Generic;

namespace newSub
{
    class Program
    {
        static void Main(string[] args)
        {
            Analytics obj = Analytics.getInstance();
            obj.addUrl("http://google.com");
            obj.addUrl("http://google.com");
            obj.addUrl("http://google.com");
            obj.addUrl("https://github.com/");
            obj.addUrl("https://github.com/");
            obj.print();
            obj.clearHistory();
            obj.print();

        }
    }

    class Analytics
    {
        private Dictionary<string, int> UrlList;
        private static Analytics _instance;
        private Analytics()
        {
            UrlList = new Dictionary<string, int>();
        }
        public static Analytics getInstance()
        {
            if (_instance == null)
            {
                _instance = new Analytics();
            }
            return _instance;
        }
        public void addUrl(string url)
        {
            if (UrlList.ContainsKey(url))
            {
                UrlList[url] += 1;
            }
            else
            {
                UrlList.Add(url, 1);
            }
        }
        public void print()
        {
            if (UrlList.Count != 0)
            {
                foreach (var item in UrlList)
                {
                    Console.WriteLine("Url: {0}, кількість кліків: {1}", item.Key, item.Value);
                }
            }
            else
            {
                Console.WriteLine("Url історія пуста!");
            }
        }
        public void clearHistory()
        {
            UrlList.Clear();
            Console.WriteLine("Історія була очищена!");
        }
    }
}