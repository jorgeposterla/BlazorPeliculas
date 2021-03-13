#pragma checksum "E:\repos\BlazorPeliculas\BlazorPeliculas\Client\Shared\InputImg.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc93b05832064b8ec9b3adbeb6843cef6b73fe55"
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
#nullable restore
#line 1 "E:\repos\BlazorPeliculas\BlazorPeliculas\Client\Shared\InputImg.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\repos\BlazorPeliculas\BlazorPeliculas\Client\Shared\InputImg.razor"
using Tewr.Blazor.FileReader;

#line default
#line hidden
#nullable disable
    public partial class InputImg : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.OpenElement(1, "label");
            __builder.AddContent(2, 
#nullable restore
#line 6 "E:\repos\BlazorPeliculas\BlazorPeliculas\Client\Shared\InputImg.razor"
            Label

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.OpenElement(5, "input");
            __builder.AddAttribute(6, "type", "file");
            __builder.AddAttribute(7, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 8 "E:\repos\BlazorPeliculas\BlazorPeliculas\Client\Shared\InputImg.razor"
                                                          imageFileSelected

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "accept", ".jpg, .jpeg, .png");
            __builder.AddElementReferenceCapture(9, (__value) => {
#nullable restore
#line 8 "E:\repos\BlazorPeliculas\BlazorPeliculas\Client\Shared\InputImg.razor"
                                 inputElement = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n");
            __builder.OpenElement(11, "div");
#nullable restore
#line 12 "E:\repos\BlazorPeliculas\BlazorPeliculas\Client\Shared\InputImg.razor"
     if (imagenBase64 != null)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(12, "div");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "style", "margin: 10px;");
            __builder.OpenElement(15, "img");
            __builder.AddAttribute(16, "src", "data:image.jpeg;base64," + " " + (
#nullable restore
#line 16 "E:\repos\BlazorPeliculas\BlazorPeliculas\Client\Shared\InputImg.razor"
                                                   imagenBase64

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "style", "width: 400px;");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 19 "E:\repos\BlazorPeliculas\BlazorPeliculas\Client\Shared\InputImg.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "E:\repos\BlazorPeliculas\BlazorPeliculas\Client\Shared\InputImg.razor"
     if (ImagenTemporal != null)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(18, "div");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "style", "margin: 10px;");
            __builder.OpenElement(21, "img");
            __builder.AddAttribute(22, "src", 
#nullable restore
#line 24 "E:\repos\BlazorPeliculas\BlazorPeliculas\Client\Shared\InputImg.razor"
                           ImagenTemporal

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(23, "style", "width: 400px;");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 27 "E:\repos\BlazorPeliculas\BlazorPeliculas\Client\Shared\InputImg.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "E:\repos\BlazorPeliculas\BlazorPeliculas\Client\Shared\InputImg.razor"
       
    [Parameter] public string Label { get; set; } = "Imagen";
    [Parameter] public string ImagenTemporal { get; set; }
    [Parameter] public EventCallback<string> ImagenSeleccionada { get; set; }
    private string imagenBase64;
    ElementReference inputElement;

    async Task imageFileSelected()
    {
        foreach (var file in await fileReaderService.CreateReference(inputElement).EnumerateFilesAsync())
        {
            using (MemoryStream memoryStream = await file.CreateMemoryStreamAsync(4 * 1024))
            {
                var bytesImagen = new byte[memoryStream.Length];
                memoryStream.Read(bytesImagen, 0, (int)memoryStream.Length);
                imagenBase64 = Convert.ToBase64String(bytesImagen);
                await ImagenSeleccionada.InvokeAsync(imagenBase64);
                ImagenTemporal = null;
                StateHasChanged();
            }
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Tewr.Blazor.FileReader.IFileReaderService fileReaderService { get; set; }
    }
}
#pragma warning restore 1591
