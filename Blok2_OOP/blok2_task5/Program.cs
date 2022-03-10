using System;
using System.Collections.Generic;


namespace blok2_task5
{
    class WebSite
    {
        List<WebPage> webPages = new List<WebPage>();

        public void SiteMap()
        {
            Console.WriteLine("Sitemap");
            foreach (WebPage webPage in webPages)
                Console.WriteLine(webPage.NamePage);
        }

        public void AddPage(string namePege)
        {
            webPages.Add(new WebPage() {NamePage = namePege});
        }

        public void DellPage(int namber)
        {
            webPages.RemoveAt(namber);
        }
    }

    class WebPage
    {
        public string NamePage { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            WebSite webSite = new WebSite();

            Console.WriteLine("Specify the number of pages to create");
            int index = int.Parse(Console.ReadLine());

            for (int i = 1; i <= index; i++)
            {
                Console.Write("Enter a title " + i + " the page: ");
                webSite.AddPage(Console.ReadLine());
            }

            webSite.SiteMap();

            Console.WriteLine("Do you want to delete some page ENTER YES/NO");
            string question = Console.ReadLine();
            if (question=="YES")
            {
                Console.WriteLine("Enter the page number");
                int number = int.Parse(Console.ReadLine());
                webSite.DellPage(number);
            }

            Console.WriteLine("Hello World!");
        }
    }
}
