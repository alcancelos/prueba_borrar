using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba_Borrar.Models
{
    public class Persona
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public int IdCategoria { get; set; }


        [ForeignKey("IdCategoria")]
        public Categoria Categoria { get; set; }
    }
}
