#pragma checksum "E:\repos\BlazorPeliculas\BlazorPeliculas\Client\Shared\SelectorMultipleTypeahead.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5dd617e022d36d7d102d95fcade12e47ed7772f6"
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
#line 1 "E:\repos\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\repos\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\repos\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\repos\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\repos\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\repos\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\repos\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\repos\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using BlazorPeliculas.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\repos\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using BlazorPeliculas.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\repos\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using BlazorPeliculas.Shared.Entidades;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\repos\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using BlazorPeliculas.Client.Repositories;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "E:\repos\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using BlazorPeliculas.Client.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "E:\repos\BlazorPeliculas\BlazorPeliculas\Client\_Imports.razor"
using BlazorPeliculas.Shared.DTOs;

#line default
#line hidden
#nullable disable
    public partial class SelectorMultipleTypeahead<T> : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __Blazor.BlazorPeliculas.Client.Shared.SelectorMultipleTypeahead.TypeInference.CreateCustomTypeahead_0(__builder, 0, 1, 
#nullable restore
#line 3 "E:\repos\BlazorPeliculas\BlazorPeliculas\Client\Shared\SelectorMultipleTypeahead.razor"
                                 (string value) => SearchMethod(value)

#line default
#line hidden
#nullable disable
            , 2, 
#nullable restore
#line 4 "E:\repos\BlazorPeliculas\BlazorPeliculas\Client\Shared\SelectorMultipleTypeahead.razor"
                         sampleItem

#line default
#line hidden
#nullable disable
            , 3, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 5 "E:\repos\BlazorPeliculas\BlazorPeliculas\Client\Shared\SelectorMultipleTypeahead.razor"
                                 (T item) => ElementoSeleccionado(item)

#line default
#line hidden
#nullable disable
            ), 4, (context) => (__builder2) => {
                __builder2.AddContent(5, 
#nullable restore
#line 7 "E:\repos\BlazorPeliculas\BlazorPeliculas\Client\Shared\SelectorMultipleTypeahead.razor"
         MyResultTemplate(context)

#line default
#line hidden
#nullable disable
                );
            }
            );
            __builder.AddMarkupContent(6, "\r\n\r\n");
            __builder.OpenElement(7, "ul");
            __builder.AddAttribute(8, "class", "list-group");
#nullable restore
#line 12 "E:\repos\BlazorPeliculas\BlazorPeliculas\Client\Shared\SelectorMultipleTypeahead.razor"
     foreach (var item in ElementosSeleccionados)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(9, "li");
            __builder.AddAttribute(10, "draggable", "true");
            __builder.AddAttribute(11, "ondragstart", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.DragEventArgs>(this, 
#nullable restore
#line 15 "E:\repos\BlazorPeliculas\BlazorPeliculas\Client\Shared\SelectorMultipleTypeahead.razor"
                          (() => HandleDragStart(item))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "ondragover", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.DragEventArgs>(this, 
#nullable restore
#line 16 "E:\repos\BlazorPeliculas\BlazorPeliculas\Client\Shared\SelectorMultipleTypeahead.razor"
                         (() => HandleDragOver(item))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "class", "list-group-item list-group-item-action");
            __builder.AddContent(14, 
#nullable restore
#line 18 "E:\repos\BlazorPeliculas\BlazorPeliculas\Client\Shared\SelectorMultipleTypeahead.razor"
             MyListTemplate(item)

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(15, "\r\n            ");
            __builder.OpenElement(16, "span");
            __builder.AddAttribute(17, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "E:\repos\BlazorPeliculas\BlazorPeliculas\Client\Shared\SelectorMultipleTypeahead.razor"
                              () => ElementosSeleccionados.Remove(item)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "class", "badge badge-primary badge-pill");
            __builder.AddAttribute(19, "style", "cursor: pointer");
            __builder.AddContent(20, "X");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 23 "E:\repos\BlazorPeliculas\BlazorPeliculas\Client\Shared\SelectorMultipleTypeahead.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 26 "E:\repos\BlazorPeliculas\BlazorPeliculas\Client\Shared\SelectorMultipleTypeahead.razor"
       
    [Parameter] public List<T> ElementosSeleccionados { get; set; } = new List<T>();
    [Parameter] public Func<string, Task<IEnumerable<T>>> SearchMethod { get; set; }
    [Parameter] public RenderFragment<T> MyResultTemplate { get; set; }
    [Parameter] public RenderFragment<T> MyListTemplate { get; set; }
    T sampleItem = default(T);
    T itemArrastrado;

    private void ElementoSeleccionado(T item)
    {
        if (!ElementosSeleccionados.Any(x => x.Equals(item)))
        {
            ElementosSeleccionados.Add(item);
        }
        sampleItem = default(T);
    }

    private void HandleDragStart(T item)
    {
        itemArrastrado = item;
    }

    private void HandleDragOver(T item)
    {
        if (!item.Equals(itemArrastrado))
        {
            var indiceElementoArrastrado = ElementosSeleccionados.IndexOf(itemArrastrado);
            var indiceElemento = ElementosSeleccionados.IndexOf(item);
            ElementosSeleccionados[indiceElemento] = itemArrastrado;
            ElementosSeleccionados[indiceElementoArrastrado] = item;

        }
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.BlazorPeliculas.Client.Shared.SelectorMultipleTypeahead
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateCustomTypeahead_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Func<global::System.String, global::System.Threading.Tasks.Task<global::System.Collections.Generic.IEnumerable<TItem>>> __arg0, int __seq1, TItem __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TItem> __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment<TItem> __arg3)
        {
        __builder.OpenComponent<global::BlazorPeliculas.Client.Shared.CustomTypeahead<TItem>>(seq);
        __builder.AddAttribute(__seq0, "SearchMethod", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ResultTemplate", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
