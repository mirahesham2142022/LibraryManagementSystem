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

        public libraryUser(string name) {
            this.Name = name;
        }
        //As user && librarian Can DisplayBooks
        public void BorrowBook(int id,library lib)
        {
            lib.borrowedBook(id);

        }

    }
}
