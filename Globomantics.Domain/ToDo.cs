using System.Reflection.Metadata;

namespace Globomantic.Domain;

/* Records are great for data transmission objects and domain models. They will not work with EF Core*/
public abstract record ToDo(Guid Id,
                            string Title,
                            DateTimeOffset CreateDate,
                            User CreadetBy,
                            bool IsCompleted = false,
                            bool IsDeleted = false)

{
    public ToDo? Parent {get; init;}
}
