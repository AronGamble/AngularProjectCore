using System.Threading.Tasks;
using AngularCoreProject.Configuration.Dto;

namespace AngularCoreProject.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
