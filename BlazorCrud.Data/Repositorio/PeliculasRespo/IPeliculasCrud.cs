using System;
using BlazorCrud.Model.Modelos;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlazorCrud.Data.Repositorio.PeliculasRespo
{
    public interface IPeliculasCrud
    {
        Task<bool> Agregar(Peliculas data);
        Task<bool> Editar(Peliculas data);
        Task<bool> Eliminar(int data);
        Task<IEnumerable<Peliculas>> Obtener();
        Task<Peliculas> Obtener(int id);
    }
}
