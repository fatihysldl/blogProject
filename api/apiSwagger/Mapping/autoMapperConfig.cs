using AutoMapper;
using DtoLayer.Dtos.authorDto;
using DtoLayer.Dtos.postDto;
using entityLayer.concrete;

namespace apiSwagger.Mapping
{
    public class autoMapperConfig : Profile
    {
        public autoMapperConfig()
        {
            CreateMap<addAuthorDto, authorTable>().ReverseMap();
            CreateMap<updateAuthorDto, authorTable>().ReverseMap();

            CreateMap<addPostDto, postTable>().ReverseMap();
            CreateMap<updatePostDto, postTable>().ReverseMap();
        }
    }
}
