namespace Globomantic.Domain;

public partial record ToDoTask : ToDo
{
    public enum Severity
    {
        Critical,
        Major,
        Minor,
        Annoying
    }
}


