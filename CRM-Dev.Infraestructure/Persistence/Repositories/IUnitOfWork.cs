using CRM_Dev.Core.Repositories;

namespace CRM_Dev.Infraestructure.Persistence.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        IContactRepository ContactRepository { get; }
        IOpportunityRepository OpportunityRepository { get; }
        Task BeginTransactionAsync();
        Task CommitAsync();
        Task<int> CompleteAsync();
    }
}
