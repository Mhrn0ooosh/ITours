using System.Threading.Tasks;
using Abp.Application.Services;
using ITours.Solutions.Sessions.Dto;

namespace ITours.Solutions.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
