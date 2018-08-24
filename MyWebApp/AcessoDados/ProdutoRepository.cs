using Microsoft.EntityFrameworkCore;
using MyWebApp.AcessoDados.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebApp.AcessoDados
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly MyWebAppContext _context;

        public ProdutoRepository(MyWebAppContext context)
        {
            this._context = context;
        }

        public Task<Produto> Buscar(int id)
        {
            return _context.Produtos.FindAsync(id);
        }

        public Task<int> Cadastrar(Produto produto)
        {
            _context.AddAsync(produto);
            return _context.SaveChangesAsync();
        }

        Task<List<Produto>> IProdutoRepository.Listar()
        {
            return _context.Produtos.ToListAsync();
        }
    }
}
