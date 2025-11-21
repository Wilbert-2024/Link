using Linck.Data;
using Linck.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linck.Service.Interface
{
    interface IUsuarioService
    {
        //Verifica si el correo y la contraseña existe en la base de datos.
        Usuario? Login(string Correo, string password);

        //Registrar un nuevo usuario dentro de la base de datos.
        void NuevoRegistroUsario(Usuario usuario);

        //Verificar si ya existe el correo electronico.
        bool IsCorreoExists(string correo);

        void EliminarUsuario(int? usuario);

        // este metodo me ayuda a tener acceso a todo los campos de usuarios
        Usuario? ObtenerTodoUser(int? id);

        // forma de optener todos lo usuario que se encuentrar guadado en la base de dato
        List<Usuario> ObtenerTodosLosUsuarios();

        void UpdateUsuario(Usuario usuairio);


    }
}
