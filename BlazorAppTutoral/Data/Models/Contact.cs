using System.ComponentModel.DataAnnotations;

namespace BlazorAppTutoral.Data.Models
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }

        public string FullName { get; set; }

        public string Email { get; set; }

        public string PhoneNumber{ get; set; }

        public bool IsSelected { get; set; }

    }
}
