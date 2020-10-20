#pragma checksum "C:\Users\Peregrino\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Pages\Peliculas\EditarPelicula.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ab28da172a1fae7ed8e42d196d239e016a1f8fa2"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorPeliculas.Client.Pages.Peliculas
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Peregrino\source\repos\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Peregrino\source\repos\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Peregrino\source\repos\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Peregrino\source\repos\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Peregrino\source\repos\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Peregrino\source\repos\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Peregrino\source\repos\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Peregrino\source\repos\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using BlazorPeliculas.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Peregrino\source\repos\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using BlazorPeliculas.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Peregrino\source\repos\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using BlazorPeliculas.Shared.Entidades;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Peregrino\source\repos\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using BlazorPeliculas.Client.Repositories;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Peregrino\source\repos\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using BlazorPeliculas.Client.Helpers;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/peliculas/editar/{PeliculaId:int}")]
    public partial class EditarPelicula : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 10 "C:\Users\Peregrino\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Pages\Peliculas\EditarPelicula.razor"
       
    [Parameter] public int PeliculaId { get; set; }
    Pelicula Pelicula = new Pelicula();
    private List<Genero> GenerosSeleccionados = new List<Genero>();
    private List<Genero> GenerosNoSeleccionados = new List<Genero>();

    protected override void OnInitialized()
    {
        Pelicula = new Pelicula() { Id = PeliculaId, Titulo = "Mi Pelicula" };
        GenerosNoSeleccionados = new List<Genero>()
        {
            new Genero(){Id = 1, Nombre = "Comedia"},
            new Genero(){Id = 2, Nombre = "Drama"},

            new Genero(){Id = 4, Nombre = "Sci-Fi"}
        };

        GenerosSeleccionados = new List<Genero>()
        {
            new Genero() { Id = 3, Nombre = "Acción" }
        };
    }

    private void Editar()
    {
        Console.WriteLine("Editando Película");
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
