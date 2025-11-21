using Linck.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linck.Service.Interface
{
    interface ILinkService
    {
        IEnumerable<Linkss> ListaLinkssEspecificos(int usuarioId, int bodegaId, int categoriaId);
        Linkss? GetLinkssById(int Id, int id_categoria, int id_bodega);
        Linkss AddLinkss(Linkss lick);
        void UpdateLinkss(Linkss lick);
        void DeleteLinkss(Linkss lick);
        List<Linkss> ObtenerListaLink();

        Linkss? ObtenerdatosconID(int? id);


        bool LinkExists(string NombreLink); // en uso

        // Me permite tener acceso a todos los campos de la tabla
       Linkss? GetLinkByNombre(string NombreLink); // en uso


    }
}
