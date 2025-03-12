using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject
{
    internal class Book
    {
        public int Id { get; set; }
        public  string Title { get; set; }

        public string Author { get; set; }
        public int year { get; set; }
        public Book(int id, string title, string author, int year)
        {
            Id = id;
            Title = title;
            Author = author;
            this.year = year;
        }
        public override string ToString()
        {
            return $"BookId {Id}, BookTitle {Title}, BookAuthor {Author}, BookYear {year}";
        }
    }
}
