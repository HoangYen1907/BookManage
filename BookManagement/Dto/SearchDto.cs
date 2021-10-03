using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookManagement.Dto
{
    public class SearchDto
    {
        public int PageNum { get; set; }
        public string Keyword { get; set; }
        public int ValuePage { get; set; } = 10;
    }
}
