using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace CSC.Models
{
    public class SituacaoModel
    {
        [DisplayName("Código")]
        public int CodSituacao {get;set;}

        [DisplayName("Situação")]
        public string Situacao { get; set; }

        [DisplayName("Ativo")]
        public bool Ativo { get; set; }

        [DisplayName("Aplicação")]
        public string Aplicacao { get; set; }
    }
}
