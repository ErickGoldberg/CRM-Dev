using MediatR;

namespace CRM_Dev.Application.Commands.Opportunity.DeleteOpportunity
{
    public class DeleteOpportunityCommand : IRequest<bool>
    {
        public DeleteOpportunityCommand(int id) => Id = id;

        public int Id { get; private set; }
    }
}
