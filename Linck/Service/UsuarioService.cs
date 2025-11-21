using Linck.Data;
using Linck.Modelos;
using Linck.Service.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linck.Service
{
     class UsuarioService : IUsuarioService
    {
        public bool IsCorreoExists(string correo)
        {
            using var conect = new DBase();
            return conect.usuarios.Any(u => u.correoElectronico == correo);
        }


        public Usuario? Login(string Correo, string contra)
        {
            var conect = new DBase();
            var user = conect.usuarios.FirstOrDefault(u => u.correoElectronico == Correo);
            if (user == null) return null;
            return BCrypt.Net.BCrypt.Verify(contra, user.password) ? user : null;
        }


        public void NuevoRegistroUsario(Usuario usuario)
        {
            var conect = new DBase();
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(usuario.password, 13);
            usuario.password = hashedPassword;
            conect.usuarios.Add(usuario);
            conect.SaveChanges();
            MessageBox.Show("Usuario Registrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        public void EliminarUsuario(int? userIdent)
        {
            using var DBconexion = new DBase();           

            var usuario = DBconexion.usuarios.FirstOrDefault(u => u.Id == userIdent);

            if (usuario != null)
            {
                DBconexion.usuarios.Remove(usuario);
                DBconexion.SaveChanges();
            }
          }


        public Usuario? ObtenerTodoUser(int? id)
        {
            using var DBconexion = new DBase();
            return DBconexion.usuarios.FirstOrDefault(u => u.Id == id);
        }


        public List<Usuario> ObtenerTodosLosUsuarios()
        {
            using var db = new DBase();
            return db.usuarios.ToList();
        }
        public void UpdateUsuario(Usuario usuairio)
        {
            using var db = new DBase();
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(usuairio.password, 13);
            usuairio.password = hashedPassword;
            db.Entry(usuairio).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
