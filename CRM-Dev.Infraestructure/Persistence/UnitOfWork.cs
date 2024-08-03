using CRM_Dev.Core.Repositories;
using CRM_Dev.Infraestructure.Persistence.Repositories;
using Microsoft.EntityFrameworkCore.Storage;

namespace CRM_Dev.Infraestructure.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private IDbContextTransaction _transaction;
        private readonly CRMDevDbContext _context;
        public UnitOfWork(CRMDevDbContext context,
                          IContactRepository contactRepository,
                          IOpportunityRepository opportunityRepository)
        {
            _context = context;
            ContactRepository = contactRepository;
            OpportunityRepository = opportunityRepository;
        }

        public IContactRepository ContactRepository { get; }
        public IOpportunityRepository OpportunityRepository { get; }

        public async Task BeginTransactionAsync()
            => _transaction = await _context.Database.BeginTransactionAsync();

        public async Task CommitAsync()
        {
            try
            {
                await _transaction.CommitAsync();
            }
            catch (Exception)
            {
                await _transaction.RollbackAsync();
                throw;
            }
        }

        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
                _context.Dispose();
        }
    }
}
