using ClassWorkClasses.Extensions;
using ClassWorkClasses.Models;
using ClassWorkClasses.Processing;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWorkClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to TolchokInfo database. Here we have some information on Minsk city LARP movement" +
                "\nPress <L> to see the list of LARP clubs or <Q> to quit.");
            var clubsList = new ShowClubs();
            clubsList.ShowListOfClubs();
            Console.WriteLine("Please choose a club from the list by entering its number to see its members");




                



            //var kris = new Tolchok();
            //kris.Name = "Kris";
            //kris.DateOfBirth = new DateTime(1994, 6, 7);
            //Console.WriteLine("select your club");
            //foreach (ClubNames club in (ClubNames[])Enum.GetValues(typeof(ClubNames)))
            //{
            //    Console.WriteLine($"{(int)club} - {club}");
            //}
            //kris.Club = (ClubNames) int.Parse(Console.ReadLine());
            //Console.WriteLine(kris.PrepareReport());
            //if (kris.Club == ClubNames.Brigada)
            //{
            //    Console.WriteLine("100% Dexter enrolled!");
            //}
            //else if (kris.Club == ClubNames.DSE)
            //{
            //    Console.WriteLine("Ex Vice Minister is your head");
            //}
            //else 
            //{ 
            //    Console.WriteLine("noname club"); 
            //}

            //var newDate = new DateTime(1945, 5, 9);
            //Console.WriteLine($"{newDate.GetYearsDiff(DateTime.Now)} years from victory of {newDate.GetCentury()} century greatest war"); 
            Console.ReadLine();
        }
    }
}
