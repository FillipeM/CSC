using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace CSC.Models
{
    public class NivelAtendimentoModel
    {
        [DisplayName("Código")]
        public int CodNivel { get; set; }

        [DisplayName("Nível")]
        public string Nivel { get; set; }

        [DisplayName("Ativo")]
        public bool Ativo { get; set; }
    }
}
