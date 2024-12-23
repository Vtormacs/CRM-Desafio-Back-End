using AutoMapper;
using CRM_Desafio_Back_End.Dtos.Product;
using CRM_Desafio_Back_End.Model;

namespace CRM_Desafio_Back_End.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ProductCriacaoDto, ProductModel>();
            CreateMap<ProductModel, ProductViewDto>();
        }
    }
}
