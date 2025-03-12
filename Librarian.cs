using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject
{
    internal class Librarian : User
    {
        public int EmployeeNumber { get; set; }
        public Librarian(string name)
        {
            this.Name = name;
        }
        //seperation of concerns
        public void AddBook(Book newbook, library library)
        {
            library.Add(newbook);

        }

        //Can remove it by id
        public void removeBook(int id, library libraryy)
        {
            libraryy.Remove(id);

        }
        public override string ToString()
        {
            return $"{EmployeeNumber},{Name}";
        }
    }
}
