using AutoMapper;
using WpfOJT.Entities.Data;
using WpfOJT.Entities.DTO;

namespace WpfOJT.Services.Helpers
{
    /// <summary>
    /// Define the <see cref="AutoMapperProfiles"/>
    /// </summary>
    public class AutoMapperProfiles: Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<User, UserViewModel>().ReverseMap();
            CreateMap<Post, PostViewModel>().ReverseMap();
        }
    }
}
