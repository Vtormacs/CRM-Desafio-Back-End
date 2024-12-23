﻿using CRM_Desafio_Back_End.Dtos.Product;

namespace CRM_Desafio_Back_End.Services.Product
{
    public interface IProductInterface
    {
        Task<ProductViewDto> criarProduto(ProductCriacaoDto productCriacaoDto);
        Task<List<ProductViewDto>> listarProdutos();
    }
}
