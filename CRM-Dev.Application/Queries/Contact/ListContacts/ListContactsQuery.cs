using CRM_Dev.Core.DTOs;
using MediatR;

namespace CRM_Dev.Application.Queries.Contact.ListContacts
{
    public class ListContactsQuery : IRequest<List<ContactDto>>
    {
        // Ignore
    }
}
