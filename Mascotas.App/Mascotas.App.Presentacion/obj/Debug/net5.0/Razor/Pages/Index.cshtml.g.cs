<<<<<<< HEAD
#pragma checksum "C:\laragon\www\Enigma\EliasMArtinezFunes\Mascotas.App\Mascotas.App.Presentacion\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b7a1d5bbaad83b95a49174f3ebed568704bd68b"
=======
#pragma checksum "C:\E-Pets\Mascotas.App\Mascotas.App.Presentacion\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "09b425cb5b4ad1eb98d9c558f83b8da810e310ec"
>>>>>>> 18e9966b9d8b436aff921354ed213c854d23bd33
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Mascotas.App.Presentasion.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace Mascotas.App.Presentasion.Pages
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
#line 1 "C:\laragon\www\Enigma\EliasMArtinezFunes\Mascotas.App\Mascotas.App.Presentacion\Pages\_ViewImports.cshtml"
using Mascotas.App.Presentasion;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09b425cb5b4ad1eb98d9c558f83b8da810e310ec", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4bbb788fbfeaafe98d446dc0d2ca7f02d63a106", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\laragon\www\Enigma\EliasMArtinezFunes\Mascotas.App\Mascotas.App.Presentacion\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style> 
    .Clasehover:hover{
        box-shadow: 2px 2px red, -1em 0 0.4em #f8f9fa;;
    }
</style>

<div class=""text-center"">
    <div style=""display: grid; grid-template-columns: 1fr 1fr 1fr; gap: 5px;"" >
            <a href=""./Animal/ListaAnimal"">
            <div style=""border: 1px solid green; 2px 2px red, -1em 0 0.4em blue "" class=""Clasehover"">
            <div style=""border: 1px solid red;"" >
                <img src=""https://www.webconsultas.com/sites/default/files/styles/wc_adaptive_noticia__small/public/noticias/mascotas-preferidas-espanoles.jpg"" alt=""Imagen"" width=""200px"" height=""200px"" asp-page=""./ListadoAnimal""/>
            </div>
            <div>
                <h4>Animales</h4>
                <p> Registro de mascotas</p>
            </div>
        </div>
        </a>
        <a href=""./Empresa/ListaEmpresa"">
        <div style=""border: 1px solid green;"" class=""Clasehover"">
            <div style=""border: 1px solid red;"">
                 <img src=""https://thumbs.dre");
            WriteLiteral(@"amstime.com/b/logo-de-empresa-veterinaria-para-tarjetas-identificaci%C3%B3n-perros-y-gatos-perro-gato-tarjeta-veterinario-negocio-logotipo-arco-iris-204761914.jpg"" alt=""Imagen"" width=""200px"" height=""200px"" />
            </div>
            <div>
                <h4>Empresa veterinaria</h4>
                <p>Datos de mpresa veterinaria</p>
            </div>
        </div>
        </a>
        <a href=""./Especializacion/ListaEspecializacion"">
        <div style=""border: 1px solid green;"" class=""Clasehover"">
            <div style=""border: 1px solid red;"">
               <img src=https://mercadoveterinario.com.ar/wp-content/uploads/2020/09/iva-veterinario.jpg alt=""Imagen"" width=""200px"" height=""200px"" />
                </div>
            <div>
                <h4>Especializacion veterinaria</h4>
                <p>Especialidad y veterinario</p>
            </div>
        </div>
        </a>
        <a href=""./Solicitud/ListaSolicitud"">
        <div style=""border: 1px solid green;"" class=""Cl");
            WriteLiteral(@"asehover"">
            <div style=""border: 1px solid red;"">
            <img src=""https://www.pmfarma.com.mx/noticias/noticias/18011/image/check%20up%20medico%20previta.jpg"" alt=""Imagen"" width=""200px"" height=""200px"" />
            </div>
            <div>
                <h4>Solicitud de Visita</h4>
                <p>Aparta la cita para tu mascota</p>
            </div>
        </div>
        </a>
        <a href=""./Veterinario/ListaVeterinario"">
        <div style=""border: 1px solid green;"" class=""Clasehover"">
            <div style=""border: 1px solid red;"">
                <img src=""https://www.purina-latam.com/sites/g/files/auxxlc391/files/styles/large/public/Revisiones%20de%20mi%20perro%20articulacionespeso%20dientes.jpg?itok=9xNX3MPc"" alt=""Imagen"" width=""200px"" height=""200px"" />
                </div>
            <div>
                <h4>Profesional Veterinario</h4>
                <p>Medicos veterinarios</p>
            </div>
        </div>
        </a>
        <a href=""./Visita/");
            WriteLiteral(@"ListaVisita"">
        <div style=""border: 1px solid green;"" class=""Clasehover"">
            <div style=""border: 1px solid red;"">
                <img src=""https://essentialspetcare.com/wp-content/uploads/2021/02/Untitled-19.jpg"" alt=""Imagen"" width=""200px"" height=""200px"" />
            </div>
            <div>
                <h4>Visita Veterinaria</h4>
                <p>Registro de las visitas</p>
            </div>
        </div>
        </a>
    </div>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
