using CRM_Dev.Infraestructure.Persistence.Repositories;
using MediatR;

namespace CRM_Dev.Application.Commands.Opportunity.RegisterOpportunity
{
    public class RegisterOpportunityCommandHandler : IRequestHandler<RegisterOpportunityCommand>
    {

        #region UnitOfWork

        private readonly IUnitOfWork _unitOfWork;

        public RegisterOpportunityCommandHandler(IUnitOfWork unitOfWork)
            => _unitOfWork = unitOfWork;

        #endregion

        public Task Handle(RegisterOpportunityCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
