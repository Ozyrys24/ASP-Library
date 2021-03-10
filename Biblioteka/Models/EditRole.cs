using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteka.Models
{
    public class EditRole
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Role name is Requied")]
        public string RoleName { get; set; }
        public List<string> Users { get; set; }
    }
}
