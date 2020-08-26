using System.ComponentModel.DataAnnotations;

namespace SheshaAPI.Models
{
    public class Suppliers
    {
        [Key]
        public int SuppliersID { get; set; }
        public string SupplierName { get; set; }
        public string SupplierDescription { get; set; }
        public int SupplierRating { get; set; }
        public int SupplierReview { get; set; }
        public decimal SupplierLatitude { get; set; }
        public decimal SupplierLongitude { get; set; }
        public string SupplierImage { get; set; }
    }
}