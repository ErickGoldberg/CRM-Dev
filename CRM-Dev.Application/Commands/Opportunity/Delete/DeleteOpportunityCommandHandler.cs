using CRM_Dev.Infraestructure.Persistence.Repositories;
using MediatR;

namespace CRM_Dev.Application.Commands.Opportunity.DeleteOpportunity
{
    public class DeleteOpportunityCommandHandler : IRequestHandler<DeleteOpportunityCommand, bool>
    {

        #region UnitOfWork

        private readonly IUnitOfWork _unitOfWork;

        public DeleteOpportunityCommandHandler(IUnitOfWork unitOfWork)
            => _unitOfWork = unitOfWork;

        #endregion

        public Task<bool> Handle(DeleteOpportunityCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
