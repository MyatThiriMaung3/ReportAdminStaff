using System.ComponentModel.DataAnnotations;

namespace ReportAdminStaff.Models
{
    public class Store
    {
        public int StoreId { get; set; }
        [MaxLength(30)]
        public string StoreName { get; set; } = "";
        [MaxLength(30)]
        public string StoreLocation { get; set; } = "";

        public Store()
        {

        }
    }
}
