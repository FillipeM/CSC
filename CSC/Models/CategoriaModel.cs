using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace CSC.Models
{
    public class CategoriaModel
    {
        [DisplayName("Código")]
        public int CodCategoria { get; set; }
        [DisplayName("Categoria")]
        public string Categoria { get; set; }
        [DisplayName("Ativo")]
        public bool Ativo { get; set; }
    }
}
