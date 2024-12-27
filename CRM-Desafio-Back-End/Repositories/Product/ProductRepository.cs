using CRM_Desafio_Back_End.Data;
using CRM_Desafio_Back_End.Model;
using Microsoft.EntityFrameworkCore;

namespace CRM_Desafio_Back_End.Repositories.Product
{
    /// <summary>
    /// Repositório para gerenciar operações relacionadas a produtos no banco de dados.
    /// </summary>
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _appDbContext;

        /// <summary>
        /// Construtor para injetar dependências.
        /// </summary>
        /// <param name="appDbContext">Contexto do banco de dados.</param>
        public ProductRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        /// <summary>
        /// Cadastra um novo produto no banco de dados.
        /// </summary>
        /// <param name="produto">Modelo do produto a ser cadastrado.</param>
        /// <returns>Modelo do produto cadastrado.</returns>
        public async Task<ProductModel> cadatrarProduto(ProductModel produto)
        {
            await _appDbContext.products.AddAsync(produto);
            await _appDbContext.SaveChangesAsync();
            return produto;
        }

        /// <summary>
        /// Lista todos os produtos do banco de dados.
        /// </summary>
        /// <returns>Lista de produtos.</returns>
        public async Task<List<ProductModel>> listarProdutos()
        {
            return await _appDbContext.products.ToListAsync();
        }
    }
}
