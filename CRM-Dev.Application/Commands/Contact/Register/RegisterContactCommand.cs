using CRM_Dev.Core.ValueObjects;
using MediatR;

namespace CRM_Dev.Application.Commands.Contact.Register
{
    public class RegisterContactCommand : IRequest<bool>
    {
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Phone { get; private set; }
        public AreaOfExpertise ExpertiseArea { get; private set; }
        public string Position { get; private set; }
        public string CnpjCpf { get; private set; }
        public Address Address { get; private set; }
        public string Notes { get; private set; }
    }
}
