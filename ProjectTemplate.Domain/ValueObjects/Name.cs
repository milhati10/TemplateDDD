using Flunt.Validations;
using ProjectTemplate.Shared.ValueObjects;

namespace ProjectTemplate.Domain.ValueObjects
{
    public class Name : ValueObject
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

            AddNotifications(new Contract()
                 .Requires()
                 .HasMinLen(FirstName, 3, "Name.FirstName", "Nome deve conter pelo menos 3 caracteres")
                 .HasMinLen(LastName, 3, "Name.LastName", "Sobrenome deve conter pelo menos 3 caracteres")
                 .HasMaxLen(FirstName, 40, "Name.FirstName", "Nome deve conter até 40 caracteres")
                 .HasMinLen(LastName, 40, "Name.LastName", "Sobrenome deve conter até 40 caracteres")
             );
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
