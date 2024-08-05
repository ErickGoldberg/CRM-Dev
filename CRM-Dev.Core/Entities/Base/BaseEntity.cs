using CRM_Dev.Core.Enums;

namespace CRM_Dev.Core.Entities.Base
{
    public abstract class BaseEntity
    {
        protected BaseEntity()
        {
            Id = Guid.NewGuid();
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;

            EntityStatus = EntityStatusEnum.Actived;
        }

        public Guid Id { get; }
        public DateTime CreatedAt { get; }
        public DateTime UpdatedAt { get; protected set; }
        public EntityStatusEnum EntityStatus { get; protected set; }

        public virtual void Activate()
            => EntityStatus = EntityStatusEnum.Actived;

        public virtual void Deactivate()
            => EntityStatus = EntityStatusEnum.Deactivated;        
        
        public virtual void Delete()
            => EntityStatus = EntityStatusEnum.Deleted;

        public virtual void SetUpdatedAtDate(DateTime updatedAtDate)
            => UpdatedAt = updatedAtDate;
    }
}
