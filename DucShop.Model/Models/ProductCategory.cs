﻿using DucShop.Model.Abstract;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DucShop.Model.Models
{
    [Table("ProductCategories")]
    public class ProductCategory : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [MaxLength(50)]
        public string Name { set; get; }
        [MaxLength(50)]
        public string Alias { set; get; }
        [MaxLength(256)]
        public string Description { set; get; }

        public int? ParentID { set; get; }
        public int? DisplayOrder { set; get; }
        [MaxLength(256)]
        public string Image { set; get; }
        public bool? HomeFlag { set; get; }

        public virtual IEnumerable<Product> Products { set; get; }
    }
}