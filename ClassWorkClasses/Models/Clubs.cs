using ClassWorkClasses.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWorkClasses
{
    public class Clubs
    {
        public string clubName { get; set; }
        public string clubHead { get; set; }
        public string ClubMembers { get; set; }

        public string BrigadaHead()
        {
            string head = "Dexter";
            return head;
        }
        public List<Tolchok> member = new List<Tolchok>();
        member.Add(new Tolchok() {Tolchok.Name = "Dexter"} ) 
        
        
        


    }
}
