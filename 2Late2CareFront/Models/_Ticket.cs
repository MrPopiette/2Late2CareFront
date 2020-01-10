namespace _2Late2CareFront.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Data.Entity;
    using System.Linq;

    public class _Ticket : DbContext
    {
        [Key]
        public int Id { get; set; }

        [StringLength(500)]
        public string DetailTexte { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Date { get; set; }

        [StringLength(50)]
        public string Titre { get; set; }

        public virtual ICollection<_Tag> MotsCles { get; set; }

        public _Ticket()
            : base("name=_Ticket")
        {
            MotsCles = new List<_Tag>();
        }

        public class TicketDBContext : DbContext
        {
            public virtual DbSet<_Ticket> Tickets { get; set; }
        }

    }
}