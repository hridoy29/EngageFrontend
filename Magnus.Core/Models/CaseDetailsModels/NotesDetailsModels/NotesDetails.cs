using System.Collections.Generic;

namespace Magnus.Core.Models.CaseDetailsModels.NotesDetailsModels;

public class NotesDetails
{
    public List<Note> Notes { get; init; } = new();
}
