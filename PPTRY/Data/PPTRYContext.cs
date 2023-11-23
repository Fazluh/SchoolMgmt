using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PPTRY.Data
{
    public class PPTRYContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public PPTRYContext() : base("name=PPTRYContext")
        {
        }

        public System.Data.Entity.DbSet<PPTRY.Student> Students { get; set; }

        public System.Data.Entity.DbSet<PPTRY.Class> Classes { get; set; }

        public System.Data.Entity.DbSet<PPTRY.Subject> Subjects { get; set; }
    }
}
