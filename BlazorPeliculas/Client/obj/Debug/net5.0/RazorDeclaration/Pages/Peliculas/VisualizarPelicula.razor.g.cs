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
    [Microsoft.AspNetCore.Components.RouteAttribute("/pelicula/{PeliculaId:int}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/pelicula/{PeliculaId:int}/{NombrePelicula}")]
    public partial class VisualizarPelicula : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 54 "C:\Users\Moño\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Pages\Peliculas\VisualizarPelicula.razor"
       

    [Parameter] public int PeliculaId { get; set; }
    [Parameter] public string NombrePelicula { get; set; }
    private PeliculaVisualizarDTO model;
    private RenderFragment<Genero> enlaceGenero = (genero) =>

#line default
#line hidden
#nullable disable
        (__builder2) => {
            __builder2.OpenElement(0, "a");
            __builder2.AddAttribute(1, "href", "peliculas/buscar?generoid=" + (
#nullable restore
#line 59 "C:\Users\Moño\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Pages\Peliculas\VisualizarPelicula.razor"
                                                                                                  genero.Id

#line default
#line hidden
#nullable disable
            ));
            __builder2.AddContent(2, 
#nullable restore
#line 59 "C:\Users\Moño\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Pages\Peliculas\VisualizarPelicula.razor"
                                                                                                              genero.Nombre

#line default
#line hidden
#nullable disable
            );
            __builder2.CloseElement();
        }
#nullable restore
#line 59 "C:\Users\Moño\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Pages\Peliculas\VisualizarPelicula.razor"
                                                                                                                               ;

    protected async override Task OnInitializedAsync()
    {
        var responseHttp = await repository.Get<PeliculaVisualizarDTO>($"api/peliculas/{PeliculaId}");

        if (responseHttp.Error)
        {
            if (responseHttp.HttpResponseMessage.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                navigationManager.NavigateTo("");
            }
            else
            {
                var mensajeError = await responseHttp.GetBody();
                await mostrarMensajes.MostrarMensajeError(mensajeError);
            }
        }
        else
        {
            model = responseHttp.Response;
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMostrarMensajes mostrarMensajes { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRepository repository { get; set; }
    }
}
#pragma warning restore 1591
