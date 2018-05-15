using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Skins
    {
        //dados da tabela skins

        public Skins()
        {
            Purchase = new HashSet<Purchase>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Item identifier")]
        public int SkinsID { get; set; }

        [Required(ErrorMessage = "O {0} é de preencimento obrigatório...")]
        [Display(Name = "Is Item Available")]
        public bool IsActive { set; get; }

        [Required(ErrorMessage = "O {0} é de preencimento obrigatório...")]
        [StringLength(30)]
        [Display(Name = "Item Name")]
        public string Name { set; get; }

        [Required(ErrorMessage = "O {0} é de preencimento obrigatório...")]
        [Display(Name = "Item Price")]
        public float Price { get; set; }

        //[Required(ErrorMessage = "O {0} é de preencimento obrigatório...")]
        [Display(Name = "Skin Image")]
        public string ImagePath { get; set; }

        // especificar relacionamentos
        public ICollection<Purchase> Purchase { get; set; }
    }
}