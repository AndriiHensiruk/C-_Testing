using System;
using System.Collections.Generic;

namespace blok2_task2
{ 
    class Book
     {
        public int id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public int yearEdition { get; set; }

        public Book()
        {

        }
    }
    class Library : Book
    {
        public List<Book> books { get; set; }

        public Library()
        {
            books = new List<Book>();
        }

        public void serchBook(string Name)
        {
            Book found= books.Find(item=>item.Name==Name);
            Console.WriteLine("Looking for a book:");
            Console.WriteLine("\t"+found.id+" "+found.Name+" "+found.Author+" "+found.yearEdition);
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            library.books.Add(new Book() { id = 1, Name = "From Paycheck to Purpose", Author = "Coleman, Ken", yearEdition = 2021 });
            library.books.Add(new Book() { id = 2, Name = "Flying Blind", Author = "Robison, Peter", yearEdition = 1234 });
            library.books.Add(new Book() { id = 3, Name = "Tinderbox", Author = "James Andrew", yearEdition = 1987 });
            library.books.Add(new Book() { id = 4, Name = "American Kleptocracy: ", Author = "Michel, Casey", yearEdition = 2000 });
            library.books.Add(new Book() { id = 5, Name = "Twelve and a Half", Author = "ssfgsd sfdgfd", yearEdition = 1999 });

            Console.WriteLine("Enter a title for the book");
            string name = Console.ReadLine();
            library.serchBook(name);
        }
    }
}
