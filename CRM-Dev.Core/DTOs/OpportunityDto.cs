using CRM_Dev.Core.Enums;

namespace CRM_Dev.Core.DTOs
{
    public sealed record OpportunityDto(
        string Title,
        string Description,
        DateTime Deadline,
        decimal Budget,
        string Scope,
        bool SupportIncluded,
        OpportunityStatus Status,
        ReasonForLoss? LossReason,
        OpportunityStagesEnum Stage
    );
}
