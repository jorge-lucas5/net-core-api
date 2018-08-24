using MyWebApp.AcessoDados.Entidades;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyWebApp.AcessoDados
{
    public interface IProdutoRepository
    {
        Task<List<Produto>> Listar();
        Task<Produto> Buscar(int id);
        Task<int> Cadastrar(Produto produto);
    }
}