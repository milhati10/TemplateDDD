using ProjectTemplate.Domain.ValueObjects;

namespace ProjectTemplate.Domain.Entities
{
    public class Customer : Entity
    {
        public Name Name { get; private set; }
    }
}
