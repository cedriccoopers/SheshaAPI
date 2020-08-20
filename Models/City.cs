using System.ComponentModel.DataAnnotations;

namespace SheshaAPI.Models
{
    public class City
    {
        [Key]
        public int CityID { get; set; }
        public int ProvinceID { get; set; }
        public string Name { get; set; }
    }
}