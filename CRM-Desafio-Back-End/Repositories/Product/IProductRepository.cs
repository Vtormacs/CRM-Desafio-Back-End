using CRM_Desafio_Back_End.Model;

namespace CRM_Desafio_Back_End.Repositories.Product
{
    public interface IProductRepository
    {
        Task<ProductModel> cadatrarProduto(ProductModel produto);
        Task<List<ProductModel>> listarProdutos();
    }
}
