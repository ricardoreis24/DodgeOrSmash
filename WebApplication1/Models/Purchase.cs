using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Purchase
    {

        public Purchase()
        {
            Skins = new HashSet<Skins>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PurchaseID { get; set; }

        public float ValorDaCompra { get; set; }

        [ForeignKey("Users")]
        public int UserID { get; set; }
        public virtual Users Users { get; set; }

        [Column(TypeName = "datetime")]
        [Display(Name = "Purchase Date")]
        public DateTime Data { get; set; }

        public ICollection<Skins> Skins { get; set; }
    }
}