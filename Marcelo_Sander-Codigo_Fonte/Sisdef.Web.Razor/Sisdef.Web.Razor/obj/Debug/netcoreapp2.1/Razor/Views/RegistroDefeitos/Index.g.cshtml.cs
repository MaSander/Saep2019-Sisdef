#pragma checksum "C:\Users\51755101856\Desktop\Saep\Sisdef.Web.Razor\Sisdef.Web.Razor\Views\RegistroDefeitos\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9805fb54f0fd79eb662d027ad3ff6ac2a4c2622a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RegistroDefeitos_Index), @"mvc.1.0.view", @"/Views/RegistroDefeitos/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/RegistroDefeitos/Index.cshtml", typeof(AspNetCore.Views_RegistroDefeitos_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\51755101856\Desktop\Saep\Sisdef.Web.Razor\Sisdef.Web.Razor\Views\_ViewImports.cshtml"
using Sisdef.Web.Razor;

#line default
#line hidden
#line 2 "C:\Users\51755101856\Desktop\Saep\Sisdef.Web.Razor\Sisdef.Web.Razor\Views\_ViewImports.cshtml"
using Sisdef.Web.Razor.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9805fb54f0fd79eb662d027ad3ff6ac2a4c2622a", @"/Views/RegistroDefeitos/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ce1e606fc4b3f4ba09d93a1fad45e5a0e163052", @"/Views/_ViewImports.cshtml")]
    public class Views_RegistroDefeitos_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Sisdef.Web.Razor.Domains.RegistroDefeito>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(62, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\51755101856\Desktop\Saep\Sisdef.Web.Razor\Sisdef.Web.Razor\Views\RegistroDefeitos\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(105, 453, true);
            WriteLiteral(@"<table class=""table"">
    <thead>
        <tr>
            <th>
                Data
            </th>
            <th>
                Equipamento
            </th>
            <th>
                Tipo defeito
            </th>
            <th>
                Hora de inicio
            </th>
            <th>
                Hora final
            </th>
            <th>Tempo Parado</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 28 "C:\Users\51755101856\Desktop\Saep\Sisdef.Web.Razor\Sisdef.Web.Razor\Views\RegistroDefeitos\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(590, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(639, 47, false);
#line 31 "C:\Users\51755101856\Desktop\Saep\Sisdef.Web.Razor\Sisdef.Web.Razor\Views\RegistroDefeitos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DataProblema));

#line default
#line hidden
            EndContext();
            BeginContext(686, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(742, 67, false);
#line 34 "C:\Users\51755101856\Desktop\Saep\Sisdef.Web.Razor\Sisdef.Web.Razor\Views\RegistroDefeitos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Equipamento.TipoEquipamento.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(809, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(865, 47, false);
#line 37 "C:\Users\51755101856\Desktop\Saep\Sisdef.Web.Razor\Sisdef.Web.Razor\Views\RegistroDefeitos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Defeito.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(912, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(968, 45, false);
#line 40 "C:\Users\51755101856\Desktop\Saep\Sisdef.Web.Razor\Sisdef.Web.Razor\Views\RegistroDefeitos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.HoraInicio));

#line default
#line hidden
            EndContext();
            BeginContext(1013, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1069, 44, false);
#line 43 "C:\Users\51755101856\Desktop\Saep\Sisdef.Web.Razor\Sisdef.Web.Razor\Views\RegistroDefeitos\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.HoraFinal));

#line default
#line hidden
            EndContext();
            BeginContext(1113, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1169, 42, false);
#line 46 "C:\Users\51755101856\Desktop\Saep\Sisdef.Web.Razor\Sisdef.Web.Razor\Views\RegistroDefeitos\Index.cshtml"
           Write(Html.Raw(item.HoraFinal - item.HoraInicio));

#line default
#line hidden
            EndContext();
            BeginContext(1211, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 49 "C:\Users\51755101856\Desktop\Saep\Sisdef.Web.Razor\Sisdef.Web.Razor\Views\RegistroDefeitos\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1250, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Sisdef.Web.Razor.Domains.RegistroDefeito>> Html { get; private set; }
    }
}
#pragma warning restore 1591
