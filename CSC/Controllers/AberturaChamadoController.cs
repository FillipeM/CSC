using CSC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSC.Controllers
{
    public class AberturaChamadoController : Controller
    {
        public IActionResult Index(int id)
        {
            if (id > 0)
            {
                var mockListChamado = new List<ChamadoModel>();
                var tipoChamado1 = new TipoAtendimentoModel
                {
                    CodTipo = 1,
                    TipoServico = "Integração",
                    Categoria = new CategoriaModel { CodCategoria = 1, Categoria = "Sênior ERP" },
                    Depto = new DepartamentoModel { CodDepto = 1, Departamento = "Cabine Fiscal" }
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

                return View(mockListChamado.Where(f => f.CodChamado == id).FirstOrDefault());
            }
            return View(new ChamadoModel());
        }
    }
}
