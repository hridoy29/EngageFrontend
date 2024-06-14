namespace Magnus.Core.Models.CaseDetailsModels.NotesDetailsModels;

public class Note
{
    public int ID { get; init; }

    public string Message { get; init; } = string.Empty;

    public string User { get; init; } = string.Empty;

    public DateTime CreatedOn { get; init; }
}
