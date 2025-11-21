using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linck.Modelos
{
     class Categoria
    {
        public int Id { get; set; }
        public string nombre_Categoria { get; set; }
        public byte[]? ImagenUser { get; set; }
        public int NumeroCategoria{ get; set; }
   


        public virtual ICollection<Linkss> liks { get; set; } = new List<Linkss>();

    }
}
