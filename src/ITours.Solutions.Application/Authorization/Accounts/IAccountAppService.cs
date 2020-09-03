using System.Threading.Tasks;
using Abp.Application.Services;
using ITours.Solutions.Authorization.Accounts.Dto;

namespace ITours.Solutions.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
