using CRM_Dev.Core.DTOs;
using CRM_Dev.Core.Entities;
using CRM_Dev.Core.ValueObjects;

namespace CRM_Dev.Core.Repositories
{
    public interface IContactRepository
    {
        Task RegisterContactAsync(Contact Contact);
        Task UpdateContactAsync(Contact Contact);
        Task DeleteContactAsync(Contact Contact);
        Task<List<ContactDto>> ListOpportunitiesAsync();
        Task<List<ContactDto>> GetContactsByFiltersAsync(string name = "", string email = "", string phone = "",
            string position = "", string cnpjCpf = "", AreaOfExpertise? expertiseArea = null);
    }
}
