using Linck.Data;
using Linck.Modelos;
using Linck.Service.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;

namespace Linck.Service
{
    class CategoriaService : ICategoriaService
    {
        private DBase _base = new();

        public Categoria AddCategoria(Categoria cate)
        {
            _base.categorias.Add(cate);
            _base.SaveChanges();
            return cate;
        }

        public void DeleteCategoria(Categoria cate)
        {
            // Eliminar los lick asociadas primero
            var Linkc1 = _base.linkss.Where(n => n.CategoriaId == cate.Id);
            _base.linkss.RemoveRange(Linkc1);

            _base.categorias.Remove(cate);
            _base.SaveChanges();
        }

        public IEnumerable<Categoria> GetCategoria()
        {
            return _base.categorias.ToList();
        }

        public Categoria? GetcategoriaById(int numroCategoria, string nomobreCategori)
        {
            return _base.categorias.FirstOrDefault(c => c.NumeroCategoria == numroCategoria && c.nombre_Categoria == nomobreCategori);
        
        }

        public void UpdateCategoria(Categoria cate)
        {
            _base.Entry(cate).State = EntityState.Modified;
            _base.SaveChanges();
        }

        public bool CategoriaExists(string nombreCategoria)
        {
            return _base.categorias.Any(u => u.nombre_Categoria == nombreCategoria);
        }

        public Categoria? GetCategoriaByNombre(string nombreCategoria)
        {
            return _base.categorias.FirstOrDefault(c => c.nombre_Categoria == nombreCategoria);
        }

        public string[] GetNombresCategorias()
        {
            return _base.categorias.Select(c => c.nombre_Categoria).ToArray();
        }

        public IEnumerable<Categoria> GetNombresCategoria(int idUsuario)
        {
            return _base.categorias.Where(c => c.NumeroCategoria == idUsuario).ToList();
        }


        // usamos un count
        public int ContarCategoriasPorUsuario(int usuarioId)
        {
            if (usuarioId != 0) { return _base.categorias.Count(c => c.NumeroCategoria == usuarioId); }

            else  { return _base.categorias.Count(c => c.ImagenUser != null); }





        }


    }
}
