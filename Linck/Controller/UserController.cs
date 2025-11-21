using Linck.Modelos;
using Linck.Service;
using Linck.Service.Interface;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace Linck.Controller
{
    class UserController
    {
        private readonly IUsuarioService _usuarioService;



        public UserController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        // verifica que el usuario y la contraseña esten en la base de dato
        public Usuario? IniciarSecion(string correo, string contra)
        {

            if (string.IsNullOrWhiteSpace(correo) || string.IsNullOrWhiteSpace(contra))
            {
                MessageBox.Show("El nombre de usuario y la contraseña no pueden estar vacíos", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            var user = _usuarioService.Login(correo, contra);

            if (user == null)
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return user;


        }


        //Agregar user
        public Usuario NuevoUser(string nombre, string pasword, string correo, PictureBox imagenUsuario)
        {
            byte[]? FotoUser = null;

            // verificacion cada uno de los datos si son nulos
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(pasword) || string.IsNullOrEmpty(correo))
            {
                //throw new ArgumentException("El nombre de usuario y la contraseña no pueden estar vacíos.");

                MessageBox.Show("El nombre de usuario y la contraseña no pueden estar vacíos", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            // verifica si el correo existe
            if (_usuarioService.IsCorreoExists(correo))
            {
                //  throw new ArgumentException("El usuario ya existe");

                MessageBox.Show("El usuario ya existe", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;

            }

            // convertir la imagen en bit
            // Asegúrate de que haya una imagen cargada en el PictureBox
            if (imagenUsuario.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    imagenUsuario.Image.Save(ms, ImageFormat.Png); // Cambia la extencion de la imagen de PNG a JPEG 
                    FotoUser = ms.ToArray(); // comvierte la imagen en bytes para guardarlo en la BD
                }
            }
            else
            { MessageBox.Show("Debes ingres una imagen para tu perfil.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return null; }




            // insertamos los datos a la tabla Usuario y las guardamos en una variable 
            var usuario = new Usuario
            {
                Nombre = nombre,
                password = pasword,
                correoElectronico = correo,
                ImagenUser = FotoUser,

            };

            // insertamos los datos a la base de dato
            _usuarioService.NuevoRegistroUsario(usuario);

            MessageBox.Show("Registrado con exito");
            return usuario;

        }


        // elimiar user
        public void eliminarUsuario(int? idUser)
        {
            var opcion = MessageBox.Show("¿Estás seguro que quieres eliminar este usuario?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (opcion == DialogResult.Yes)
            {
                _usuarioService.EliminarUsuario(idUser); // Llamás a tu método para borrar
            
            }
            else
            {
                MessageBox.Show("Eliminación cancelada.");
            }

        }

        public Image? ObtenerImagenUsuario(int? userId)
        {
            var usuario = _usuarioService.ObtenerTodoUser(userId);

            if (usuario != null && usuario.ImagenUser != null)
            {
                using MemoryStream ms = new MemoryStream(usuario.ImagenUser);
                return Image.FromStream(ms);
            }

            return null;
        }

        public List<Usuario> ObtenerListaUsuarios()
        {
            return _usuarioService.ObtenerTodosLosUsuarios();
        }

        //optenerdatos

        public Usuario obtenerDatos(int id)
        {
            return _usuarioService.ObtenerTodoUser(id);
        }
        // actualizar usuario

        public void ActualizarUsuario(string NombreUsuario, string Correo, string contrasena, PictureBox image, int idUser)
        {
            byte[]? imagenOtra = null;

           if (string.IsNullOrEmpty(NombreUsuario) || string.IsNullOrEmpty(Correo) ) {
                MessageBox.Show("Todos los campos deben tener datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
           else
            {

       
            var DatosUsuarios = _usuarioService.ObtenerTodoUser(idUser);

                if (DatosUsuarios == null)
                {
                    MessageBox.Show("El Usuario  no existe.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (image.Image != null)
                    {
                        using (MemoryStream ms = new MemoryStream())
                        {
                            image.Image.Save(ms, ImageFormat.Png); // Cambia la extencion de la imagen de PNG a JPEG 
                            imagenOtra = ms.ToArray(); // comvierte la imagen en bytes para guardarlo en la BD

                        }

                        if (MessageBox.Show("¿Estás seguro de hacer estos cambios?", "Confirmar Actualizacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            DatosUsuarios.Nombre = NombreUsuario;
                            DatosUsuarios.correoElectronico = Correo;
                            DatosUsuarios.ImagenUser = imagenOtra;
                           
                            if (!string.IsNullOrEmpty(contrasena)) { DatosUsuarios.password = contrasena; }

                            _usuarioService.UpdateUsuario(DatosUsuarios);
                            MessageBox.Show("El Cambios guardados correctamente.");
                        }
                        else
                        {
                            MessageBox.Show("Cambios cancelados.");
                        }


                    }
                    else
                    { MessageBox.Show("Debes ingres una imagen para tu perfil.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }


                }

                }


            }

    }
}
