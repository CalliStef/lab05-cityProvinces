using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lab05.Models
{
    public class City
    {

       public int CityId { get; set; } 
       public string CityName { get; set; }
       public int Population { get; set; }

    //    public string ProvinceCode { get; set; }

    //    [ForeignKey("ProvinceCode")]
        public string? Province { get; set; }
    }
}