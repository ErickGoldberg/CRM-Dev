using CRM_Dev.Infraestructure.Persistence.Repositories;
using MediatR;

namespace CRM_Dev.Application.Commands.Contact.Delete
{
    public class DeleteContactCommandHandler : IRequestHandler<DeleteContactCommand, bool>
    {

        #region UnitOfWork

        private readonly IUnitOfWork _unitOfWork;

        public DeleteContactCommandHandler(IUnitOfWork unitOfWork)
            => _unitOfWork = unitOfWork;

        #endregion

        public Task<bool> Handle(DeleteContactCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
