using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entityLayer.concrete
{
    public class authorTable
    {
        [Key]
        public int authorId { get; set; }
        [StringLength(25)]
        public string authorName { get; set; }

        [StringLength(100)]
        public string mail { get; set; }

        [StringLength(25)]
        public string password { get; set; }

        public List<postTable>? Posts { get; set; }
    }
}
