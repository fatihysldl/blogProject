using System.ComponentModel.DataAnnotations;

namespace apiUI.Models.author
{
    public class authorModelView
    {
        public int authorId { get; set; }
        public string authorName { get; set; }
        public string mail { get; set; }
        public string password { get; set; }
    }
}
