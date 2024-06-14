using System.ComponentModel.DataAnnotations;

namespace ReportAdminStaff.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        [MaxLength(30)]
        public string CustomerName { get; set; } = "";
        [MaxLength(30)]
        public string CustomerEmail { get; set; } = "";
        [MaxLength(30)]
        public string Phone_number { get; set; } = "";
        [MaxLength(30)]
        public string CustomerPassword { get; set; } = "";

        public Customer()
        {

        }
    }
}
