using Linck.Modelos;
using Linck.Service;
using Linck.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linck.Controller
{
    class BovedaController
    {
        private readonly IBovedaService _bovedaService;

        public BovedaController (IBovedaService BovedaService)
        {
            _bovedaService = BovedaService;
        }

        // Agregar nueva Boveda
        public Boveda AgregarBOVEDA(string nomboveda,  int id_usuario, string contra)
        {
            if (string.IsNullOrEmpty(nomboveda))
            {
                MessageBox.Show("Nombre de la boveda no pueden estar vacíos", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            if (_bovedaService.BobedaExists(nomboveda))
            {
                MessageBox.Show("Nombre de la boveda ya existe", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;

            }
         

            var Bovedanueva = new Boveda { 
                nombre_boveda = nomboveda,
                UsuarioId = id_usuario,
                contrasena = contra
             
               };
            _bovedaService.AddBoveda(Bovedanueva);
            MessageBox.Show("Guardado corectamente", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return Bovedanueva;
        }

        // Actualizar Boveda
        public void ActualizarBoveda(string bovedaAntigua, string bovedaNueva)
        {

            var boveda = _bovedaService.GetBovedaByNombre(bovedaAntigua);

            if (boveda == null)
            {
                MessageBox.Show("La boveda especificada no existe.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                if (MessageBox.Show("¿Estás seguro de hacer estos cambios?", "Confirmar Actualizacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    boveda.nombre_boveda = bovedaNueva;               
                    _bovedaService.UpdateBoveda(boveda);
                    MessageBox.Show("El Cambios guardados correctamente.");
                }
                else
                {
                    MessageBox.Show("Cambios cancelados.");
                }

            }
        }


        // elimianr  boveda
        public void EliminarCategoria(string nombreBoveda)
        {
            var boveda = _bovedaService.GetBovedaByNombre(nombreBoveda);

            if (boveda == null)
            {
                MessageBox.Show("La boveda que desea eliminar no existe.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("¿Estas seguro de eliminar la BOVEDA: " + nombreBoveda + " ?...", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _bovedaService.DeleteBoveda(boveda);
                MessageBox.Show("Eliminado correctamente.");
            }
        }


        public Boveda? ObtenerDatos(string NombreBoveda)
        {

            if (string.IsNullOrWhiteSpace(NombreBoveda))
            {
                MessageBox.Show("El nombre de boveda no pueden estar vacíos", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            var user = _bovedaService.GetBovedaByNombre(NombreBoveda);

            if (user == null)
            {
                MessageBox.Show("Nombre no encontrado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         
            return user;

        }

        // obtebner nombres de las bovedas
        public string[] ObtenerNombresBovedas(int idUsuario)
        {
            return _bovedaService.GetNombresBovedas(idUsuario);
            

          
        }

        // obtener cualquier atributo de la tabla
        public Boveda obtenerCualquierDato(string nombreLink)
        {
            return _bovedaService.GetBovedaByNombre(nombreLink);
        }

        public List<Boveda> ObtenerListaBOveda(int idUser)
        {
            return _bovedaService.GetBoveda(idUser).ToList();
        }

        // Buscar los identifcadores puesto a las botones de categoria

        public Boveda? IdentBoveda(int idUser, string nombreBoveda)
        {
            return _bovedaService.GetBovedaById(idUser, nombreBoveda);
        }


    }
}
