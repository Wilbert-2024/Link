using Linck.Data;
using Linck.Modelos;
using Linck.Service.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Linck.Service
{
    class LinkService : ILinkService
    {
        private DBase _base = new();
        public Linkss AddLinkss(Linkss lick)
        {
            _base.linkss.Add(lick);
            _base.SaveChanges();
            return lick;
        }

        public void DeleteLinkss(Linkss lick)
        {
            _base.linkss.Remove(lick);
            _base.SaveChanges();
        }

        public Linkss? GetLinkByNombre(string NombreLink)
        {
            return _base.linkss.FirstOrDefault(L => L.Nom_link == NombreLink);
        }

        public Linkss? GetLinkssById(int Id, int id_categoria, int id_bodega)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Linkss> ListaLinkssEspecificos(int usuarioId, int bodegaId, int categoriaId)
        {
            if (usuarioId != 0)
            {
                var linksFiltrados = _base.linkss.Where(l => l.BovedaId == bodegaId && l.CategoriaId == categoriaId && _base.boveda.Any(b => b.id == l.BovedaId && b.UsuarioId == usuarioId)).ToList();

                return linksFiltrados;
            } else {
                var linksFiltrados = _base.linkss.Where(l => l.BovedaId == bodegaId && l.CategoriaId == categoriaId).ToList();

                return linksFiltrados;
            }
        }


        public bool LinkExists(string NombreLink)
        {
            return _base.linkss.Any(l => l.Nom_link == NombreLink);
        }

        public void UpdateLinkss(Linkss lick)
        {
            _base.Entry(lick).State = EntityState.Modified;
            _base.SaveChanges();
        }

        public List<Linkss> ObtenerListaLink()
        {
        
            return _base.linkss.ToList();
        }

       public Linkss? ObtenerdatosconID(int? id)
        {
          
            return _base.linkss.FirstOrDefault( L => L.Id == id);


        }

    }
}
