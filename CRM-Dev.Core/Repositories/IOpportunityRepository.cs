using CRM_Dev.Core.DTOs;
using CRM_Dev.Core.Entities;

namespace CRM_Dev.Core.Repositories
{
    public interface IOpportunityRepository
    {
        Task RegisterOpportunityAsync(Opportunity opportunity);
        Task UpdateOpportunityAsync(Opportunity opportunity);
        Task DeleteOpportunityAsync(Opportunity opportunity);
        Task<List<OpportunityDto>> ListOpportunitiesAsync();

        // TODO: Change parameter to a specific Dto
        Task<List<OpportunityDto>> GetOpportunitiesByFiltersAsync(OpportunityDto opportunityDto);
    }
}
