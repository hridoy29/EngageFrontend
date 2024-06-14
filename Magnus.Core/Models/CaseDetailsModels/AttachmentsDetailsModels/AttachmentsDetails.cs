using System.Collections.Generic;

namespace Magnus.Core.Models.CaseDetailsModels.AttachmentsDetailsModels;

public class AttachmentsDetails
{
    public List<Attachment> Attachments { get; init; } = new();
}
