using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteka.Models
{
    public class BooksModel
    {
        [Key]
        public int ID { get; set; }
        public string Title { get; set; }
        public string Authors { get; set; }
        public string Publishing { get; set; }
        public string ISBN { get; set; }
        public int Year { get; set; }
        public int Quantity { get; set; }
    }
}
