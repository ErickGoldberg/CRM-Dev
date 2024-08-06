using CRM_Dev.Infraestructure.Persistence.Repositories;
using MediatR;

namespace CRM_Dev.Application.Commands.Contact.Update
{
    public class UpdateContactCommandHandler : IRequestHandler<UpdateContactCommand, bool>
    {

        #region UnitOfWork

        private readonly IUnitOfWork _unitOfWork;

        public UpdateContactCommandHandler(IUnitOfWork unitOfWork)
            => _unitOfWork = unitOfWork;

        #endregion

        public Task<bool> Handle(UpdateContactCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
