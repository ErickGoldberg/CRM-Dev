using CRM_Dev.Infraestructure.Persistence.Repositories;
using MediatR;

namespace CRM_Dev.Application.Commands.Opportunity.UpdateOpportunity
{
    public class UpdateOpportunityCommandHandler : IRequestHandler<UpdateOpportunityCommand, bool>
    {

        #region UnitOfWork

        private readonly IUnitOfWork _unitOfWork;

        public UpdateOpportunityCommandHandler(IUnitOfWork unitOfWork)
            => _unitOfWork = unitOfWork;

        #endregion

        public Task<bool> Handle(UpdateOpportunityCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
