using CRM_Dev.Application.Queries.Contact.ListContacts;
using CRM_Dev.Core.DTOs;
using CRM_Dev.Core.Repositories;
using MediatR;

namespace CRM_Dev.Application.Queries.Contact.GetContactsByTitle
{
    public class GetContactsByFilterHandler : IRequestHandler<GetContactsByFilterQuery>
    {

        #region Repository D.I

        private readonly IContactRepository _contactRepository;

        public GetContactsByFilterHandler(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }

        #endregion

        public Task IRequestHandler<GetContactsByFilterQuery>.Handle(GetContactsByFilterQuery request, CancellationToken cancellationToken)
        {
            var x = 

            return await _contactRepository.GetContactsByFiltersAsync(, cancellationToken);
        }
    }
}
