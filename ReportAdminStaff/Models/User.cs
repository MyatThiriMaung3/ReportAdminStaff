using System.ComponentModel.DataAnnotations;

namespace ReportAdminStaff.Models
{
    public class User
    {
        public int UserId { get; set; }
        [MaxLength(30)]
        public string Username { get; set; } = "";
        [MaxLength(30)]
        public string Email { get; set; } = "";
        [MaxLength(30)]
        public string Password { get; set; } = "";
        [MaxLength(30)]
        public string PhoneNumber { get; set; } = "";
        [MaxLength(10)]
        public string UserType { get; set; } = "";

        public User() {

        }
    }
}
