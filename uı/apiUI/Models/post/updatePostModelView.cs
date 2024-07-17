﻿using apiUI.Models.author;

namespace apiUI.Models.post
{
    public class updatePostModelView
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
