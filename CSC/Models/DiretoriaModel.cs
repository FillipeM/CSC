using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace CSC.Models
{
    public class DiretoriaModel
    {
        [DisplayName("Código")]
        public int CodDiretoria { get; set; }

        [DisplayName("Descrição")]
        public string Diretoria { get; set; }

        [DisplayName("Ativo")]
        public bool Ativo { get; set; }
    }
}
