#pragma checksum "C:\MisionTic2022-Ciclo3\TorneoFutbolDepartamental\TorneoFIFA\TorneoDeFutbol.App\TorneoDeFutbol.App.Frontend\Pages\Jugadores\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2595298ef057b926a23f1c9c5cc56973c8f6c68"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(TorneoDeFutbol.App.Frontend.Pages.Jugadores.Pages_Jugadores_Details), @"mvc.1.0.razor-page", @"/Pages/Jugadores/Details.cshtml")]
namespace TorneoDeFutbol.App.Frontend.Pages.Jugadores
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\MisionTic2022-Ciclo3\TorneoFutbolDepartamental\TorneoFIFA\TorneoDeFutbol.App\TorneoDeFutbol.App.Frontend\Pages\_ViewImports.cshtml"
using TorneoDeFutbol.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2595298ef057b926a23f1c9c5cc56973c8f6c68", @"/Pages/Jugadores/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e55bba874a4eaba2fbec1ae0e3f7192bf8d5283", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Jugadores_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Detalle del Jugador</h1>\r\n<table class=\"table table-striped\">\r\n \r\n        <tr>\r\n            <th scope=\"col\">Nombres</th>\r\n            <td>");
#nullable restore
#line 10 "C:\MisionTic2022-Ciclo3\TorneoFutbolDepartamental\TorneoFIFA\TorneoDeFutbol.App\TorneoDeFutbol.App.Frontend\Pages\Jugadores\Details.cshtml"
           Write(Model.jugador.nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <th scope=\"col\">Apellidos</th> \r\n            <td>");
#nullable restore
#line 14 "C:\MisionTic2022-Ciclo3\TorneoFutbolDepartamental\TorneoFIFA\TorneoDeFutbol.App\TorneoDeFutbol.App.Frontend\Pages\Jugadores\Details.cshtml"
           Write(Model.jugador.apellido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>   \r\n        </tr>\r\n        <tr>\r\n            <th scope=\"col\">Número Camiseta</th> \r\n            <td>");
#nullable restore
#line 18 "C:\MisionTic2022-Ciclo3\TorneoFutbolDepartamental\TorneoFIFA\TorneoDeFutbol.App\TorneoDeFutbol.App.Frontend\Pages\Jugadores\Details.cshtml"
           Write(Model.jugador.numCamiseta);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <th scope = \"col\">Posición</th>\r\n            <td>");
#nullable restore
#line 22 "C:\MisionTic2022-Ciclo3\TorneoFutbolDepartamental\TorneoFIFA\TorneoDeFutbol.App\TorneoDeFutbol.App.Frontend\Pages\Jugadores\Details.cshtml"
           Write(Model.jugador.posicion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr> \r\n        <tr>\r\n            <th scope=\"col\">Fecha de Nacimiento</th>\r\n            <td>");
#nullable restore
#line 26 "C:\MisionTic2022-Ciclo3\TorneoFutbolDepartamental\TorneoFIFA\TorneoDeFutbol.App\TorneoDeFutbol.App.Frontend\Pages\Jugadores\Details.cshtml"
           Write(Model.jugador.fechaNacimiento);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <th scope = \"col\">Género</th>\r\n            <td>");
#nullable restore
#line 30 "C:\MisionTic2022-Ciclo3\TorneoFutbolDepartamental\TorneoFIFA\TorneoDeFutbol.App\TorneoDeFutbol.App.Frontend\Pages\Jugadores\Details.cshtml"
           Write(Model.jugador.genero);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <th scope = \"col\">Dirección</th>\r\n            <td>");
#nullable restore
#line 34 "C:\MisionTic2022-Ciclo3\TorneoFutbolDepartamental\TorneoFIFA\TorneoDeFutbol.App\TorneoDeFutbol.App.Frontend\Pages\Jugadores\Details.cshtml"
           Write(Model.jugador.direccion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr> \r\n        <tr>\r\n             <th scope=\"col\">Teléfono</th>\r\n             <td>");
#nullable restore
#line 38 "C:\MisionTic2022-Ciclo3\TorneoFutbolDepartamental\TorneoFIFA\TorneoDeFutbol.App\TorneoDeFutbol.App.Frontend\Pages\Jugadores\Details.cshtml"
            Write(Model.jugador.numTelefono);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>   \r\n        </tr>\r\n        \r\n    </table>\r\n\r\n            \r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b2595298ef057b926a23f1c9c5cc56973c8f6c687119", async() => {
                WriteLiteral("Volver");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TorneoDeFutbol.App.Frontend.Pages.Jugadores.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TorneoDeFutbol.App.Frontend.Pages.Jugadores.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TorneoDeFutbol.App.Frontend.Pages.Jugadores.DetailsModel>)PageContext?.ViewData;
        public TorneoDeFutbol.App.Frontend.Pages.Jugadores.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
