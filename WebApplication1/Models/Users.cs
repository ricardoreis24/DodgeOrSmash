using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{   
    
    //Atributos para a base de dados dos Users
    public class Users
    {
        [Key]
        public int UserID { get; set; }

        [Required]

        public float Wallet { get; set; }

        public float Score { get; set; }

        public float ActiveSkin { get; set; }

        public string Role { get; set; }

    }
}