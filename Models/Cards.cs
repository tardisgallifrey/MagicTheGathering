using System.Collections.Generic;

namespace MagicTheGathering.Models
{
    public class Cards
    {
        //This is the primary database file for magic cards
        //All the properties here are fields in SQL server table Cards

        public Cards(string name, int rarity, string set_Name)
        {
            //Some thing about using nullable fields meant that
            //Several required fields needed to be filled at 
            //construction.
            //So, I added the minimum into a constructor and it helps
            this.Name = name;
            this.Rarity = rarity;
            this.Set_Name = set_Name;

        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Rarity { get; set; }
        public string Set_Name { get; set; }
        public int? Power { get; set; }
        public int? Toughness { get; set; }
        public string? Rules_Text { get; set; }
        public List<ManaColorList> ManaColors { get; set; } = new List<ManaColorList>();
        public List<CardTypeList> Type { get; set; } = new List<CardTypeList>();
        public List<SuperTypeList>? SuperTypes { get; set; } = new List<SuperTypeList>();
        public List<SubTypeList>? CreatureSub { get; set; } = new List<SubTypeList>();
        public int? Number_in_Set { get; set; }
        public int? Set_Size { get; set; }

        public string? FlavorText { get; set; }
    }
}