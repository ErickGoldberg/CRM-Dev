using CRM_Dev.Core.ValueObjects;
using MediatR;

namespace CRM_Dev.Application.Commands.Contact.Update
{
    public class UpdateContactCommand : IRequest<bool>
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public AreaOfExpertise ExpertiseArea { get; set; }
        public string Position { get; set; }
        public string CnpjCpf { get; set; }
        public Address Address { get; set; }
        public string Notes { get; set; }
    }
}
