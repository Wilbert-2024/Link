using Linck.Modelos;
using Linck.Service;
using Linck.Service.Interface;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linck.Controller
{
    class LinkController
    {
        private readonly ILinkService _linkService;

        public LinkController(ILinkService LinkService)
        {
            _linkService = LinkService;
        }

        // Agregar nuevo link
        public Linkss AgregarLink(string nomLink, string URLink, PictureBox imageLink, int IdBoveda, int IdCategoria)
        {
            byte[]? FotoLink = null;
            if (string.IsNullOrEmpty(nomLink) || string.IsNullOrEmpty(URLink))
            {
                MessageBox.Show("Los campos no deben estar vacios","Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            if (_linkService.LinkExists(nomLink))
            {
                  MessageBox.Show("Nombre de la link ya existe", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;   

            }

            if (!ValidarURL(URLink))
            {
                MessageBox.Show("La URL que intentas ingresar no es válida. Por favor ingrese una URL válida.", "Error de URL", MessageBoxButtons.OK, MessageBoxIcon.Error); return null;

            }


            if (imageLink.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    imageLink.Image.Save(ms, ImageFormat.Png); // Cambia la extencion de la imagen de PNG a JPEG 
                    FotoLink = ms.ToArray(); // comvierte la imagen en bytes para guardarlo en la BD

                    var NuevoLink = new Linkss
                    {
                        Nom_link = nomLink,
                        link = URLink,
                        ImagenLink = FotoLink,
                        BovedaId = IdBoveda,
                        CategoriaId = IdCategoria
                    };
                    _linkService.AddLinkss(NuevoLink);
                    MessageBox.Show("Guardado corectamente", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return NuevoLink;

                }
            }
            else
            { MessageBox.Show("Igresa una imagen para el link.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return null; }



        }

        // Actualizar link
        public void ActualizarLink(string NombreAntiguo, string nombreNuevo, string linkUrl, PictureBox imagenLink)
        {
             byte[]? imagenOtra = null;
            var Datolink = _linkService.GetLinkByNombre(NombreAntiguo);

            if (Datolink == null)
            {
                MessageBox.Show("El nombre del enlase no existe.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
              if (ValidarURL(linkUrl)) {

                 if (imagenLink.Image != null)
                      {
                        using (MemoryStream ms = new MemoryStream())
                        {
                           imagenLink.Image.Save(ms, ImageFormat.Png); // Cambia la extencion de la imagen de PNG a JPEG 
                            imagenOtra = ms.ToArray(); // comvierte la imagen en bytes para guardarlo en la BD
                        }

                     if (MessageBox.Show("¿Estás seguro de hacer estos cambios?", "Confirmar Actualizacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            Datolink.Nom_link = nombreNuevo;
                            Datolink.link = linkUrl;
                            Datolink.ImagenLink = imagenOtra;
                           _linkService.UpdateLinkss(Datolink);
                            MessageBox.Show("El Cambios guardados correctamente.");
                        }
                      else { MessageBox.Show("Cambios cancelados.");  }

                    }


                   
                }

               

            }
        }
        // Eliminar link
        public void EliminarLink(string nombreLink)
        {
            var boveda = _linkService.GetLinkByNombre(nombreLink);

            if (boveda == null)
            {
                MessageBox.Show("El link que desea eliminar no existe.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("¿Estas seguro de eliminar el link: " + nombreLink + " ?...", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _linkService.DeleteLinkss(boveda);
                MessageBox.Show("Eliminado correctamente.");
            }
        }

        // obtener la lsita de los enlaces
        public List<Linkss> ObtenerListaLinks()
        {
            return _linkService.ObtenerListaLink();
        }

        // obtener lista en espesifico

        public List<Linkss> ObtenerListaLinksEspesifico(int idCategoria, int idBoveda, int intUsuario)
        {
            return _linkService.ListaLinkssEspecificos(intUsuario,idBoveda,idCategoria).ToList();
        }


        // optener datos con el id
        public Linkss optenerdato(int id)
        {
            return _linkService.ObtenerdatosconID(id);
        }

        // validad si es url lo que se esta ingresando

        private bool ValidarURL(string url)
        {
            return Uri.TryCreate(url, UriKind.Absolute, out Uri uriResult)
                && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
        }

    }
}
