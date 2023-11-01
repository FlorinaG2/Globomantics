using System.Reflection.Metadata;
using System.Xml.Schema;

namespace Globomantic.Domain;

public partial record ToDoTask : ToDo
{
    public ToDoTask(Guid Id, string Title, DateTimeOffset CreateDate, User CreadetBy, bool IsCompleted = false, bool IsDeleted = false) 
        : base(Id, Title, CreateDate, CreadetBy, IsCompleted, IsDeleted)
    {
    }
}


