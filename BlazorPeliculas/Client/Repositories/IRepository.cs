using BlazorPeliculas.Shared.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorPeliculas.Client.Repositories
{
    public interface IRepository
    {
        List<Pelicula> ObtenerPeliculas();
    }
}
