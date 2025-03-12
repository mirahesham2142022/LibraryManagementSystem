using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject
{
    internal class libraryUser:User
    {
        //association between library and library card
        public libraryCard libCard { get; set; }

        //As user&&librarian Can DisplayBooks
        public void BorrowBook(Book BorrowingBook)
        {

        }
    }
}
