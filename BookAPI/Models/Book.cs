using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookAPI.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(30)")]
        public string  Title { get; set; }

        [Column(TypeName = "nvarchar(40)")]
        public string Author { get; set; }

        [Column(TypeName = "nvarchar(255)")]
        public string Description { get; set; }
    }
}
