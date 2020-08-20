using System.ComponentModel.DataAnnotations;
using SheshaAPI.Models;

namespace SheshaAPI.Models
{
    public class Province
    {
        [Key]
        public int ProvinceID { get; set; }
        public string Name { get; set; }
    }
}