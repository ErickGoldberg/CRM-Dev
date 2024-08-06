using System.Net;
using System.Reflection.Metadata;
using CRM_Dev.Core.ValueObjects;
using CRM_Dev.Core.Entities.Base;

namespace CRM_Dev.Core.Entities
{
    public class Contact : BaseEntity
    {
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Phone { get; private set; }
        public AreaOfExpertise ExpertiseArea { get; private set; }
        public string Position { get; private set; }
        public string CnpjCpf { get; private set; }
        public Address Address { get; private set; }
        public string Notes { get; private set; }

        public Contact(string name, string email, string phone, AreaOfExpertise expertiseArea, string position, string cnpjCpf, Address address, string notes)
        {
            Name = name;
            Email = email;
            Phone = phone;
            ExpertiseArea = expertiseArea;
            Position = position;
            CnpjCpf = cnpjCpf;
            Address = address;
            Notes = notes;
        }
    }
}
