using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorCrud.Model.Modelos
{
    public class Peliculas
    {
        public int? ID {get; set;}
        public string Nombre {get; set;}
        public string Director {get; set;}
        public DateTime? FechaExtreno {get; set;}
    }
}
