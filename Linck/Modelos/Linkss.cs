using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linck.Modelos
{
     class Linkss
    {
        public int Id { get; set; }
        public string Nom_link { get; set; }
        public string link { get; set; }
        public int BovedaId { get; set; }
        public int CategoriaId { get; set; }
        public byte[]? ImagenLink { get; set; }


        public virtual Boveda Boveda { get; set; }
        public virtual Categoria Categoria { get; set; }


    }
}
