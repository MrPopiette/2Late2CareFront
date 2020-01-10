namespace _2Late2CareFront.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Data.Entity;
    using System.Linq;

    public class _Tag : DbContext
    {

        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        public string Libelle { get; set; }


        public _Tag()
            : base("name=_Tag")
        {
        }
        public class TagDBContext : DbContext
        {
            public virtual DbSet<_Tag> Tags { get; set; }
        }
    }

}