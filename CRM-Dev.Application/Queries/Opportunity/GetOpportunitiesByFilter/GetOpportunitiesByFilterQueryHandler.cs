using CRM_Dev.Application.Queries.Contact.GetContactsByTitle;
using CRM_Dev.Core.DTOs;
using CRM_Dev.Core.Repositories;
using CRM_Dev.Core.ValueObjects;
using MediatR;

namespace CRM_Dev.Application.Queries.Opportunity.GetOpportunitiesByTitle
{
    public class GetOpportunitiesByFilterQueryHandler : IRequestHandler<GetOpportunitiesByFilterQuery>
    {

        #region Repository D.I

        private readonly IOpportunityRepository _opportunityRepository;

        public GetOpportunitiesByFilterQueryHandler(IOpportunityRepository opportunityRepository)
        {
            _opportunityRepository = opportunityRepository;
        }

        #endregion

        public Task Handle(GetOpportunitiesByFilterQuery request, CancellationToken cancellationToken)
        {
            var opportunityDto = new OpportunityDto(
                Title: request.Title ?? string.Empty, 
                Description: string.Empty, 
                Deadline: request.Deadline,
                Budget: 0m, 
                Scope: request.Scope ?? string.Empty,
                SupportIncluded: request.SupportIncluded,
                Status: request.Status,
                LossReason: request.LossReason,
                Stage: request.Stage
            );

            var opportunities = _opportunityRepository.GetOpportunitiesByFiltersAsync(opportunityDto);

            return opportunities;
        }
    }
}
