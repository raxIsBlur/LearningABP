using System.Threading.Tasks;
using LearningABP.Configuration.Dto;

namespace LearningABP.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
