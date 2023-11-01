namespace Globomantic.Domain;

public partial record ToDoTask : ToDo
{
    public record Feature(string Title,
                          string Description,
                          string Component,
                          int Priority,
                          User CreatedBy,
                          User AssignedTo);
}


