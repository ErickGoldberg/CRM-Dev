using CRM_Dev.Core.DTOs;
using CRM_Dev.Core.Enums;
using MediatR;

namespace CRM_Dev.Application.Queries.Opportunity.GetOpportunitiesByTitle
{
    public class GetOpportunitiesByFilterQuery : IRequest<List<ContactDto>>
    {
        public string Title { get; set; }
        public DateTime Deadline { get; set; }
        public string Scope { get; set; }
        public bool SupportIncluded { get; set; }
        public OpportunityStatus Status { get; set; }
        public ReasonForLoss? LossReason { get; set; }
        public OpportunityStagesEnum Stage { get; set; }
    }
}
