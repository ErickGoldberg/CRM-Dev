namespace CRM_Dev.Core.Entities
{
    public abstract class BaseEntity
    {
        protected BaseEntity()
        {
            Id = Guid.NewGuid();
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;

            IsDeleted = false;
        }


        public Guid Id { get; }
        public DateTime CreatedAt { get; }
        public DateTime UpdatedAt { get; protected set; }
        public bool IsDeleted { get; protected set; }


        public virtual void Activate() 
            => IsDeleted = false;

        public virtual void Deactivate()
            => IsDeleted = true;

        public virtual void SetUpdatedAtDate(DateTime updatedAtDate)
            => UpdatedAt = updatedAtDate;
    }
}
