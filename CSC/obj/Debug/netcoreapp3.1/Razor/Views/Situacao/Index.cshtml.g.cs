#pragma checksum "C:\Users\Fillipe\source\repos\CSC\CSC\Views\Situacao\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "739e843487df3b71f2a4fedc6cc1c2dee9e55262"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Situacao_Index), @"mvc.1.0.view", @"/Views/Situacao/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Fillipe\source\repos\CSC\CSC\Views\Situacao\Index.cshtml"
using CSC.Util;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"739e843487df3b71f2a4fedc6cc1c2dee9e55262", @"/Views/Situacao/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8f7803b5c3e1a990a792b9e38edf9a152a8d8cc", @"/Views/_ViewImports.cshtml")]
    public class Views_Situacao_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CSC.Models.SituacaoModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Fillipe\source\repos\CSC\CSC\Views\Situacao\Index.cshtml"
  
    ViewData["Title"] = "Situações";



#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""row m-0"">
    <div class=""row"">
        <h1 class=""h-100 text-center"">
            Situações
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
#line 23 "C:\Users\Fillipe\source\repos\CSC\CSC\Views\Situacao\Index.cshtml"
       Write(Html.LabelFor(model => model.Situacao));

#line default
#line hidden
#nullable disable
            WriteLiteral(":\r\n        </div>\r\n        <div class=\"col-4\">\r\n            ");
#nullable restore
#line 26 "C:\Users\Fillipe\source\repos\CSC\CSC\Views\Situacao\Index.cshtml"
       Write(Html.TextBoxFor(model => model.Situacao, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"col-1 align-content-right\">\r\n            ");
#nullable restore
#line 31 "C:\Users\Fillipe\source\repos\CSC\CSC\Views\Situacao\Index.cshtml"
       Write(Html.LabelFor(model => model.Ativo));

#line default
#line hidden
#nullable disable
            WriteLiteral(":\r\n        </div>\r\n        <div class=\"col-4\">\r\n            ");
#nullable restore
#line 34 "C:\Users\Fillipe\source\repos\CSC\CSC\Views\Situacao\Index.cshtml"
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
#line 44 "C:\Users\Fillipe\source\repos\CSC\CSC\Views\Situacao\Index.cshtml"
                      
                        var mockList = new List<String>();
                        mockList.Add("Descrição");
                        mockList.Add("Aplicação");
                        mockList.Add("Situação");
                        mockList.Add("");

                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "C:\Users\Fillipe\source\repos\CSC\CSC\Views\Situacao\Index.cshtml"
                         foreach (var item in mockList)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>");
#nullable restore
#line 53 "C:\Users\Fillipe\source\repos\CSC\CSC\Views\Situacao\Index.cshtml"
                           Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 54 "C:\Users\Fillipe\source\repos\CSC\CSC\Views\Situacao\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td></td>\r\n");
            WriteLiteral("                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 60 "C:\Users\Fillipe\source\repos\CSC\CSC\Views\Situacao\Index.cshtml"
                  
                    var mockList2 = new List<SituacaoModel>();
                    mockList2.Add(new SituacaoModel
                    {
                        CodSituacao = 1,
                        Aplicacao = "CHAMADOS",
                        Situacao = "PENDENTE",
                        Ativo = true
                    });
                    mockList2.Add(new SituacaoModel
                    {
                        CodSituacao = 2,
                        Aplicacao = "CHAMADOS",
                        Situacao = "EM ANDAMENTO",
                        Ativo = true
                    });
                    mockList2.Add(new SituacaoModel
                    {
                        CodSituacao = 3,
                        Aplicacao = "CHAMADOS",
                        Situacao = "FINALIZADO",
                        Ativo = true
                    });
                    mockList2.Add(new SituacaoModel
                    {
                        CodSituacao = 4,
                        Aplicacao = "PROJETOS",
                        Situacao = "EM VALIDAÇÃO",
                        Ativo = false
                    });


                    foreach (var item in mockList2)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n\r\n                            <td>\r\n                                ");
#nullable restore
#line 97 "C:\Users\Fillipe\source\repos\CSC\CSC\Views\Situacao\Index.cshtml"
                           Write(item.Situacao);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 100 "C:\Users\Fillipe\source\repos\CSC\CSC\Views\Situacao\Index.cshtml"
                           Write(item.Aplicacao);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n");
#nullable restore
#line 103 "C:\Users\Fillipe\source\repos\CSC\CSC\Views\Situacao\Index.cshtml"
                                  var ativo = item.Ativo ? "Ativo" : "Inativo";
                                    var cssclass = item.Ativo ? "bg-success" : "bg-warning";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                <span");
            BeginWriteAttribute("class", " class=\"", 3576, "\"", 3604, 2);
#nullable restore
#line 106 "C:\Users\Fillipe\source\repos\CSC\CSC\Views\Situacao\Index.cshtml"
WriteAttributeValue("", 3584, cssclass, 3584, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 3593, "text-white", 3594, 11, true);
            EndWriteAttribute();
            WriteLiteral(" style=\"padding-left:8px; padding-right:8px; border-radius:20px\">");
#nullable restore
#line 106 "C:\Users\Fillipe\source\repos\CSC\CSC\Views\Situacao\Index.cshtml"
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
#line 113 "C:\Users\Fillipe\source\repos\CSC\CSC\Views\Situacao\Index.cshtml"
                    }

                

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CSC.Models.SituacaoModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
