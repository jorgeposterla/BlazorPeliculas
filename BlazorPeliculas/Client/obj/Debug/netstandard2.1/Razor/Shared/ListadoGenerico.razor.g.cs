#pragma checksum "C:\Users\Peregrino\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Shared\ListadoGenerico.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7532da799ad90e9769f89643a4a74dcdf63a14c7"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorPeliculas.Client.Shared
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
    public partial class ListadoGenerico<TItem> : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 3 "C:\Users\Peregrino\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Shared\ListadoGenerico.razor"
 if (Listado == null)
{
    if (Cargando == null)
    {
        

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "Cargando...");
#nullable restore
#line 7 "C:\Users\Peregrino\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Shared\ListadoGenerico.razor"
                                
    }
    else
    {
        

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, 
#nullable restore
#line 11 "C:\Users\Peregrino\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Shared\ListadoGenerico.razor"
         Cargando

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 11 "C:\Users\Peregrino\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Shared\ListadoGenerico.razor"
                 
    }

}
else if (Listado.Count == 0)
{
    if (NoHayRegistros == null)
    {
        

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "No hay registros para mostrar");
#nullable restore
#line 19 "C:\Users\Peregrino\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Shared\ListadoGenerico.razor"
                                                  
    }
    else
    {
        

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, 
#nullable restore
#line 23 "C:\Users\Peregrino\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Shared\ListadoGenerico.razor"
         NoHayRegistros

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 23 "C:\Users\Peregrino\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Shared\ListadoGenerico.razor"
                       
    }
}
else
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\Peregrino\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Shared\ListadoGenerico.razor"
     foreach (var elemento in Listado)
    {
        

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, 
#nullable restore
#line 30 "C:\Users\Peregrino\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Shared\ListadoGenerico.razor"
         HayRegistros(elemento)

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 30 "C:\Users\Peregrino\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Shared\ListadoGenerico.razor"
                               
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\Peregrino\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Shared\ListadoGenerico.razor"
     
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "C:\Users\Peregrino\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Shared\ListadoGenerico.razor"
       
    [Parameter] public RenderFragment Cargando { get; set; }
    [Parameter] public RenderFragment NoHayRegistros { get; set; }
    [Parameter] public RenderFragment<TItem> HayRegistros { get; set; }
    [Parameter] public List<TItem> Listado { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591