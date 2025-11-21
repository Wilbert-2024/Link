using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linck.Modelos
{
     class Usuario
    {
        public int Id { get; set; }
        [Required, MaxLength(80, ErrorMessage = "Esta excediendo el numero de caracter valido")]
        public string Nombre { get; set; } = string.Empty;

        [Required, MaxLength(350, ErrorMessage = "La constraseña")]

        public string password { get; set; } = string.Empty;

        public string correoElectronico { get; set; } = string.Empty;

        public  byte[]? ImagenUser {  get; set; }



        public virtual ICollection<Boveda> boveda { get; set; } = new List<Boveda>();

    }
}
