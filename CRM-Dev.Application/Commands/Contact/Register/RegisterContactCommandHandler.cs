using CRM_Dev.Infraestructure.Persistence.Repositories;
using MediatR;

namespace CRM_Dev.Application.Commands.Contact.Register
{
    public class RegisterContactCommandHandler : IRequestHandler<RegisterContactCommand>
    {

        #region UnitOfWork

        private readonly IUnitOfWork _unitOfWork;

        public RegisterContactCommandHandler(IUnitOfWork unitOfWork)
            => _unitOfWork = unitOfWork;

        #endregion

        public Task Handle(RegisterContactCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
