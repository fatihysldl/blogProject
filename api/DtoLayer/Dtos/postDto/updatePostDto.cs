using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entityLayer.concrete;

namespace DtoLayer.Dtos.postDto
{
    public class updatePostDto
    {
        public int postId { get; set; }
        [Required(ErrorMessage = "Please fill in the 'header' field")]
        [StringLength(20, ErrorMessage = "please write less than 20 character")]
        public string postHeader { get; set; }

        [Required(ErrorMessage = "Please fill in the 'date' field")]
        [StringLength(10, ErrorMessage = "please write less than 10 character")]
        public string postDate { get; set; }

        [Required(ErrorMessage = "Please fill in the 'Post Description' field")]
        [StringLength(100, ErrorMessage = "please write less than 100 character")]
        public string postDescription { get; set; }

        [Required(ErrorMessage = "Please fill in the 'Recipe Header' field")]
        [StringLength(20, ErrorMessage = "please write less than 20 character")]
        public string RecipeHeader { get; set; }
        [Required(ErrorMessage = "Please fill in the 'Recipe Value' field")]
        [MaxLength]
        public string RecipeValue { get; set; }

        [Required(ErrorMessage = "Please fill in the 'Recipe Ingredients' field")]
        [StringLength(100, ErrorMessage = "please write less than 100 character")]
        public string RecipeIngredients { get; set; }

        [StringLength(150)]
        public string ImagePath { get; set; }

        [Required(ErrorMessage = "Please fill in the 'Author' field")]
        public int authorId { get; set; }

        [ForeignKey("authorId")]
        public virtual authorTable? Author { get; set; }
    }
}
