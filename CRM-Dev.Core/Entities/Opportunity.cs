using CRM_Dev.Core.Enums;

namespace CRM_Dev.Core.Entities
{
    public class Opportunity
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
        public int ContactId { get; private set; }

        public Opportunity(string title, string description, DateTime deadline, decimal budget, string scope, bool supportIncluded, OpportunityStatus status, ReasonForLoss? lossReason, OpportunityStagesEnum stage, int contactId)
        {
            Title = title;
            Description = description;
            Deadline = deadline;
            Budget = budget;
            Scope = scope;
            SupportIncluded = supportIncluded;
            Status = status;
            LossReason = lossReason;
            Stage = status == OpportunityStatus.Open ? stage : OpportunityStagesEnum.Closed;
            ContactId = contactId;
        }
    }
}
