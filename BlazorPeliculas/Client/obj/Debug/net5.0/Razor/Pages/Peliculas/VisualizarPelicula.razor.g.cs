#pragma checksum "C:\Users\Moño\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Pages\Peliculas\VisualizarPelicula.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f266be11d098fd73de98fcf26bb20ca631d241d"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/pelicula/{PeliculaId:int}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/pelicula/{PeliculaId:int}/{NombrePelicula}")]
    public partial class VisualizarPelicula : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 7 "C:\Users\Moño\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Pages\Peliculas\VisualizarPelicula.razor"
 if (model == null)
{
    

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "Cargando...");
#nullable restore
#line 9 "C:\Users\Moño\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Pages\Peliculas\VisualizarPelicula.razor"
                            
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "h2");
            __builder.AddContent(2, 
#nullable restore
#line 13 "C:\Users\Moño\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Pages\Peliculas\VisualizarPelicula.razor"
         model.Pelicula.Titulo

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(3, " (");
            __builder.AddContent(4, 
#nullable restore
#line 13 "C:\Users\Moño\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Pages\Peliculas\VisualizarPelicula.razor"
                                 model.Pelicula.Lanzamiento.Value.ToString("yyyy")

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(5, ")");
            __builder.CloseElement();
#nullable restore
#line 14 "C:\Users\Moño\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Pages\Peliculas\VisualizarPelicula.razor"
     for (int i = 0; i < model.Generos.Count; i++)
    {
        if (i < model.Generos.Count - 1)
        {
            

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, 
#nullable restore
#line 18 "C:\Users\Moño\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Pages\Peliculas\VisualizarPelicula.razor"
             enlaceGenero(model.Generos[i])

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(7, ", ");
#nullable restore
#line 18 "C:\Users\Moño\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Pages\Peliculas\VisualizarPelicula.razor"
                                                          
        }
        else
        {
            

#line default
#line hidden
#nullable disable
            __builder.AddContent(8, 
#nullable restore
#line 22 "C:\Users\Moño\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Pages\Peliculas\VisualizarPelicula.razor"
             enlaceGenero(model.Generos[i])

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 22 "C:\Users\Moño\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Pages\Peliculas\VisualizarPelicula.razor"
                                           
        }
    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(9, " |  ");
            __builder.OpenElement(10, "span");
            __builder.AddContent(11, 
#nullable restore
#line 26 "C:\Users\Moño\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Pages\Peliculas\VisualizarPelicula.razor"
                            model.Pelicula.Lanzamiento.Value.ToString("dd MM yyyy")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddContent(12, " | Promedio ");
            __builder.AddContent(13, 
#nullable restore
#line 27 "C:\Users\Moño\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Pages\Peliculas\VisualizarPelicula.razor"
                               model.PromedioVotos.ToString("0.#")

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(14, " /5 | Tu voto: ");
            __builder.AddContent(15, 
#nullable restore
#line 27 "C:\Users\Moño\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Pages\Peliculas\VisualizarPelicula.razor"
                                                                                                 model.VotoUsuario.ToString("0.#")

#line default
#line hidden
#nullable disable
            );
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "style", "display: flex;");
            __builder.OpenElement(18, "span");
            __builder.AddAttribute(19, "style", "display: inline-block; margin-right: 5px;");
            __builder.OpenElement(20, "img");
            __builder.AddAttribute(21, "src", 
#nullable restore
#line 29 "C:\Users\Moño\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Pages\Peliculas\VisualizarPelicula.razor"
                                                                           model.Pelicula.Poster

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(22, "style", "width: 225px; height: 315px");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n        ");
            __builder.OpenElement(24, "iframe");
            __builder.AddAttribute(25, "width", "560");
            __builder.AddAttribute(26, "height", "315");
            __builder.AddAttribute(27, "src", "https://www.youtube.com/embed/" + (
#nullable restore
#line 30 "C:\Users\Moño\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Pages\Peliculas\VisualizarPelicula.razor"
                                                                             model.Pelicula.Trailer

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "frameborder", "0");
            __builder.AddAttribute(29, "allow", "accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture");
            __builder.AddAttribute(30, "allowfullscreen");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n    ");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "style", "margin-top: 10px;");
            __builder.AddMarkupContent(34, "<h3>Resumen</h3>\r\n        ");
            __builder.OpenElement(35, "div");
            __builder.OpenComponent<BlazorPeliculas.Client.Shared.MostrarMarkdown>(36);
            __builder.AddAttribute(37, "ContenidoMarkdown", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 35 "C:\Users\Moño\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Pages\Peliculas\VisualizarPelicula.razor"
                                                 model.Pelicula.Resumen

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n    ");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "style", "margin-top: 10px;");
            __builder.AddMarkupContent(41, "<h3>Actores</h3>\r\n        ");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "style", "display: flex; flex-direction: column");
#nullable restore
#line 41 "C:\Users\Moño\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Pages\Peliculas\VisualizarPelicula.razor"
             foreach (var actor in model.Actores)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "style", "margin-bottom: 2px;");
            __builder.OpenElement(46, "img");
            __builder.AddAttribute(47, "style", "width: 50px;");
            __builder.AddAttribute(48, "src", 
#nullable restore
#line 44 "C:\Users\Moño\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Pages\Peliculas\VisualizarPelicula.razor"
                                                    actor.Foto

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n                    ");
            __builder.OpenElement(50, "span");
            __builder.AddAttribute(51, "style", "display:inline-block;width: 200px;");
            __builder.OpenElement(52, "a");
            __builder.AddAttribute(53, "href", "/persona/" + (
#nullable restore
#line 45 "C:\Users\Moño\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Pages\Peliculas\VisualizarPelicula.razor"
                                                                                        actor.Id

#line default
#line hidden
#nullable disable
            ) + "/" + (
#nullable restore
#line 45 "C:\Users\Moño\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Pages\Peliculas\VisualizarPelicula.razor"
                                                                                                  actor.Nombre.Replace(" ", "-")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(54, 
#nullable restore
#line 45 "C:\Users\Moño\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Pages\Peliculas\VisualizarPelicula.razor"
                                                                                                                                   actor.Nombre

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n                    ");
            __builder.AddMarkupContent(56, "<span style=\"display:inline-block; width: 45px;\">...</span>\r\n                    ");
            __builder.OpenElement(57, "span");
            __builder.AddContent(58, 
#nullable restore
#line 47 "C:\Users\Moño\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Pages\Peliculas\VisualizarPelicula.razor"
                           actor.Personaje

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 49 "C:\Users\Moño\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Pages\Peliculas\VisualizarPelicula.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 52 "C:\Users\Moño\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Pages\Peliculas\VisualizarPelicula.razor"
}

#line default
#line hidden
#nullable disable
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
            __builder2.OpenElement(59, "a");
            __builder2.AddAttribute(60, "href", "peliculas/buscar?generoid=" + (
#nullable restore
#line 59 "C:\Users\Moño\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Pages\Peliculas\VisualizarPelicula.razor"
                                                                                                  genero.Id

#line default
#line hidden
#nullable disable
            ));
            __builder2.AddContent(61, 
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
