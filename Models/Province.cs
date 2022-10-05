using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lab05.Models
{
    public partial class Province
    {
        [Key]
        public string ProvinceCode { get; set; }
        public string ProvinceName { get; set; }

        // public string Cities { get; set; }

        public List<City>? Cities { get; set; }
    }
}