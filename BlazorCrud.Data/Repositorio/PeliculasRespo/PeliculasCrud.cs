using BlazorCrud.Data.Context;
using BlazorCrud.Model.Modelos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorCrud.Data.Repositorio.PeliculasRespo
{
    public class PeliculasCrud : IPeliculasCrud
    {
        private readonly DataContext _data;
        public PeliculasCrud(DataContext data)
        {
            this._data = data;
        }

        public async Task<bool> Agregar(Peliculas data)
        {
            _data.Add(data);

            var varValue = await _data.SaveChangesAsync();

            return varValue > 0;
        }

        public async Task<bool> Editar(Peliculas data)
        {
            _data.Peliculas.Attach(data);
            _data.Entry(data).State = EntityState.Modified;

            await _data.SaveChangesAsync();

            return true;
        }

        public async Task<bool> Eliminar(int data)
        {
            _data.Peliculas.Remove(_data.Peliculas.FirstOrDefault(x => x.ID == data));
            await _data.SaveChangesAsync();
            return true;
        }

        public async Task<IEnumerable<Peliculas>> Obtener()
        {
            return await _data.Peliculas.ToListAsync();
        }

        public async Task<Peliculas> Obtener(int id)
        {
            return await _data.Peliculas.FindAsync(id);
        }
    }
}
