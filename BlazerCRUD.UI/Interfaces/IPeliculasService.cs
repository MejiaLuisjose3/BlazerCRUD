using BlazorCrud.Model.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazerCRUD.UI.Interfaces
{
    public interface IPeliculasService
    {
        Task<bool> Agregar(Peliculas data);
        Task<bool> Eliminar(int data);
        Task<IEnumerable<Peliculas>> Obtener();
        Task<Peliculas> Obtener(int id);
    }
}
