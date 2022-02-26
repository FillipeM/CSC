using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace CSC.Models
{
    public class ChamadoModel
    {
        [DisplayName("Código")]
        public int CodChamado { get; set; }
        [DisplayName("Usuário Solicitante")]
        public UsuarioModel UsuSolicitante { get; set; }
        [DisplayName("Usuário Atendente")]
        public UsuarioModel UsuAtendente { get; set; }
        [DisplayName("Data de Abertura")]
        public DateTime DataAbertura { get; set; }
        [DisplayName("Hora de Abertura")]
        public DateTime HoraAbertura { get; set; }
        [DisplayName("Situação")]
        public SituacaoModel Situacao { get; set; }
        [DisplayName("Tipo")]
        public TipoAtendimentoModel Tipo { get; set; }
        [DisplayName("Título")]
        public string Titulo { get; set; }
        [DisplayName("Observação")]
        public string Observacao { get; set; }
        [DisplayName("Data de Fechamento")]
        public DateTime DataFechamento { get; set; }
        [DisplayName("Hora de Fechamento")]
        public DateTime HoraFechamento { get; set; }
        [DisplayName("Observação Técninca")]
        public string ObservacaoTecnica { get; set; }
        [DisplayName("Código da Atividade")]
        public int CodAtividade { get; set; }
        [DisplayName("Unidade")]
        public int CodFilialUsuario { get; set; }
        public int CodFilialAtendente { get; set; }
    }
}
