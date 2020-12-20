namespace MagicTheGathering.Models
{
    public class Keywords
    {
        // This is a table/property list of all the 
        // Rules Text Keywords that can be found on cards
        // or is a type of card.  
        // We link to a card ID for those that have this feature.
        public int Id { get; set; }
        public int Card_Id { get; set; }
        public bool Amass1 { get; set; }
        public bool Amass2 { get; set; }
        public bool Amass3 { get; set; }
        public bool Amass4 { get; set; }
        public bool AmassX { get; set; }
        public bool Cascade { get; set; }
        public bool DeathTouch { get; set; }
        public bool Defender { get; set; }
        public bool Devour1 { get; set; }
        public bool Devour2 { get; set; }
        public bool DevourX { get; set; }
        public bool Flash { get; set; }
        public bool Flying { get; set; }
        public bool Haste { get; set; }
        public bool Hexproof { get; set; }
        public bool Infect { get; set; }
        public bool LifeLink { get; set; }
        public bool Menace { get; set; }
        public bool Mutate { get; set; }
        public bool Persist { get; set; }
        public bool Proliferate { get; set; }
        public bool Scry1 { get; set; }
        public bool scry2 { get; set; }
        public bool Scry3 { get; set; }
        public bool Scry4 { get; set; }
        public bool ScryX { get; set; }
        public bool Shadow { get; set; }
        public bool Shroud { get; set; }
    
        public bool First_Strike { get; set; }
        public bool Double_Strike { get; set; }
        public bool Trample { get; set; }
        public bool Vigilance { get; set; }
        public bool Undying { get; set; }
        public bool Unearth { get; set; }
        public bool? IsFoil { get; set; }
        public bool? IsPromo { get; set; }
    }
}