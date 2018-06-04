using Abp.Application.Services;
using Abp.Application.Services.Dto;
using LearningABP.MultiTenancy.Dto;

namespace LearningABP.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
