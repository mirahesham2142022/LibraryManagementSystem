using System;

namespace LibraryProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome to Our library");
            library library = new library();
            char userType;
            Console.WriteLine("Hello ! Enter your name");
            string name = Console.ReadLine();
            Librarian l1;

            do
            {
                Console.WriteLine("Are you librarian or User (L/R)");
            } while (!char.TryParse(Console.ReadLine().ToUpper(), out userType) || (userType != 'L' && userType != 'R'));

            while (true)
            {
                if (userType == 'L')
                {
                    l1 = new Librarian(name);
                    Console.WriteLine($"Welcome {l1.Name}");

                    Console.WriteLine("Do you want to add book (A), Remove book (R), Display (D), Exit (E)");
                    char LibrarianChoice = Console.ReadLine()?.ToUpper()[0] ?? 'O';

                    switch (LibrarianChoice)
                        {
                            case 'A':
                                Console.WriteLine("Enter Book Details: ID");
                                if (!int.TryParse(Console.ReadLine(), out int Id))
                                {
                                    Console.WriteLine("Invalid ID. Please enter a valid number.");
                                    break;
                                }

                                Console.WriteLine("Title:");
                                string Title = Console.ReadLine();

                                Console.WriteLine("Author:");
                                string Author = Console.ReadLine();

                                Console.WriteLine("Year:");
                                if (!int.TryParse(Console.ReadLine(), out int Year))
                                {
                                    Console.WriteLine("Invalid Year. Please enter a valid number.");
                                    break;
                                }

                                Book book = new Book(Id, Title, Author, Year);
                                l1.AddBook(book, library);
                                break;

                            case 'R':
                            Console.WriteLine("Enter the ID of the book you want to remove:");
                            if (int.TryParse(Console.ReadLine(), out int removeId))
                            {
                                l1.removeBook(removeId, library);
                            }
                            else
                            {
                                Console.WriteLine("Invalid ID.");
                            }
                            break;

                        case 'D':
                            l1.displayBooks(library);
                            break;

                        case 'E':
                            Console.WriteLine("Exiting the system. Goodbye!");
                            return;

                        default:
                            Console.WriteLine("Invalid choice, please try again.");
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
