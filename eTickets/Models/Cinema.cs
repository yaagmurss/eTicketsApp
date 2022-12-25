using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; } 
        public int Logo { get; set; }
        public int Name { get; set; }
        public int Description { get; set; }
    }
}
