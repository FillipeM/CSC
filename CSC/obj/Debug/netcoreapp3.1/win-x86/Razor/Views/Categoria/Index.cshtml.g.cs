#pragma checksum "C:\Users\Fillipe\source\repos\CSC\CSC\Views\Categoria\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf4ea55d950f330052c0014bbb17075f61944a16"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Categoria_Index), @"mvc.1.0.view", @"/Views/Categoria/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Fillipe\source\repos\CSC\CSC\Views\_ViewImports.cshtml"
using CSC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Fillipe\source\repos\CSC\CSC\Views\_ViewImports.cshtml"
using CSC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf4ea55d950f330052c0014bbb17075f61944a16", @"/Views/Categoria/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8f7803b5c3e1a990a792b9e38edf9a152a8d8cc", @"/Views/_ViewImports.cshtml")]
    public class Views_Categoria_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CSC.Models.CategoriaModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Fillipe\source\repos\CSC\CSC\Views\Categoria\Index.cshtml"
  
    ViewData["Title"] = "Categorias";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row m-0"">
    <div class=""row"">
        <h1 class=""h-100 text-center"">
            Categorias
        </h1>
    </div>
    <div class=""row row-head-panel margin-top"">
        <div class=""col-11"">
            <h3 class=""h3"">Cadastro</h3>
        </div>
    </div>
    <div class=""row"">
        <div class=""col-1 align-content-right"">
            ");
#nullable restore
#line 19 "C:\Users\Fillipe\source\repos\CSC\CSC\Views\Categoria\Index.cshtml"
       Write(Html.LabelFor(model => model.Categoria));

#line default
#line hidden
#nullable disable
            WriteLiteral(":\r\n        </div>\r\n        <div class=\"col-4\">\r\n            ");
#nullable restore
#line 22 "C:\Users\Fillipe\source\repos\CSC\CSC\Views\Categoria\Index.cshtml"
       Write(Html.TextBoxFor(model => model.Categoria, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"col-1 align-content-right\">\r\n            ");
#nullable restore
#line 27 "C:\Users\Fillipe\source\repos\CSC\CSC\Views\Categoria\Index.cshtml"
       Write(Html.LabelFor(model => model.Ativo));

#line default
#line hidden
#nullable disable
            WriteLiteral(":\r\n        </div>\r\n        <div class=\"col-4\">\r\n            ");
#nullable restore
#line 30 "C:\Users\Fillipe\source\repos\CSC\CSC\Views\Categoria\Index.cshtml"
       Write(Html.CheckBoxFor(model => model.Ativo, new { @class = "form-check-input" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </div>
        <div class=""col-2"">
            <input type=""button"" id=""btnSalvar"" value=""Salvar"" class=""btn btn-success"" />
        </div>
    </div>
    <div class=""row"">
        <table class=""table table-striped"">
            <thead>
                <tr>
");
#nullable restore
#line 40 "C:\Users\Fillipe\source\repos\CSC\CSC\Views\Categoria\Index.cshtml"
                      
                        var mockList = new List<String>();
                        mockList.Add("Descri????o");
                        mockList.Add("Situa????o");
                        mockList.Add("");

                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Users\Fillipe\source\repos\CSC\CSC\Views\Categoria\Index.cshtml"
                         foreach (var item in mockList)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>");
#nullable restore
#line 48 "C:\Users\Fillipe\source\repos\CSC\CSC\Views\Categoria\Index.cshtml"
                           Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 49 "C:\Users\Fillipe\source\repos\CSC\CSC\Views\Categoria\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td></td>\r\n");
            WriteLiteral("                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 55 "C:\Users\Fillipe\source\repos\CSC\CSC\Views\Categoria\Index.cshtml"
                  
                    var mockList2 = new List<CategoriaModel>();
                    mockList2.Add(new CategoriaModel
                    {
                        CodCategoria = 1,
                        Categoria = "PECUS",
                        Ativo = true
                    });
                    mockList2.Add(new CategoriaModel
                    {
                        CodCategoria = 2,
                        Categoria = "BI",
                        Ativo = true
                    });
                    mockList2.Add(new CategoriaModel
                    {
                        CodCategoria = 3,
                        Categoria = "SENIOR",
                        Ativo = true
                    });
                    mockList2.Add(new CategoriaModel
                    {
                        CodCategoria = 4,
                        Categoria = "THOMSON",
                        Ativo = false
                    });


                    foreach (var item in mockList2)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n\r\n                            <td>\r\n                                ");
#nullable restore
#line 88 "C:\Users\Fillipe\source\repos\CSC\CSC\Views\Categoria\Index.cshtml"
                           Write(item.Categoria);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n");
#nullable restore
#line 91 "C:\Users\Fillipe\source\repos\CSC\CSC\Views\Categoria\Index.cshtml"
                                  var ativo = item.Ativo ? "Ativo" : "Inativo";
                                    var cssclass = item.Ativo ? "bg-success" : "bg-warning";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                <span");
            BeginWriteAttribute("class", " class=\"", 3183, "\"", 3211, 2);
#nullable restore
#line 94 "C:\Users\Fillipe\source\repos\CSC\CSC\Views\Categoria\Index.cshtml"
WriteAttributeValue("", 3191, cssclass, 3191, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 3200, "text-white", 3201, 11, true);
            EndWriteAttribute();
            WriteLiteral(" style=\"padding-left:8px; padding-right:8px; border-radius:20px\">");
#nullable restore
#line 94 "C:\Users\Fillipe\source\repos\CSC\CSC\Views\Categoria\Index.cshtml"
                                                                                                                              Write(ativo);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                            </td>
                            <td>
                                <input type=""button"" id=""btnEditar"" value=""Editar"" class=""btn btn-primary"" />
                                <input type=""button"" id=""btnRemover"" value=""Excluir"" class=""btn btn-danger"" />
                            </td>
                        </tr>
");
#nullable restore
#line 101 "C:\Users\Fillipe\source\repos\CSC\CSC\Views\Categoria\Index.cshtml"
                    }

                

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CSC.Models.CategoriaModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
