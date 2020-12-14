#nullable disable

namespace MagicTheGathering.Models
{
    public class CardTypeList
    {
        public int Id { get; set; }
        public int Card_Id { get; set; }
        public CardType Type { get; set; }
    }
}