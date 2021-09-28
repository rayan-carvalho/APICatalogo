using System;

namespace APICatalogo.DTOs
{
    public class ProdutoDTO
    {

        public int Id { get; set; }

        public String Nome { get; set; }
      
        public String Descricao { get; set; }
    
        public Decimal Preco { get; set; }
    
        public String ImagemUrl { get; set; }
  
        public int CategoriaId { get; set; }
    }
}
