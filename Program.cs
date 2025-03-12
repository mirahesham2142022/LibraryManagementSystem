namespace LibraryProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome to Our library");
            library library = new library();
            char userType;
            Console.WriteLine("Hi Enter your name");
            string name=Console.ReadLine();
            Librarian l1 = new Librarian(name);
            Console.WriteLine($"Welcome {l1.Name} ");

            do
            {
                Console.WriteLine("Are you librarian or User (l/R)");

            } while (!char.TryParse(Console.ReadLine().ToUpper(), out userType) || userType != 'L' && userType != 'R');
           while(true)
            {
                if (userType == 'L')
                {
                    
                    Console.WriteLine("Do you want to add book (A),Remove book (R),Display (D)");
                    char LibrarianChoice = Console.ReadLine()?.ToUpper()[0] ?? 'O';
                    //while(true)
                    //{
                    switch (LibrarianChoice)
                    {
                        case 'A':
                            Console.WriteLine("Add Book Details ID,,Title,Author,Year");
                            int Id = int.Parse(Console.ReadLine());
                            String Title = Console.ReadLine();
                            String Author = Console.ReadLine();
                            int Year = int.Parse(Console.ReadLine());

                            Book book = new Book(Id, Title, Author, Year);
                            l1.AddBook(book, library);
                            break;
                        case 'R':
                            Console.WriteLine("Add The Id of Book you want to remove");
                            Id = int.Parse(Console.ReadLine());
                            l1.removeBook(Id, library);

                            break;
                        case 'D':
                            l1.displayBooks(library);
                            break;
                        default:
                            Environment.Exit(0);
                            break;





                    }
                }
                else if (userType == 'R')
                {

                }
            }
            
               



            }
           
        }
    }

