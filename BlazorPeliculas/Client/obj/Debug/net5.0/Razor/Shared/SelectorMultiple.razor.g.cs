#pragma checksum "C:\Users\Peregrino\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Shared\SelectorMultiple.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f6158f4bda0a7ec53d8e99034da58f9bcba99e1"
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
#nullable restore
#line 13 "C:\Users\Peregrino\source\repos\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using BlazorPeliculas.Shared.DTOs;

#line default
#line hidden
#nullable disable
    public partial class SelectorMultiple : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "selector-multiple");
            __builder.OpenElement(2, "ul");
            __builder.AddAttribute(3, "class", "selectable-ul");
#nullable restore
#line 3 "C:\Users\Peregrino\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Shared\SelectorMultiple.razor"
         foreach (var item in NoSeleccionados)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "li");
            __builder.AddAttribute(5, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 5 "C:\Users\Peregrino\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Shared\SelectorMultiple.razor"
                            () => Seleccionar(item)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(6, 
#nullable restore
#line 5 "C:\Users\Peregrino\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Shared\SelectorMultiple.razor"
                                                       item.Valor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 6 "C:\Users\Peregrino\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Shared\SelectorMultiple.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "selector-multiple-botones");
            __builder.OpenElement(10, "button");
            __builder.AddAttribute(11, "type", "button");
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "C:\Users\Peregrino\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Shared\SelectorMultiple.razor"
                                        SeleccionarTodo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(13, ">>");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n        ");
            __builder.OpenElement(15, "button");
            __builder.AddAttribute(16, "type", "button");
            __builder.AddAttribute(17, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\Peregrino\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Shared\SelectorMultiple.razor"
                                        DeseleccionarTodo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(18, 
#nullable restore
#line 10 "C:\Users\Peregrino\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Shared\SelectorMultiple.razor"
                                                            removerTodoTexto

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n    ");
            __builder.OpenElement(20, "ul");
            __builder.AddAttribute(21, "class", "selectable-ul");
#nullable restore
#line 13 "C:\Users\Peregrino\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Shared\SelectorMultiple.razor"
         foreach (var item in Seleccionados)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(22, "li");
            __builder.AddAttribute(23, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "C:\Users\Peregrino\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Shared\SelectorMultiple.razor"
                            () => Deseleccionar(item)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(24, 
#nullable restore
#line 15 "C:\Users\Peregrino\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Shared\SelectorMultiple.razor"
                                                         item.Valor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 16 "C:\Users\Peregrino\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Shared\SelectorMultiple.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 19 "C:\Users\Peregrino\source\repos\BlazorPeliculas\BlazorPeliculas\Client\Shared\SelectorMultiple.razor"
       
    private string removerTodoTexto = "<<";
    [Parameter] public List<SelectorMultipleModel> NoSeleccionados { get; set; } = new List<SelectorMultipleModel>();
    [Parameter] public List<SelectorMultipleModel> Seleccionados { get; set; } = new List<SelectorMultipleModel>();

    private void Seleccionar(SelectorMultipleModel item)
    {
        NoSeleccionados.Remove(item);
        Seleccionados.Add(item);
    }
    
    private void Deseleccionar(SelectorMultipleModel item)
    {
        Seleccionados.Remove(item);
        NoSeleccionados.Add(item);
    }

    private void SeleccionarTodo()
    {
        Seleccionados.AddRange(NoSeleccionados);
        NoSeleccionados.Clear();
    }

    private void DeseleccionarTodo()
    {
        NoSeleccionados.AddRange(Seleccionados);
        Seleccionados.Clear();
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
