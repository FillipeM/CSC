#pragma checksum "C:\Users\Fillipe\source\repos\CSC\CSC\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "43abb8255651a69fe6ed9084bac181efd4e85657"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43abb8255651a69fe6ed9084bac181efd4e85657", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8f7803b5c3e1a990a792b9e38edf9a152a8d8cc", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "3", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "4", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Fillipe\source\repos\CSC\CSC\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""col-lg-12"">
    <div class=""row"">
        <div class=""margin-top"">
            <div class=""row"">
                <div class=""col-md-1 align-content-right"">
                    <label for=""txtNumChamado"" class=""custom-control-label"">Nº Chamado</label>
                </div>
                <div class=""col-md-3"">
                    <input type=""text"" id=""txtNumChamado"" class=""form-control display-inline"" />
                </div>
                <div class=""col-md-1 align-content-right"">
                    <label for=""dpdStatus"" class=""custom-control-label"">Status</label>
                </div>
                <div class=""col-md-6"">
                    <select id=""dpdStatus"" class=""form-control display-inline"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "43abb8255651a69fe6ed9084bac181efd4e856575310", async() => {
                WriteLiteral("Aberto");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "43abb8255651a69fe6ed9084bac181efd4e856576493", async() => {
                WriteLiteral("Em Andamento");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "43abb8255651a69fe6ed9084bac181efd4e856577682", async() => {
                WriteLiteral("Aguardando Reposta");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "43abb8255651a69fe6ed9084bac181efd4e856578877", async() => {
                WriteLiteral("Fechado");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </select>
                </div>
                <div class=""col-md-1 align-content-right"" >
                    <input type=""button"" id=""btnConsultar"" class=""btn btn-success"" value=""Consultar"" />
                </div>
            </div>
            <div class=""row margin-top"">
                <div class=""col-md-1 align-content-right"">
                    <label for=""dpdDepartamento"" class=""custom-control-label"">Departamento</label>
                </div>
                <div class=""col-md-3"">
                    <select id=""dpdDepartamento"" class=""form-control display-inline"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "43abb8255651a69fe6ed9084bac181efd4e8565710702", async() => {
                WriteLiteral("Departamento 1");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "43abb8255651a69fe6ed9084bac181efd4e8565711894", async() => {
                WriteLiteral("Departamento 2");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "43abb8255651a69fe6ed9084bac181efd4e8565713086", async() => {
                WriteLiteral("Departamento 3");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "43abb8255651a69fe6ed9084bac181efd4e8565714278", async() => {
                WriteLiteral("Departamento 4");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </select>
                </div>
            </div>
            <div class=""row margin-top"">
                <div class=""col-md-1 align-content-right"">
                    <label for=""txtPeriodoDe"" class=""custom-control-label"">Período</label>
                </div>
                <div class=""col-md-2"">
                    <input type=""date"" id=""txtPeriodoDe"" class=""form-control display-inline""");
            BeginWriteAttribute("value", " value=\"", 2361, "\"", 2405, 1);
#nullable restore
#line 48 "C:\Users\Fillipe\source\repos\CSC\CSC\Views\Home\Index.cshtml"
WriteAttributeValue("", 2369, DateTime.Now.ToString("yyyy-MM-dd"), 2369, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                </div>
                <div class=""col-md-1 align-content-right"">
                    <label for=""txtPeriodoAte"" class=""custom-control-label"">Até</label>
                </div>
                <div class=""col-md-2"">
                    <input type=""date"" id=""txtPeriodoAte"" class=""form-control display-inline""");
            BeginWriteAttribute("value", " value=\"", 2741, "\"", 2785, 1);
#nullable restore
#line 54 "C:\Users\Fillipe\source\repos\CSC\CSC\Views\Home\Index.cshtml"
WriteAttributeValue("", 2749, DateTime.Now.ToString("yyyy-MM-dd"), 2749, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                </div>\r\n            </div>\r\n            <div class=\"row margin-top\">\r\n                <table class=\"table table-striped\">\r\n                    <thead>\r\n                        <tr>\r\n");
#nullable restore
#line 61 "C:\Users\Fillipe\source\repos\CSC\CSC\Views\Home\Index.cshtml"
                              
                                var mockList = new List<string>();
                                mockList.Add("Chamado");
                                mockList.Add("Abertura");
                                mockList.Add("Assunto");
                                mockList.Add("Tipo");
                                mockList.Add("Categoria");
                                mockList.Add("Status");
                                mockList.Add("Solicitante");
                                mockList.Add("Departamento");
                                mockList.Add("Unidade");

                                foreach (var item in mockList)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td>\r\n                                        ");
#nullable restore
#line 76 "C:\Users\Fillipe\source\repos\CSC\CSC\Views\Home\Index.cshtml"
                                   Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n");
#nullable restore
#line 78 "C:\Users\Fillipe\source\repos\CSC\CSC\Views\Home\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td></td>\r\n");
            WriteLiteral("                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n");
#nullable restore
#line 84 "C:\Users\Fillipe\source\repos\CSC\CSC\Views\Home\Index.cshtml"
                          

                            var mockListChamado = new List<ChamadoModel>();
                            var tipoChamado1 = new TipoAtendimentoModel
                            {
                                CodTipo = 1,
                                TipoServico = "Integração",
                                Categoria = new CategoriaModel { CodCategoria = 1, Categoria="Sênior ERP"},
                                Depto = new DepartamentoModel { CodDepto = 1, Departamento = "Cabine Fiscal"}
                            };

                            var situacao1 = new SituacaoModel
                            {
                                CodSituacao = 1,
                                Situacao = "Ag. Atendimento"
                            };

                            var usuarioSolicitante1 = new UsuarioModel
                            {
                                CodUsu = 1,
                                NomeUsu = "Nádia Coelho"
                            };

                            mockListChamado.Add(new ChamadoModel
                            {
                                CodChamado = 1,
                                DataAbertura = new DateTime(2022, 2, 17),
                                HoraAbertura = new DateTime(1900, 1, 1, 8, 0, 0),
                                Titulo = "Nota 123 não está integrando",
                                Tipo = tipoChamado1,
                                Situacao = situacao1,
                                UsuSolicitante = usuarioSolicitante1,
                                CodFilialUsuario = 15
                            });


                            var tipoChamado2 = new TipoAtendimentoModel
                            {
                                CodTipo = 2,
                                TipoServico = "Lentidão",
                                Categoria = new CategoriaModel { CodCategoria = 2, Categoria = "Pecus" },
                                Depto = new DepartamentoModel { CodDepto = 1, Departamento = "Cabine Fiscal" }
                            };

                            var situacao2 = new SituacaoModel
                            {
                                CodSituacao = 2,
                                Situacao = "Em Atendimento"
                            };

                            var usuarioSolicitante2 = new UsuarioModel
                            {
                                CodUsu = 2,
                                NomeUsu = "Hugo Pena"
                            };
                            mockListChamado.Add(new ChamadoModel
                            {
                                CodChamado = 2,
                                DataAbertura = new DateTime(2022, 2, 18),
                                HoraAbertura = new DateTime(1900, 1, 1, 15, 35, 0),
                                Titulo = "Não está gerando análise de embarque",
                                Tipo = tipoChamado2,
                                Situacao = situacao2,
                                UsuSolicitante = usuarioSolicitante2,
                                CodFilialUsuario = 1
                            });


                            var tipoChamado3 = new TipoAtendimentoModel
                            {
                                CodTipo = 3,
                                TipoServico = "Erro",
                                Categoria = new CategoriaModel { CodCategoria = 3, Categoria = "Sênior RH" },
                                Depto = new DepartamentoModel { CodDepto = 2, Departamento = "RH" }
                            };

                            var situacao3 = new SituacaoModel
                            {
                                CodSituacao = 3,
                                Situacao = "Ag. Solicitante"
                            };

                            var usuarioSolicitante3 = new UsuarioModel
                            {
                                CodUsu = 3,
                                NomeUsu = "Gabriel Souza"
                            };
                            mockListChamado.Add(new ChamadoModel
                            {
                                CodChamado = 3,
                                DataAbertura = new DateTime(2022, 2, 18),
                                HoraAbertura = new DateTime(1900, 1, 1, 17, 0, 0),
                                Titulo = "Registro de Ponto não está aparecendo",
                                Tipo = tipoChamado3,
                                Situacao = situacao3,
                                UsuSolicitante = usuarioSolicitante3,
                                CodFilialUsuario = 1
                            });

                            foreach (var item in mockListChamado)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n");
#nullable restore
#line 186 "C:\Users\Fillipe\source\repos\CSC\CSC\Views\Home\Index.cshtml"
                                      
                                        var filial = item.CodFilialUsuario == 1 ? "ARI" : "SFG";
                                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td>\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "43abb8255651a69fe6ed9084bac181efd4e8565724472", async() => {
#nullable restore
#line 190 "C:\Users\Fillipe\source\repos\CSC\CSC\Views\Home\Index.cshtml"
                                                                                      Write(item.CodChamado);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 9339, "~/AberturaChamado/Index/", 9339, 24, true);
#nullable restore
#line 190 "C:\Users\Fillipe\source\repos\CSC\CSC\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 9363, item.CodChamado, 9363, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 193 "C:\Users\Fillipe\source\repos\CSC\CSC\Views\Home\Index.cshtml"
                                   Write(item.DataAbertura.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 193 "C:\Users\Fillipe\source\repos\CSC\CSC\Views\Home\Index.cshtml"
                                                                          Write(item.HoraAbertura.ToString("HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 196 "C:\Users\Fillipe\source\repos\CSC\CSC\Views\Home\Index.cshtml"
                                   Write(item.Titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 199 "C:\Users\Fillipe\source\repos\CSC\CSC\Views\Home\Index.cshtml"
                                   Write(item.Tipo.TipoServico);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 202 "C:\Users\Fillipe\source\repos\CSC\CSC\Views\Home\Index.cshtml"
                                   Write(item.Tipo.Categoria.Categoria);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 205 "C:\Users\Fillipe\source\repos\CSC\CSC\Views\Home\Index.cshtml"
                                   Write(item.Situacao.Situacao);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 208 "C:\Users\Fillipe\source\repos\CSC\CSC\Views\Home\Index.cshtml"
                                   Write(item.UsuSolicitante.NomeUsu);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 211 "C:\Users\Fillipe\source\repos\CSC\CSC\Views\Home\Index.cshtml"
                                   Write(item.Tipo.Depto.Departamento);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 214 "C:\Users\Fillipe\source\repos\CSC\CSC\Views\Home\Index.cshtml"
                                   Write(filial);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 217 "C:\Users\Fillipe\source\repos\CSC\CSC\Views\Home\Index.cshtml"
                            }
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"col\">\r\n                    <span>Total de Chamados: <span class=\"font-weight-bold\">");
#nullable restore
#line 224 "C:\Users\Fillipe\source\repos\CSC\CSC\Views\Home\Index.cshtml"
                                                                       Write(mockListChamado.Count().ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></span>\r\n                </div>\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
