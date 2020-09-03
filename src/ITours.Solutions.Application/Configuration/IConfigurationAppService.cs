using System.Threading.Tasks;
using ITours.Solutions.Configuration.Dto;

namespace ITours.Solutions.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
