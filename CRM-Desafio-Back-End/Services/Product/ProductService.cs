using AutoMapper;
using CRM_Desafio_Back_End.Dtos.Product;
using CRM_Desafio_Back_End.Model;
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
        public async Task<ProductViewDto> cadatrarProduto(ProductCriacaoDto productCriacaoDto)
        {
            var productModel = _mapper.Map<ProductModel>(productCriacaoDto);
            await _productRepository.cadatrarProduto(productModel);
            return _mapper.Map<ProductViewDto>(productModel);
        }

        public Task<List<ProductViewDto>> listarProdutos()
        {
            throw new NotImplementedException();
        }
    }
}
