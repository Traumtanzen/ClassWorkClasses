using ClassWorkClasses.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ClassWorkClasses.Models.TolchokEnums;

namespace ClassWorkClasses.Processing
{
    public class ShowClubs
    {
        public string ShowListOfClubs()
        {
            Console.WriteLine("\nPress <L> to see the list of LARP clubs or <Q> to quit.");
            var showListOfClubs = Console.ReadKey();
            while (true)
            {
                switch (showListOfClubs.Key)
                {
                    case ConsoleKey.L:
                        Console.WriteLine("\nHere are the known clubs:");
                        foreach (ClubNames club in (ClubNames[])Enum.GetValues(typeof(ClubNames)))
                        {
                            Console.WriteLine($"{(int)club} - {club}");
                        }
                        break;
                    case ConsoleKey.Q:
                        {
                            Console.WriteLine("\nBye!");
                        }
                        break;
                    default:
                        ShowListOfClubs();
                        break;
                }
                return Convert.ToString(showListOfClubs);
            }
        }
        public string ShowClub()
        {
            Console.WriteLine("\nPlease choose a club from the list by entering its number to see its members or anything else to go back");
            string showMembers = Console.ReadLine();
            BrigadaMembers brigHead = 0;
            OsoznanieMembers osozHead = (OsoznanieMembers)1;
            switch (showMembers)
            {
                case "0":
                    foreach (BrigadaMembers member in (BrigadaMembers[])Enum.GetValues(typeof(BrigadaMembers)))
                    {
                        Console.WriteLine($"{(int)member} - {member}");
                    }
                    Console.WriteLine($"\nThe head of the club is {brigHead}");
                    break;
                case "1":
                    foreach (OsoznanieMembers member in (OsoznanieMembers[])Enum.GetValues(typeof(OsoznanieMembers)))
                    {
                        Console.WriteLine($"{(int)member} - {member}");
                    }
                    Console.WriteLine($"\nThe head of the club is {osozHead}");
                    break;
                case "2":
                    foreach (UnsortedMembers member in (UnsortedMembers[])Enum.GetValues(typeof(UnsortedMembers)))
                    {
                        Console.WriteLine($"{(int)member} - {member}");
                    }
                    Console.WriteLine($"\nNo club - no head.");
                    break;
                default:
                    ShowListOfClubs();
                    break;
            }
            return showMembers;
        }
    }
}
