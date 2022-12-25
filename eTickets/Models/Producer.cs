using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Producer
    {
        [Key]
        public int MyProperty { get; set; }
        public string ProfilePicture { get; set; }
        public int FullName { get; set; }
        public int Bio { get; set; }
    }
}
