using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entityLayer.concrete
{
    public class postTable
    {
        [Key]
        public int postId { get; set; }

        [StringLength(20)]
        public string postHeader { get; set; }

        [StringLength(10)]
        public string postDate { get; set; }

        [StringLength(100)]
        public string postDescription { get; set; }

        [StringLength(20)]
        public string RecipeHeader { get; set; }

        [MaxLength]
        public string RecipeValue { get; set; }

        [StringLength(100)]
        public string RecipeIngredients { get; set; }

        [StringLength(150)]
        public string ImagePath { get; set; }

        public int authorId { get; set; }

        [ForeignKey("authorId")]
        public virtual authorTable? Author { get; set; }
    }
}
