using CityLibrarySystem.Helpers;
using CityLibrarySystem.Models;
using CityLibrarySystem.Services;

namespace CityLibrarySystem
{
    internal class Program
    {

        static void Main(string[] args)
        {
            LibraryBranch branch = DataSeeder.Seed();
            var display = new DisplayService();
            var librarySerivce = new LibraryService(branch,display);
            bool running = true;
            while (running)
            {
                try
                {
                    ConsoleHelper.ShowMenu();
                    string? choice = Console.ReadLine()?.Trim();
                    Console.WriteLine();
                    switch(choice)
                    {
                        case "1":display.ShowBranchInfo(branch);break;
                        case "2":display.ShowAllUsers(branch);break;
                        case "3":display.ShowAvailableCopies(branch);break;
                        case "4":display.ShowAllCopies(branch);break;
                        case "5": librarySerivce.HandleBorrow();break;
                        case "6": librarySerivce.HandleReturn();break;
                        case "7": librarySerivce.HandleHistory();break;
                        case "8": librarySerivce.HandleRegisterMember();break;
                        case "0":
                            Console.WriteLine("GoodBye");
                            running = false;
                            break;
                        default:
                            Console.WriteLine("Invalid Option Try Again");
                            break;
                    }
                }
                catch (InvalidOperationException ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    Console.ResetColor();
                }
                Console.WriteLine("Press Enter To continue");
                Console.ReadLine();

                Console.Clear();

            }

        }
    }
}
