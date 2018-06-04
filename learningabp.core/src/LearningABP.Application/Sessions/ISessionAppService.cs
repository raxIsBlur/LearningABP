using System.Threading.Tasks;
using Abp.Application.Services;
using LearningABP.Sessions.Dto;

namespace LearningABP.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
