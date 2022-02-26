using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace CSC.Models
{
    public class UsuarioModel
    {
        [DisplayName("Código")]
        public int CodUsu { get; set; }
        [DisplayName("Nome")]
        public string NomeUsu { get; set; }
        [DisplayName("Departamento")]
        public DepartamentoModel Depto { get; set; }
        [DisplayName("Ativo")]
        public bool Ativo { get; set; }
        [DisplayName("Atendente")]
        public bool Atendente { get; set; }
        [DisplayName("Permite Abertura Chamado Terceiros")]
        public bool AbreTerceiro { get; set; }
        [DisplayName("Administrador")]
        public bool AdmChamado { get; set; }
        [DisplayName("Filial")]
        public int CodFilial { get; set; }
        [DisplayName("Permite Abertura Chamado")]
        public bool AbreChamado { get; set; }
    }
}
