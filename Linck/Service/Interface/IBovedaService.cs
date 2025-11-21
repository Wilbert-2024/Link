using Linck.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linck.Service.Interface
{
    interface  IBovedaService
    {
        IEnumerable<Boveda> GetBoveda(int usuarioId); //uso
        Boveda? GetBovedaById(int IdUser, string nombreBoveda);
        Boveda AddBoveda(Boveda boveda1);
        void UpdateBoveda(Boveda boveda1);
        void DeleteBoveda(Boveda boveda1);  
        bool BobedaExists(string nombreBoveda);
        List<Boveda> ObtenerListaBoveda(int idUsuario);
     

        // Me permite tener acceso a todos los campos de la tabla
        Boveda? GetBovedaByNombre(string nombreBoveda);
        string[] GetNombresBovedas(int idUsuario);
    }

}
