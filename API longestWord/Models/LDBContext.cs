using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace API_longestWord.Models
{
  
    
        public class LDBContext : DbContext
        {
            public LDBContext() : base("MyConnectionString")
            {
                Database.SetInitializer<LDBContext>(null);
            }

            public DbSet<CLongest> LModels { get; set; }
        }

    }
