using CRM_Dev.Core.DTOs;
using MediatR;

namespace CRM_Dev.Application.Queries.Opportunity.ListOpportunities
{
    public class ListOpportunitiesQuery : IRequest<List<OpportunityDto>>
    {
        // Ignore
    }
}
