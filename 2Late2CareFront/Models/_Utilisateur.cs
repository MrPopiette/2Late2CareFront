namespace _2Late2CareFront.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Data.Entity;
    using System.Linq;

    public class _Utilisateur : DbContext
    {

        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        public string Pseudo { get; set; }

        [StringLength(50)]
        public string Password { get; set; }

        [StringLength(4)]
        public string Classe { get; set; }

        public virtual ICollection<_Ticket> Tickets { get; set; }

        public _Utilisateur()
            : base("name=_Utilisateur")
        {
            Tickets = new List<_Ticket>();
        }

        public class UtilisateurDBContext : DbContext
        {
            public virtual DbSet<_Utilisateur> Utilisateurs { get; set; }
        }
    }
}