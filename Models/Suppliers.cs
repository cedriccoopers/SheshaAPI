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
        public float SupplierLatitude { get; set; }
        public float SupplierLongitude { get; set; }
        public string SupplierImage { get; set; }
    }
}