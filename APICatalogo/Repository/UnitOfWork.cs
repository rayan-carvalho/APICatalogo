﻿using APICatalogo.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APICatalogo.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private ProdutoRepository _produtoRepo;
        private ICategoriaRepository _categoriaRepo;
        public AppDbContext _context;

        public UnitOfWork(AppDbContext contexto)
        {
            _context = contexto;

        }
        public IProdutoRepository ProdutoRepository
        {
            get
            {
                return _produtoRepo = _produtoRepo ?? new ProdutoRepository(_context);
            }
        }

        public ICategoriaRepository CategoriaRepository
        {
            get
            {
                return _categoriaRepo = _categoriaRepo ?? new CategoriaReposity(_context);
            }
        
        }

        public void Commit()
        {
            _context.SaveChanges();
        }
             

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
