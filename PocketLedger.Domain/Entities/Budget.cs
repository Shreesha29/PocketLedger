using PocketLedger.Domain.Common;

namespace PocketLedger.Domain.Entities
{
    public class Budget : BaseEntity
    {
        public Guid UserId { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public decimal BudgetAmount { get; set; }
    }
}
