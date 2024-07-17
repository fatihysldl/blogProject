using apiUI.Models.author;
using System.ComponentModel.DataAnnotations;

namespace apiUI.Models.post
{
    public class postModelView
    {
        
        public int postId { get; set; }
        public string postHeader { get; set; }
        public string postDate { get; set; }
        public string postDescription { get; set; }
        public string RecipeHeader { get; set; }
        public string RecipeValue { get; set; }
        public string RecipeIngredients { get; set; }
        public string ImagePath { get; set; }
        public int authorId { get; set; }
        public authorModelView author { get; set; }
    }
}
