#nullable disable

namespace MagicTheGathering.Models
{
    public class SuperTypeList
    {
        public int Id { get; set; }
        public int Card_Id { get; set; }

        public SuperTypes TypeId { get; set; }
    }
}