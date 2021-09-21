using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace APICatalogo.Models
{
    [Table("Categorias")]
    public class Categoria
    {
       
        public Categoria()
        {
            Produtos = new Collection<Produto>(); 
        }  
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(80)]
        public String Nome { get; set; }
        [Required]
        [MaxLength(300)]
        public String ImagemUrl { get; set; }
        [JsonIgnore]
        public ICollection<Produto> Produtos { get; set; }

    }
}
