using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ProductDropdown.Models
{
    public partial class DataModel : DbContext
    {
        public DataModel()
            : base("name=DataModel")
        {
        }

        public virtual DbSet<tblCategory> tblCategories { get; set; }
        public virtual DbSet<tblProduct> tblProducts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tblCategory>()
                .HasMany(e => e.tblProducts)
                .WithRequired(e => e.tblCategory)
                .WillCascadeOnDelete(false);
        }
    }
}
