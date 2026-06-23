using PocketLedger.Domain.Common;
using PocketLedger.Domain.Enums;

namespace PocketLedger.Domain.Entities
{
    public class Category : BaseEntity
    {
        private Category()
        {
        }

        public Category(
            Guid userId,
            string name,
            CategoryType type)
        {
            UserId = userId;
            Name = name;
            Type = type;
        }

        public Guid UserId { get; private set; }

        public string Name { get; private set; }

        public CategoryType Type { get; private set; }

        public void Update(
            string name,
            CategoryType type)
        {
            Name = name;
            Type = type;

            SetUpdatedAt();
        }
    }
}
