using DucShop.Model.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DucShop.Model.Models
{
    [Table("PostCategories")]

   public class PostCategory : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        [MaxLength(256)]
        public string Name { set; get; }

        [Required]
        [Column(TypeName ="varchar")]
        [MaxLength(256)]
        public string Alias { set; get; }

        [MaxLength(500)]
        public string Description { set; get; }

        public int? ParenID { set; get; }

        public int? DisplayOrder { set; get; }

        [MaxLength(500)]
        public string Image { set; get; }

        public bool? HomePlag { set; get; }

        public virtual IEnumerable<Post> Post { set; get; }
    }
}
