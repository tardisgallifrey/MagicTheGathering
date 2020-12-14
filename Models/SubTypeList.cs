#nullable disable

namespace MagicTheGathering.Models
{
    public class SubTypeList
    {
        public int Id { get; set; }
        public int Card_Id { get; set; }
        public CreatureSubType SubType { get; set; }
    }
}