using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject
{
    internal abstract class User
    {
        //abstract:Can't create object from it
        //abstract class: class that bany class will iheirt from it complete the implemntation of functions
        public string Name { get; set; }

        public void displayBooks(library lib)
        {
            lib.Display();
        }

    }
}
