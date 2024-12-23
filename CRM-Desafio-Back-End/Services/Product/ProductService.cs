using AutoMapper;
using CRM_Desafio_Back_End.Dtos.Product;
using CRM_Desafio_Back_End.Repositories.Product;

namespace CRM_Desafio_Back_End.Services.Product
{
    public class ProductService : IProductInterface
    {
        public readonly IProductRepository _productRepository;
        public readonly IMapper _mapper;
        public ProductService(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }
        public Task<ProductViewDto> criarProduto(ProductCriacaoDto produto)
        {
            throw new NotImplementedException();
        }

        public Task<List<ProductViewDto>> listarProdutos()
        {
            throw new NotImplementedException();
        }
    }
}
