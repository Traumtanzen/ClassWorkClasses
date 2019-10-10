using ClassWorkClasses.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWorkClasses.Processing
{
    public class ShowClubs
    {
        public string List => ShowListOfClubs();

        public string ShowListOfClubs()
        {
            string showListOfClubs = Console.ReadLine();

            switch (showListOfClubs.ToLower())
            {
                case "l":
                    foreach (ClubNames club in (ClubNames[])Enum.GetValues(typeof(ClubNames)))
                    {
                        Console.WriteLine($"{(int)club} - {club}");
                    }
                    break;
                case "q":
                    {
                        Console.WriteLine("Bye!");
                    }
                    break;
                default:
                    Console.WriteLine("Press <L> for list of clubs or <Q> to quit");
                    break;
            }
            return showListOfClubs;
        }
    }
}
