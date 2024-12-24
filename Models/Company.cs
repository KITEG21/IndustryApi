using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IndustryApi.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Sector { get; set; } = string.Empty;
        public int TotalEmployees { get; set; }
        public long TotalStock { get; set; }
        public long Debt { get; set; }
        
        [MaxLength(50)]
        public string Owner { get; set; } = string.Empty;

    }
}