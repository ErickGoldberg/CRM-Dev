using CRM_Dev.Core.DTOs;
using CRM_Dev.Core.Repositories;
using MediatR;

namespace CRM_Dev.Application.Queries.Contact.ListContacts
{
    public class ListContactsQueryHandler : IRequestHandler<ListContactsQuery, List<ContactDto>>
    {

        #region Repository D.I

        private readonly IContactRepository _contactRepository;

        public ListContactsQueryHandler(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }

        #endregion

        public async Task<List<ContactDto>> Handle(ListContactsQuery request, CancellationToken cancellationToken)
        {
            return await _contactRepository.ListOpportunitiesAsync();
        }
    }
}
