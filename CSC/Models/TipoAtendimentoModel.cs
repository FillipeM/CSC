using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace CSC.Models
{
    public class TipoAtendimentoModel
    {
        [DisplayName("Código")]
        public int CodTipo { get; set; }
        [DisplayName("Descrição")]
        public string TipoServico { get; set; }
        [DisplayName("Categoria")]
        public CategoriaModel Categoria { get; set; }
        [DisplayName("Nível de Atendimento")]
        public NivelAtendimentoModel Nivel { get; set; }
        [DisplayName("Departamento")]
        public DepartamentoModel Depto{ get; set; }
        [DisplayName("Ativo")]
        public bool Ativo { get; set; }
        [DisplayName("Visível para seleção")]
        public bool VisivelSelecao { get; set; }
        [DisplayName("Prazo P/ Atendimento")]
        public int PrazoAtendimento { get; set; }
    }
}
