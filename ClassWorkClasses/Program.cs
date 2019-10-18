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
            Console.WriteLine("Welcome to TolchokInfo database. Here we have some information on Minsk city LARP movement");
                
            var clubsList = new ShowClubs();
            clubsList.ShowListOfClubs();

            var clubMembers = new ShowClubs();
            clubMembers.ShowClub();
            
            Console.WriteLine($"");
            






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

            Console.ReadLine();
        }
    }
}
