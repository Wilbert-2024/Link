using Linck.Data;
using Linck.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;

namespace Linck.Service.Interface
{
    interface ICategoriaService
    {
        IEnumerable<Categoria> GetCategoria();
        Categoria? GetcategoriaById(int numroCategoria, string nomobreCategori); // uso 
        Categoria AddCategoria(Categoria cate); // en uso
        void UpdateCategoria(Categoria cate); // en uso
        void DeleteCategoria(Categoria cate);  // en uso
        bool CategoriaExists(string categoria); // en uso

        //para poner todo los nombre de categoria en un arreglo
        string[] GetNombresCategorias();        // en uso

 
        // Me permite tener acceso a todos los campos de la tabla
        Categoria? GetCategoriaByNombre(string NombreCategoria); // en uso

        // uso del count()
        int ContarCategoriasPorUsuario(int usuarioId);

        // Corrección aquí: devuelve categorías, no Bóvedas
        IEnumerable<Categoria> GetNombresCategoria(int idUsuario);

    }
}
