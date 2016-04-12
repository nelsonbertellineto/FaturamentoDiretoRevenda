using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FaturamentoDiretoRevenda.Model
{
    public partial class UsuarioMod
    {
        public int Id { get; set; }
        public Nullable<int> IdRevenda { get; set; }

        [Display(Name = "Login: ")]
        [Required(ErrorMessage = "Ops, Informe o Login!")]

        public string Login { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public Nullable<int> TipoAcesso { get; set; }
        public Nullable<System.DateTime> DataCadastro { get; set; }
        public Nullable<bool> Ativo { get; set; }

        public virtual RevendaMod Revenda { get; set; }
    }
}
