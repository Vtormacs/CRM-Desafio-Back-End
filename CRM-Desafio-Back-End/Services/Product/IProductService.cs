using CRM_Desafio_Back_End.Dtos.Product;

namespace CRM_Desafio_Back_End.Services.Product
{
    public interface IProductService
    {
        Task<ProductViewDto> cadatrarProduto(ProductCriacaoDto productCriacaoDto);
        Task<List<ProductViewDto>> listarProdutos();
    }
}
