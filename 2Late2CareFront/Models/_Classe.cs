namespace _2Late2CareFront.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Data.Entity;
    using System.Linq;

    public class _Classe : DbContext
    {

        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        public string Libelle { get; set; }


        public _Classe()
            : base("name=_Classe")
        {
        }

        public class ClasseDBContext : DbContext
        {
            public virtual DbSet<_Classe> Classes { get; set; }
        }
        
    }
}