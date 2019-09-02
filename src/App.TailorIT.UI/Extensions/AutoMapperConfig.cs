using App.TailorIT.Application.ViewModels;
using App.TailorIT.Domain.Entites;
using AutoMapper;

namespace App.TailorIT.UI.Extensions
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Usuario, UsuarioViewModel>().ReverseMap();
            CreateMap<Sexo, SexoViewModel>().ReverseMap();
        }
    }
}
