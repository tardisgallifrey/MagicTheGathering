using System.Collections.Generic;

namespace MagicTheGathering.Models
{
    public class Cards
    {

        public Cards(string name, int power, int toughness, string rules_Text)
        {
            //this.Id = id;
            this.Name = name;
            this.Power = power;
            this.Toughness = toughness;
            this.Rules_Text = rules_Text;

        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Power { get; set; }
        public int Toughness { get; set; }
        public string Rules_Text { get; set; }
        public List<ManaColorList> ManaColors { get; set; } = new List<ManaColorList>();
        public List<CardTypeList> Type { get; set; } = new List<CardTypeList>();
        public List<SuperTypeList>? SuperTypes { get; set; } = new List<SuperTypeList>();
        public List<SubTypeList>? CreatureSub { get; set; } = new List<SubTypeList>();


        // A few of the above fields are optional
        // All of the fields below are optional
        public bool? HasDeathTouch { get; set; }
        public bool? HasLifeLink { get; set; }
        public string? Set_Name { get; set; }
        public int? Number_in_Set { get; set; }
        public int? Set_Size { get; set; }
        public bool? IsFoil { get; set; }
        public bool? IsPromo { get; set; }
        public string? FlavorText { get; set; }
    }
}