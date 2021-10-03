using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookManagement.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }

        [Required]
        [MaxLength(100)]
        public string BookName { get; set; }

        [MaxLength(32)]
        public string Author { get; set; }

        public string Description { get; set; }

        public string BookImage { get; set; }

        public DateTime? CreateTime { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? ModifyTime { get; set; }
        public int? ModifyBy { get; set; }
    }
}
