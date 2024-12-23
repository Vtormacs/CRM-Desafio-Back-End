using CRM_Desafio_Back_End.Dtos.Product;
using CRM_Desafio_Back_End.Services.Product;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRM_Desafio_Back_End.Controllers
{
    [Route("api/v1/products")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public readonly IProductService _productService;
        public ProductController(IProductService productService) {
            _productService = productService;
        }

        [HttpPost]
        public async Task<ActionResult<ProductViewDto>> CadastrarProduto([FromBody] ProductCriacaoDto productCriacaoDto)
        {
            var product = await _productService.cadatrarProduto(productCriacaoDto);
            return Ok(product);
        }

        [HttpGet]
        public async Task<ActionResult<List<ProductViewDto>>> ListarProdutos()
        {
            var products = await _productService.listarProdutos();
            return Ok(products);
        }
    }
}
