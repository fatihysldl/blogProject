using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLayer.Dtos.authorDto
{
    public class updateAuthorDto
    {
        public int authorId { get; set; }

        [Required(ErrorMessage = "Please fill in the Name field")]
        [StringLength(25, ErrorMessage = "please write less than 25 character")]
        public string authorName { get; set; }
        [Required(ErrorMessage = "Please fill in the Mail field")]
        [StringLength(100, ErrorMessage = "please write less than 100 character")]
        public string mail { get; set; }

        [Required(ErrorMessage = "Please fill in the Password field")]
        public string password { get; set; }
    }
}
