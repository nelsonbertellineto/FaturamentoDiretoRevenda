using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaturamentoDiretoRevenda.Model
{
    public partial class ProdutoMod
    {
        public int Id { get; set; }
        public Nullable<int> IdRevenda { get; set; }
        public string Codigo { get; set; }
        public string PartNumber { get; set; }
        public string Descricao { get; set; }
        public string DescricaoNF { get; set; }
        public string Unidade { get; set; }
        public string PesoBruto { get; set; }
        public string PesoLiquido { get; set; }
        public Nullable<int> IdMarca { get; set; }
        public Nullable<int> IdTipoProduto { get; set; }
        public string Moeda { get; set; }
        public string PrecoCompra { get; set; }
        public Nullable<int> Lucratividade { get; set; }
        public string DescricaoCompleta { get; set; }
        public string ClassificacaoFiscal { get; set; }
        public string SituaçãoTributaria { get; set; }
        public string CatergoriaICMS { get; set; }
        public string Fornecedores { get; set; }
        public Nullable<System.DateTime> DataCadastro { get; set; }
        public Nullable<bool> Ativo { get; set; }

        public virtual RevendaMod Revenda { get; set; }
    }
}
