using System.Threading.Tasks;
using AC3.Configuration.Dto;

namespace AC3.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
