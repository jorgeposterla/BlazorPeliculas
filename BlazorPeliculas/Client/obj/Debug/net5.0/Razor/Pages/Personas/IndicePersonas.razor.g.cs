#pragma checksum "C:\Users\Moño\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Pages\Personas\IndicePersonas.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f4a16dc21e65478edc44bee42587e87043d1a44"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorPeliculas.Client.Pages.Personas
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/personas")]
    public partial class IndicePersonas : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>IndicePersonas</h3>\r\n\r\n");
            __builder.AddMarkupContent(1, "<div class=\"form-group\"><a class=\"btn btn-info\" href=\"personas/crear\">Crear Persona</a></div>\r\n\r\n");
            __builder.OpenComponent<BlazorPeliculas.Client.Shared.Paginacion>(2);
            __builder.AddAttribute(3, "PaginaActual", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 11 "C:\Users\Moño\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Pages\Personas\IndicePersonas.razor"
                          paginaActual

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "PaginaSeleccionada", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, 
#nullable restore
#line 12 "C:\Users\Moño\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Pages\Personas\IndicePersonas.razor"
                                paginaSeleccionada

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(5, "PaginasTotales", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 13 "C:\Users\Moño\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Pages\Personas\IndicePersonas.razor"
                            paginasTotales

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(6, "\r\n\r\n");
            __Blazor.BlazorPeliculas.Client.Pages.Personas.IndicePersonas.TypeInference.CreateListadoGenerico_0(__builder, 7, 8, 
#nullable restore
#line 15 "C:\Users\Moño\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Pages\Personas\IndicePersonas.razor"
                          Personas

#line default
#line hidden
#nullable disable
            , 9, (__builder2) => {
                __builder2.OpenElement(10, "table");
                __builder2.AddAttribute(11, "class", "table table-striped");
                __builder2.AddMarkupContent(12, "<thead><tr><th></th>\r\n                    <th>Nombre</th></tr></thead>\r\n            ");
                __builder2.OpenElement(13, "tbody");
#nullable restore
#line 25 "C:\Users\Moño\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Pages\Personas\IndicePersonas.razor"
                 foreach (var item in Personas)
                {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(14, "tr");
                __builder2.OpenElement(15, "td");
                __builder2.OpenElement(16, "a");
                __builder2.AddAttribute(17, "href", "personas/editar/" + (
#nullable restore
#line 29 "C:\Users\Moño\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Pages\Personas\IndicePersonas.razor"
                                                      item.Id

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "class", "btn btn-success");
                __builder2.AddContent(19, "Editar");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\r\n                            ");
                __builder2.OpenElement(21, "button");
                __builder2.AddAttribute(22, "class", "btn btn-danger");
                __builder2.AddAttribute(23, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "C:\Users\Moño\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Pages\Personas\IndicePersonas.razor"
                                                                       () => BorrarPersona(item)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(24, "Borrar");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(25, "\r\n                        ");
                __builder2.OpenElement(26, "td");
                __builder2.AddContent(27, 
#nullable restore
#line 32 "C:\Users\Moño\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Pages\Personas\IndicePersonas.razor"
                             item.Nombre

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 34 "C:\Users\Moño\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Pages\Personas\IndicePersonas.razor"
                }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            );
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "C:\Users\Moño\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Pages\Personas\IndicePersonas.razor"
       

    public List<Persona> Personas { get; set; }
    private int paginaActual = 1;
    private int paginasTotales;

    protected async override Task OnInitializedAsync()
    {
        await Cargar();
    }

    private async Task paginaSeleccionada(int pagina)
    {
        paginaActual = pagina;
        await Cargar(pagina);
    }

    private async Task Cargar(int pagina = 1)
    {
        var responseHTTP = await repository.Get<List<Persona>>($"api/personas?pagina={pagina}");
        if (!responseHTTP.Error)
        {
            Personas = responseHTTP.Response;
            var conteo = responseHTTP.HttpResponseMessage.Headers.GetValues("conteo").FirstOrDefault();
            paginasTotales = int.Parse(responseHTTP.HttpResponseMessage.Headers.GetValues("totalPaginas").FirstOrDefault());
        }
    }

    private async Task BorrarPersona(Persona persona)
    {
        var responseHttp = await repository.Delete($"api/personas/{persona.Id}");

        if (responseHttp.Error)
        {
            await mostrarMensajes.MostrarMensajeError(await responseHttp.GetBody());
        }
        else
        {
            await Cargar();
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMostrarMensajes mostrarMensajes { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRepository repository { get; set; }
    }
}
namespace __Blazor.BlazorPeliculas.Client.Pages.Personas.IndicePersonas
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateListadoGenerico_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.List<TItem> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::BlazorPeliculas.Client.Shared.ListadoGenerico<TItem>>(seq);
        __builder.AddAttribute(__seq0, "Listado", __arg0);
        __builder.AddAttribute(__seq1, "HayRegistrosCompleto", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
