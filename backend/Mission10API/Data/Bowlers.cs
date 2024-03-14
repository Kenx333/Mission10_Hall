using System.ComponentModel.DataAnnotations;

namespace Mission10API.Data
{
    public class Bowlers
    {
        [Key]
        public int BowlerId { get; set; }
        public string BowlerFirstName { get; set; }
        public string? BowlerMiddleInit { get; set; }
        public string BowlerLastName { get; set; }
        public int TeamId { get; set; }
        public Teams Teams { get; set; }
        public string BowlerAddress { get; set; }
        public string BowlerCity { get; set; }
        public string BowlerState { get; set; }
        public int BowlerZip { get; set; }
        public string BowlerPhoneNumber { get; set; }


    }
}
