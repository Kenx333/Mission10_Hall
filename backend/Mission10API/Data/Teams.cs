using System.ComponentModel.DataAnnotations;

namespace Mission10API.Data
{
    public class Teams
    {
        [Key]
        public int TeamId { get; set; }
        public string TeamName { get; set; }
        public string CaptainId { get; set; }
    }
}
