using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linck.Modelos
{
    class Boveda
    {
        public int id { get; set; }
        public string nombre_boveda { get; set; }
        public string contrasena { get; set; }
        public int UsuarioId { get; set; }

        public virtual Usuario Usuario { get; set; }

        public virtual ICollection<Linkss> Linkss { get; set; } = new List<Linkss>();


    }
}
