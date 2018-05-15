using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class ScoreBoard
    {
        [Key]
        public int pontID { get; set; }

        public float Pontuacao { get; set; }

        [ForeignKey("User")]
        public int UserFK { get; set; }
        public virtual Users User { get; set; }
        
    }
}