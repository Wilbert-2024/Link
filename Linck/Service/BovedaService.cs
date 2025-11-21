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
    class BovedaService : IBovedaService
    {
        private DBase _base = new ();

        public Boveda AddBoveda(Boveda boveda1)
        {
            _base.boveda.Add(boveda1);
            _base.SaveChanges();
            return boveda1;
        }

        public void DeleteBoveda(Boveda boveda1)
        {
            // Eliminar las link asociadas primero
            var Linkc1 = _base.linkss.Where(n => n.BovedaId == boveda1.id);
            _base.linkss.RemoveRange(Linkc1);

            _base.boveda.Remove(boveda1);
            _base.SaveChanges();
        }

        //para mostrar todas las bobedas que el usuario actual tiene creado
        public IEnumerable<Boveda> GetBoveda(int usuarioId)
        {
            return _base.boveda.Where(b => b.UsuarioId == usuarioId).ToList();
        }

        //para mostrar una bobeda especifico de un usuario
        public Boveda? GetBovedaById(int IdUser, string NombreBoveda)
        {
            return _base.boveda.FirstOrDefault(b => b.UsuarioId == IdUser && b.nombre_boveda == NombreBoveda);
        }

        public void UpdateBoveda(Boveda boveda1)
        {
            _base.Entry(boveda1).State = EntityState.Modified;
            _base.SaveChanges();
        }

        public bool BobedaExists(string nombreBoveda)
        {
            return _base.boveda.Any(b => b.nombre_boveda == nombreBoveda);
        }

        public Boveda? GetBovedaByNombre(string nombreBoveda)
        {
            return _base.boveda.FirstOrDefault(b => b.nombre_boveda == nombreBoveda);
        }

        public List<Boveda> ObtenerListaBoveda()
        {       
            return _base.boveda.ToList();
        }
        public string[] GetNombresBovedas(int idUsuario)
        {
            return _base.boveda.Where(b => b.UsuarioId == idUsuario).Select(b => b.nombre_boveda).ToArray();
        }

        public List<Boveda> ObtenerListaBoveda(int idUsuario)
        {
            throw new NotImplementedException();
        }
    }
}
