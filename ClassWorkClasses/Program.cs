using ClassWorkClasses.Extensions;
using ClassWorkClasses.Models;
using ClassWorkClasses.Processing;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ClassWorkClasses.Models.TolchokEnums;

namespace ClassWorkClasses
{
    class Program
    {
        static BrigadaMembers brigMemberName;
        static WeaponSize brgMmbrWpnSz;
        static WeaponMaterial brgMmbrWpnMtr;
        static WeaponType brgMmbrWpnTp;
        static VisitedGames brgVisGames;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to TolchokInfo database. Here we have some information on Minsk city LARP movement");

            var clubsList = new ShowClubs();
            clubsList.ShowListOfClubs();

            var clubMembers = new ShowClubs();
            clubMembers.ShowClub();

            BrigadaMembers brigMemberName = (BrigadaMembers)1;
            WeaponSize brgMmbrWpnSz = 0;
            WeaponMaterial brgMmbrWpnMtr = 0;
            WeaponType brgMmbrWpnTp = 0;
            VisitedGames brgVisGames = 0;

            var brigMember1 = new Tolchok();
            brigMember1.Name = brigMemberName.ToString();
            brigMember1.FavWeapon = $"{brgMmbrWpnSz} {brgMmbrWpnMtr} {brgMmbrWpnTp}";
            brigMember1.GamesVisited = brgVisGames.ToString();
            Console.WriteLine(brigMember1.PrepareReport());









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
