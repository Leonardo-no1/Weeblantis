using AutoMapper;
using Weeblantis.Core.Dtos;
using Weeblantis.Core.Models.User;

namespace Weeblantis.Core.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserDto, UserModel>()
                .ForMember(dest =>
                            dest.HashedPassword,
                            opt => opt.Ignore())
                .ForMember(dest =>
                            dest.Salt,
                            opt => opt.Ignore())
                .ReverseMap();
        }
    }
}
