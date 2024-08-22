using ToDoProject.Domain;

public record Feature(String Title,
    string Description,
    string Component,
    int Priority,
    User CreatedBy,
    User AssignedTo) : TodoTask(Title, DateOnly.FromDateTime(DateTime.Now), CreatedBy);
