using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject
{
    internal class library
    {
      List<Book> books=new List<Book>();
   
        Book[] BorrowedBooks = new Book[40];
        public void Add(Book newBook)
        {
            //validation
            if(books.Count<100)
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
            if(id <100 && books is not null )
            {
                for (int i = 0; i < books.Capacity; i++)
                {
                    if (books[i].Id==id)
                    {
                        books.Remove(books[id]);
                        Console.WriteLine("Removed Successfully");
                    }
                    else
                    {
                        Console.WriteLine("There is no book by this name");
                    }
                }
            }

        }
        public void Display()
        {
            foreach(Book b in books)
            {
                Console.WriteLine(b);
            }
        }
    }
}
