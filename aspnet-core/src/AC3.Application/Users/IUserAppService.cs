using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using AC3.Roles.Dto;
using AC3.Users.Dto;

namespace AC3.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);

        Task<bool> ChangePassword(ChangePasswordDto input);
    }
}
