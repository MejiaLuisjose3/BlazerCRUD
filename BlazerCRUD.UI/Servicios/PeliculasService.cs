using BlazerCRUD.UI.Interfaces;
using BlazorCrud.Data.Repositorio.PeliculasRespo;
using BlazorCrud.Model.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazerCRUD.UI.Servicios
{
    public class PeliculasService : IPeliculasService
    {
        private readonly IPeliculasCrud _data;
        public PeliculasService(IPeliculasCrud data)
        {
            this._data = data;
        }

        public Task<bool> Agregar(Peliculas data)
        {
            if (data.ID == null)
            {
                return _data.Agregar(data);
            }
            else 
            {
                return _data.Editar(data);
            }
        }

        public async Task<bool> Eliminar(int data)
        {
            return await _data.Eliminar(data);
        }

        public async Task<IEnumerable<Peliculas>> Obtener()
        {
            return await _data.Obtener();
        }

        public async Task<Peliculas> Obtener(int id)
        {
            return await _data.Obtener(id);
        }
    }
}
