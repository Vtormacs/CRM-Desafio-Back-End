using CRM_Desafio_Back_End.Data;
using CRM_Desafio_Back_End.Model;
using Microsoft.EntityFrameworkCore;

namespace CRM_Desafio_Back_End.Repositories.Product
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _appDbContext;
        public ProductRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<ProductModel> cadatrarProduto(ProductModel produto)
        {
            await _appDbContext.products.AddAsync(produto);
            await _appDbContext.SaveChangesAsync();
            return produto;
        }

        public async Task<List<ProductModel>> listarProdutos()
        {
            return await _appDbContext.products.ToListAsync();
        }
    }
}
