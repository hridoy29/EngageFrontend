using Magnus.Core.Models.CaseDetailsModels.AccountActionsModels;
using Magnus.Core.Models.CaseDetailsModels.AdjustmentDetailsModels;
using Magnus.Core.Models.CaseDetailsModels.AttachmentsDetailsModels;
using Magnus.Core.Models.CaseDetailsModels.AuditDetailsModels;
using Magnus.Core.Models.CaseDetailsModels.CustomerDetailsModels;
using Magnus.Core.Models.CaseDetailsModels.DisputeDetailsModels;
using Magnus.Core.Models.CaseDetailsModels.MeterDetailsModels;
using Magnus.Core.Models.CaseDetailsModels.NotesDetailsModels;
using Magnus.Core.Models.CaseDetailsModels.PaymentDetailsModels;
using Magnus.Core.Models.CaseDetailsModels.PropertyDetailsModels;
using Magnus.Core.Models.CaseDetailsModels.VisitDetailsModels;
using System.ComponentModel.DataAnnotations;

namespace Magnus.Core.Models.CaseDetailsModels;

public class CaseDetails
{
    [Required]
    public BaseCaseDetails BaseDetails { get; init; } = new();

    public MeterDetails? MeterDetails { get; init; } = null;

    public CustomerDetails? CustomerDetails { get; init; } = null;

    public PropertyDetails? PropertyDetails { get; init; } = null;

    public PaymentDetails? PaymentDetails { get; init; } = null;

    public VisitDetails? VisitDetails { get; init; } = null;

    public DisputeDetails? DisputeDetails { get; init; } = null;

    public AccountActions? AccountActions { get; init; } = null;

    public AttachmentsDetails? AttachmentsDetails { get; init; } = null;

    public AuditDetails? AuditDetails { get; init; } = null;

    public AdjustmentDetails? AdjustmentDetails { get; init; } = null;

    public NotesDetails? NotesDetails { get; init; } = null;
}
