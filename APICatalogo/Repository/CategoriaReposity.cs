using APICatalogo.Context;
using APICatalogo.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace APICatalogo.Repository
{
    public class CategoriaReposity : Repository<Categoria>, ICategoriaRepository
    {
        public CategoriaReposity(AppDbContext contexto) : base(contexto)
        {

        }

        public IEnumerable<Categoria> GetCategoriasProdutos()
        {
            return Get().Include(x => x.Produtos);
        }

      
    }
}
