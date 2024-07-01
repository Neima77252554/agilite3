using System.ComponentModel.DataAnnotations;

namespace Agilite_2
{
    public class PhoneInfo
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }

    }
}
