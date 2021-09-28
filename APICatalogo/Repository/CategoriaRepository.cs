using ApiCatalogo.Pagination;
using APICatalogo.Context;
using APICatalogo.Models;
using APICatalogo.Pagination;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APICatalogo.Repository
{
    public class CategoriaRepository : Repository<Categoria>, ICategoriaRepository
    {
        public CategoriaRepository(AppDbContext contexto) : base(contexto)
        {

        }

        public async Task<PagedList<Categoria>> GetCategorias(CategoriasParameters cateoriasParameters)
        {
         
            return await PagedList<Categoria>.ToPagedList(Get().OrderBy(on => on.Nome),
                cateoriasParameters.PageNumber, cateoriasParameters.PageSize);
        }

        public  async Task<IEnumerable<Categoria>> GetCategoriasProdutos()
        {
            return await Get().Include(x => x.Produtos).ToListAsync();
        }

      
    }
}
