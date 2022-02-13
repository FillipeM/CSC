using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace CSC.Models
{
    public class DepartamentoModel
    {
        [DisplayName("Código")]
        public int CodDepto { get; set; }

        [DisplayName("Descrição")]
        public string Departamento { get; set; }

        [DisplayName("Diretoria")]
        public int CodDiretoria { get; set; }

        [DisplayName("Ativo")]
        public bool Ativo{ get; set; }
    }
}
