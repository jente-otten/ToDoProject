using ToDoProject.Domain;

public record Bug(String Title,
    string Description,
    Severity Severity,
    string AffectedVersion,
    int AffectedUsers,
    User CreatedBy,
    User? AssignedTo,
    IEnumerable<byte[]> Images) : TodoTask(Title, DateOnly.FromDateTime(DateTime.Now), CreatedBy);
