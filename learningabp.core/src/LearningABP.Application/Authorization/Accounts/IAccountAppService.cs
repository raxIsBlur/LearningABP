using System.Threading.Tasks;
using Abp.Application.Services;
using LearningABP.Authorization.Accounts.Dto;

namespace LearningABP.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
