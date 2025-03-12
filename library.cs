using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject
{
    internal class library
    {
        List<Book> books = new List<Book>();

        List<Book> borrowedBooks= new List<Book>(); 
        public void Add(Book newBook)
        {
            //validation
            if (books.Count < 100)
            {
                books.Add(newBook);
                Console.WriteLine("Book Added Sucessfully");
            }
            else
            {
                Console.WriteLine("Library is full");
            }
        }
        public void Remove(int id)
        {
            if (books.Count == 0)
            {
                Console.WriteLine(" No books to remove");
                return;
            }

            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].Id == id)
                {
                    books.RemoveAt(i);
                    Console.WriteLine("Book removed successfully");
                    return; 
                }
            }

            Console.WriteLine("There is no book with this ID.");
        }


        public void Display()
        {
            if (books.Count > 0)
            {
                foreach (Book b in books)
                {
                    Console.WriteLine(b);
                }
            }
            else
            {
                Console.WriteLine("Nothing to display");
            }

        }

        public void borrowedBook(int id)
        {
            if(books.Count ==0 )
            {
                Console.WriteLine("No Books to be borrowed");
                return;
            }
            
            for (int i = 0; i < books.Count; i++)
            {
                if (id == books[i].Ids)
                {
                    borrowedBooks.Add(books[i]);
                    books.RemoveAt(i);
                    Console.WriteLine("Great Happy Reading");
                    return;

                }
                
                   
            }
         
          Console.WriteLine("This book is not available");


        }
    }
}
