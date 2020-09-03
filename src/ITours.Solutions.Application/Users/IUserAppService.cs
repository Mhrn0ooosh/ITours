using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ITours.Solutions.Roles.Dto;
using ITours.Solutions.Users.Dto;

namespace ITours.Solutions.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);

        Task<bool> ChangePassword(ChangePasswordDto input);
    }
}
