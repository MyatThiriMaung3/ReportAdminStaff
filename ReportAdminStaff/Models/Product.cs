using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ReportAdminStaff.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        [MaxLength(255)]
        public string ProductBarcode { get; set; } = "";
        [MaxLength(30)]
        public string ProductName { get; set; } = "";
        [Precision(16, 2)]
        public decimal ImportPrice { get; set; }
        [Precision(16, 2)]
        public decimal RetailPrice { get; set; }
        [MaxLength(30)]
        public string Category { get; set; } = "";
        public DateTime CreatedAt { get; set; }

        public Product()
        {

        }
    }
}
