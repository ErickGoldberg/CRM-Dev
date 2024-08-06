using CRM_Dev.Core.Enums;
using MediatR;

namespace CRM_Dev.Application.Commands.Opportunity.RegisterOpportunity
{
    public class RegisterOpportunityCommand : IRequest<bool>
    {
        public string Title { get; private set; }
        public string Description { get; private set; }
        public DateTime Deadline { get; private set; }
        public decimal Budget { get; private set; }
        public string Scope { get; private set; }
        public bool SupportIncluded { get; private set; }
        public OpportunityStatus Status { get; private set; }
        public ReasonForLoss? LossReason { get; private set; }
        public OpportunityStagesEnum Stage { get; private set; }
    }
}
