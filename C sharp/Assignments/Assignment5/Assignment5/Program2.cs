using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    

    public class BookStore
    {
        
        public string Book_Name { get; set; }
        public string Author_Name { get; set; }
        public BookStore(string bookName, string authorName)
        {
            Book_Name = bookName;
            Author_Name = authorName;
        }

        
        public void Display()
        {
            Console.WriteLine($"Book Name: {Book_Name}");
            Console.WriteLine($"Author Name: {Author_Name}");
        }
    }

    public class BookShelf
    {
        private Books[] books;

        public BookShelf()
        {
            books = new Books[5]; 
        }
        public Books this[int idx]
        {
            get
            {
                if (idx < 0 || idx >= books.Length)
                {
                    throw new IndexOutOfRangeException($"Index {idx} is out of range.");
                }
                return books[idx];
            }
            set
            {
                if (idx < 0 || idx >= books.Length)
                {
                    throw new IndexOutOfRangeException($"Index {idx} is out of range.");
                }
                books[idx] = value;
            }
        }
    }

    class Program2
    {
        static void Main()
        {
            BookShelf s = new BookShelf();
            s[0] = new Books("The Lord of the rings", "J.R.R Tolkien");
            s[1] = new Books("Gitanjali", "Rabindranath Tagore");
            s[2] = new Books("Indian Struggle", "Subhas Chandra Bose");
            s[3] = new Books("Key to health", "Mahatma Gandhi");
            s[4] = new Books("The Catcher in the Rye", "J.D. Salinger");

            Console.WriteLine("Books on the BookShelf are given below:");
            for (int j = 0; j < 5; j++)
            {
                Console.WriteLine($"Book {j + 1}:");
                s[j].Display();
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }

}
