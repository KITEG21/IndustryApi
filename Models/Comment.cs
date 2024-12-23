using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IndustryApi.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Content { get; set; } = string.Empty;
        public DateTime CreatedOn { get; set;} = DateTime.Now;

        public Company? Company { get; set; }
        public int CompanyId { get; set; }

    }
}