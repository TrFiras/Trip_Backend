using AutoMapper;
using Trip.Api.ViewModels;
using Trip.Services.DTO;
namespace Trip.Api.MappingProfiles
{
    public class ClientProfile : Profile
    {
         public ClientProfile()
        {
            CreateMap<ClientViewModel, ClientDTO>();
            CreateMap<ClientDTO, ClientViewModel>();
        }
    }
}