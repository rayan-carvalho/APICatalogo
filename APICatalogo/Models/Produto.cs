using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace APICatalogo.Models
{
    [Table("Produtos")]
    public class Produto
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(80)]
        public String Nome { get; set; }
        [Required]
        [MaxLength(300)]
        public String Descricao { get; set; }
        [Required]
        public Decimal Preco { get; set; }
        [Required]
        [MaxLength(300)]
        public String ImagemUrl { get; set; }
        public float Estoque { get; set; }
        public DateTime DataCadastro { get; set; }
        public Categoria Categoria { get; set; }
        public int CategoriaId { get; set; }
    }
}
