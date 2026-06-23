namespace PocketLedger.Domain.Common
{
    public abstract class BaseEntity
    {
        public Guid Id { get; protected set; }
        public DateTime CreatedAtUtc { get; protected set; }
        public DateTime? UpdatedAtUtc { get; protected set; }

        protected BaseEntity()
        {
            Id = Guid.NewGuid();
            CreatedAtUtc = DateTime.UtcNow;
        }

        public void SetUpdatedAt()
        {
            UpdatedAtUtc = DateTime.UtcNow;
        }
    }
}
