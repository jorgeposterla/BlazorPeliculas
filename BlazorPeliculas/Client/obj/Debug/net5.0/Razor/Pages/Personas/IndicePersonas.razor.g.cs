#pragma checksum "C:\Users\Peregrino\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Pages\Personas\IndicePersonas.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6669039bc72ade41855f21d8374003c6d6540eeb"
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
#nullable restore
#line 13 "C:\Users\Peregrino\source\repos\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
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
            __Blazor.BlazorPeliculas.Client.Pages.Personas.IndicePersonas.TypeInference.CreateListadoGenerico_0(__builder, 2, 3, 
#nullable restore
#line 10 "C:\Users\Peregrino\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Pages\Personas\IndicePersonas.razor"
                          Personas

#line default
#line hidden
#nullable disable
            , 4, (__builder2) => {
                __builder2.OpenElement(5, "table");
                __builder2.AddAttribute(6, "class", "table table-striped");
                __builder2.AddMarkupContent(7, "<thead><tr><th></th>\r\n                    <th>Nombre</th></tr></thead>\r\n            ");
                __builder2.OpenElement(8, "tbody");
#nullable restore
#line 20 "C:\Users\Peregrino\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Pages\Personas\IndicePersonas.razor"
                 foreach (var item in Personas)
                {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(9, "tr");
                __builder2.AddMarkupContent(10, "<td><a class=\"btn btn-success\">Editar</a>\r\n                            <button class=\"btn btn-danger\">Borrar</button></td>\r\n                        ");
                __builder2.OpenElement(11, "td");
                __builder2.AddContent(12, 
#nullable restore
#line 27 "C:\Users\Peregrino\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Pages\Personas\IndicePersonas.razor"
                             item.Nombre

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 29 "C:\Users\Peregrino\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Pages\Personas\IndicePersonas.razor"
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
#line 36 "C:\Users\Peregrino\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Pages\Personas\IndicePersonas.razor"
       

    public List<Persona> Personas { get; set; }

    protected async override Task OnInitializedAsync()
    {
        var responseHTTP = await repository.Get<List<Persona>>("api/personas");
        Personas = responseHTTP.Response;
    }

#line default
#line hidden
#nullable disable
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
