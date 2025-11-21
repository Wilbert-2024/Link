using Linck.Data;
using Linck.Modelos;
using Linck.Service;
using Linck.Service.Interface;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Linck.Controller
{
    class CategoriaController
    {
        private readonly ICategoriaService _CategoriaService;

        public CategoriaController(ICategoriaService categoriaService)
        {
            _CategoriaService = categoriaService;
        }


      //  Agregar nueva Categoria
      public Categoria AgregarCategoria(string nombCategoria, PictureBox imagenCate, int? numeroCate)
        {
            byte[]? imageConvertida = null;
            int numeroCategoria = numeroCate.Value;

            if (string.IsNullOrEmpty(nombCategoria))
            {
                MessageBox.Show("Nombre de la categoria no pueden estar vacíos", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            if (ExisteCategoria(nombCategoria))
            {
                MessageBox.Show("Categoria ya existe", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;

            }

            if (imagenCate.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    imagenCate.Image.Save(ms, ImageFormat.Png); // Cambia la extencion de la imagen de PNG a JPEG 
                    imageConvertida = ms.ToArray(); // comvierte la imagen en bytes para guardarlo en la BD
                }
            }
            else
            { MessageBox.Show("ingresa una imagen.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return null; }



            var Categoria = new Categoria { nombre_Categoria = nombCategoria, ImagenUser = imageConvertida, NumeroCategoria = numeroCategoria };
            _CategoriaService.AddCategoria(Categoria);
            MessageBox.Show("Guardado corectamente", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return Categoria;
        }


        // Actualizar categoria
        public void ActualizarCategoria(string categoriaAntigua, string categoriaNueva, PictureBox imagen)
        {
            byte[] nuevaImage = null;

            if (!string.IsNullOrWhiteSpace(categoriaNueva.Trim()  )) {

                if (!ExisteCategoria(categoriaNueva))
                {
                    var categoria = _CategoriaService.GetCategoriaByNombre(categoriaAntigua);

                    if (categoria == null)
                    {
                        MessageBox.Show("La categoría especificada no existe.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {

                        if (imagen.Image != null)
                        {
                            using (MemoryStream ms = new MemoryStream())
                            {
                                imagen.Image.Save(ms, ImageFormat.Png); // Cambia la extencion de la imagen de PNG a JPEG 
                                nuevaImage = ms.ToArray(); // comvierte la imagen en bytes para guardarlo en la BD

                            }

                            if (MessageBox.Show("¿Estás seguro de hacer estos cambios?", "Confirmar Actualizacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                            {
                                categoria.nombre_Categoria = categoriaNueva;
                                categoria.ImagenUser = nuevaImage;
                                _CategoriaService.UpdateCategoria(categoria);
                                MessageBox.Show("El Cambios guardados correctamente.");
                            }
                            else
                            {
                                MessageBox.Show("Cambios cancelados.");
                            }

                        }
                        else { MessageBox.Show("Debes ingresar una imagen", "Error", MessageBoxButtons.OK); }

                    }


                }
                else { MessageBox.Show("Ingresa un nuevo Nombre", "Error", MessageBoxButtons.OK); }


            } else { MessageBox.Show("Categoria ya existe", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }

               
        }

     // elimianr  Categoria
        public void EliminarCategoria(string nombreCategoria)
        {
            if (!string.IsNullOrWhiteSpace(nombreCategoria.Trim())) {

                var categoria = _CategoriaService.GetCategoriaByNombre(nombreCategoria);
           
                if (categoria == null)
                {
                    MessageBox.Show("La categoría que desea eliminar no existe.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (MessageBox.Show("¿Estaas seguro de eliminar?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    _CategoriaService.DeleteCategoria(categoria);
                    MessageBox.Show("Eliminado correctamente.");

                }

            } else
            {
                MessageBox.Show("selecciona lo que quieres eliminar.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Buscar los identifcadores puesto a las botones de categoria

        public Categoria identCAtegoria(int NumeroClave, string nombreCategoris) {

           return _CategoriaService.GetcategoriaById(NumeroClave, nombreCategoris);            

        }
        // optener todas las categorias
        public string[] ObtenerNombresCategorias()
        {
            return _CategoriaService.GetNombresCategorias();
        }
        // anexar las categorias definida
        public Categoria CategoriaPermanentes(string nombCategoria)
        {
            var Categoria = new Categoria { nombre_Categoria = nombCategoria, NumeroCategoria = 0 };
            _CategoriaService.AddCategoria(Categoria);

            return Categoria;
        }


        public bool ExisteCategoria (string nombre)
        {
            return _CategoriaService.CategoriaExists(nombre);
        }

        // obtener cualquier atributo de la tabla
        public Categoria obtenerCualquierDato(string cotegoria)
        {
            return _CategoriaService.GetCategoriaByNombre(cotegoria);
        }


        // Obtener el numero de veces que se repite el usuario

        public int contardorUser(int idUser) { 
        
            return _CategoriaService.ContarCategoriasPorUsuario(idUser);
        
        }

        public List<Categoria> ObtenerListaLinksEspesifico(int idUser)
        {
            return _CategoriaService.GetNombresCategoria(idUser).ToList();
        }



    }
}
