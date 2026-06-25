using PocketLedger.Domain.Common;

namespace PocketLedger.Domain.Entities
{
    public class Transaction : BaseEntity
    {
        private Transaction()
        {

        }

        public Transaction(Guid userId, Guid categoryId, decimal amount, string? description, DateTime transactionDate)
        {
            UserId = userId;
            CategoryId = categoryId;
            Amount = amount;
            Description = description;
            TransactionDate = transactionDate;
        }

        public Guid UserId { get; private set; }
        public Guid CategoryId { get; private set; }

        public decimal Amount { get; private set; }

        public string? Description { get; private set; }

        public DateTime TransactionDate { get; private set; }

        public void Update(
            Guid categoryId,
            decimal amount,
            string? description,
            DateTime transactionDate)
        {
            CategoryId = categoryId;
            Amount = amount;
            Description = description;
            TransactionDate = transactionDate;

            SetUpdatedAt();
        }
    }
}
