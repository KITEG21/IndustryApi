using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using  IndustryApi.Models;

namespace IndustryApi.DataBase
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext()  
        {
            
        }

        public DbSet<Company> Companies{ get; set; }

    }
}