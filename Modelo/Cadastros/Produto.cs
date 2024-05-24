using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Modelo.Tabelas;

namespace Modelo.Cadastros
{
    public class Produto
    {
        [DisplayName("Id")]
        public long? ProdutoId { get; set; }

        [StringLength(100, ErrorMessage = "O nome do produto precisa ter no mínimo 10 caracteres", MinimumLength = 10)]
        [Required(ErrorMessage = "Informe o nome do produto")]
        public string Nome { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Data de Cadastro")]
        [Required(ErrorMessage = "Informe a data de cadastro do produto")]
        public DateTime DataCadastro { get; set; }

        [DisplayName("Tipo do Logitipo")]
        public string LogotipoMimeType { get; set; }
        [DisplayName("Logotipo")]
        public byte[] Logotipo { get; set; }
        public bool Destaque { get; set; }

        [DisplayName("Nome do arquivo")]
        public string NomeArquivo { get; set; }
        [DisplayName("Tamanho do arquivo")]
        public long TamanhoArquivo { get; set; }

        [DisplayName("Categoria")]
        public long? CategoriaId { get; set; }
        [DisplayName("Fabricante")]
        public long? FabricanteId { get; set; }
        
        public Categoria Categoria { get; set; }
        public Fabricante Fabricante { get; set; }
    }
}