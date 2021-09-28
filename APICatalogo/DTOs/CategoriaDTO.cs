using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APICatalogo.DTOs
{
    public class CategoriaDTO
    {

        public int Id { get; set; }
       
        public String Nome { get; set; }
    
        public String ImagemUrl { get; set; }

        public ICollection<ProdutoDTO> Produtos { get; set; }
    }
}
