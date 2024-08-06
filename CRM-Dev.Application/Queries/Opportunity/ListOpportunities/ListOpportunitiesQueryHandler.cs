using CRM_Dev.Core.DTOs;
using CRM_Dev.Core.Repositories;
using MediatR;

namespace CRM_Dev.Application.Queries.Opportunity.ListOpportunities
{
    public class ListOpportunitiesQueryHandler : IRequestHandler<ListOpportunitiesQuery, List<OpportunityDto>>
    {

        #region Repository D.I

        private readonly IOpportunityRepository _opportunityRepository;

        public ListOpportunitiesQueryHandler(IOpportunityRepository opportunityRepository)
        {
            _opportunityRepository = opportunityRepository;
        }

        #endregion

        public async Task<List<OpportunityDto>> Handle(ListOpportunitiesQuery request, CancellationToken cancellationToken)
        {
            return await _opportunityRepository.ListOpportunitiesAsync();
        }
    }
}
