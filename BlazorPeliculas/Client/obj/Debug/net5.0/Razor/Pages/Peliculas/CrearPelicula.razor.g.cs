#pragma checksum "C:\Users\Moño\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Pages\Peliculas\CrearPelicula.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c602e198c26accf46570484a8cd06786d70320e"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorPeliculas.Client.Pages.Peliculas
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Moño\source\repos\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Moño\source\repos\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Moño\source\repos\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Moño\source\repos\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Moño\source\repos\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Moño\source\repos\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Moño\source\repos\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Moño\source\repos\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using BlazorPeliculas.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Moño\source\repos\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using BlazorPeliculas.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Moño\source\repos\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using BlazorPeliculas.Shared.Entidades;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Moño\source\repos\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using BlazorPeliculas.Client.Repositories;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Moño\source\repos\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using BlazorPeliculas.Client.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Moño\source\repos\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using BlazorPeliculas.Shared.DTOs;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/peliculas/crear")]
    public partial class CrearPelicula : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Crear Pelicula</h3>");
#nullable restore
#line 7 "C:\Users\Moño\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Pages\Peliculas\CrearPelicula.razor"
 if (MostrarFormulario)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<BlazorPeliculas.Client.Pages.Peliculas.FormularioPeliculas>(1);
            __builder.AddAttribute(2, "Pelicula", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorPeliculas.Shared.Entidades.Pelicula>(
#nullable restore
#line 9 "C:\Users\Moño\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Pages\Peliculas\CrearPelicula.razor"
                                   Pelicula

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 9 "C:\Users\Moño\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Pages\Peliculas\CrearPelicula.razor"
                                                            Crear

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "GenerosNoSeleccionados", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<BlazorPeliculas.Shared.Entidades.Genero>>(
#nullable restore
#line 10 "C:\Users\Moño\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Pages\Peliculas\CrearPelicula.razor"
                                                 GenerosNoSeleccionados

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 11 "C:\Users\Moño\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Pages\Peliculas\CrearPelicula.razor"
}
else
{
    

#line default
#line hidden
#nullable disable
            __builder.AddContent(5, "Cargando...");
#nullable restore
#line 14 "C:\Users\Moño\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Pages\Peliculas\CrearPelicula.razor"
                            
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 19 "C:\Users\Moño\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Pages\Peliculas\CrearPelicula.razor"
       
    public bool MostrarFormulario { get; set; } = false;
    private Pelicula Pelicula = new Pelicula();
    public List<Genero> GenerosNoSeleccionados = new List<Genero>();

    protected async override Task OnInitializedAsync()
    {
        var responseHTTP = await repository.Get<List<Genero>>("api/generos");
        GenerosNoSeleccionados = responseHTTP.Response;
        MostrarFormulario = true;
    }

    async Task Crear()
    {
        var httpResponse = await repository.Post<Pelicula, int>("api/peliculas", Pelicula);

        if (httpResponse.Error)
        {
            var mensajeError = await httpResponse.GetBody();
            await mostrarMensajes.MostrarMensajeError(mensajeError);
        }
        else
        {
            var PeliculaId = httpResponse.Response;
            navigationManager.NavigateTo($"/peliculas/{PeliculaId}/{Pelicula.Titulo.Replace(" ", "-")}");
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMostrarMensajes mostrarMensajes { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRepository repository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
    }
}
#pragma warning restore 1591
