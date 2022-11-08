using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FBClientes.Models
{
    public class PersonaCliente
    {
        public int Id { get; set; }
        [Required]
        public String Name { get; set; }
        [Required]
        public String Lastn { get; set; }
        [Required]
        public int document { get; set; }
        [Required]
        public int phone { get; set; }
        [Required]
        public String Adress { get; set; }
        [Required]
        public String State { get; set; }
        [Required]
        public String City { get; set; }
    }
}
