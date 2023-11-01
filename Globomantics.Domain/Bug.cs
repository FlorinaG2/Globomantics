namespace Globomantic.Domain;

public partial record ToDoTask : ToDo
{
    public record Bug(string Title, 
                      string Description,
                      Severity Severity, 
                      string AffectedVersion, 
                      int AffectedUser, 
                      User CreatedBy,
                      User? AssignedTo,
                      IEnumerable<byte[]> Images);
}


