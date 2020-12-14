#nullable disable

namespace MagicTheGathering.Models
{
    public class ManaColorList
    {
        public int Id { get; set; }
        public int Card_Id { get; set; }

        public CardColors ManaColor { get; set; }

        public int Cost { get; set; }
    }
}