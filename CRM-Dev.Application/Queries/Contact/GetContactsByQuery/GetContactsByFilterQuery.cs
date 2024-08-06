using CRM_Dev.Core.ValueObjects;
using MediatR;

namespace CRM_Dev.Application.Queries.Contact.GetContactsByTitle
{
    public class GetContactsByFilterQuery : IRequest
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public AreaOfExpertise ExpertiseArea { get; set; }
        public string Position { get; set; }
        public string CnpjCpf { get; set; }
    }
}
