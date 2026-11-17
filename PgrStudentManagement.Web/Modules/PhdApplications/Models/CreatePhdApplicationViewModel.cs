using System;

namespace PgrStudentManagement.Web.Modules.PhdApplications.Models;

public class CreatePhdApplicationViewModel
{
    public string FirstName { get; set; } = string.Empty;

    public string LastName { get; set; } = string.Empty;

    public string EmailAddress { get; set; } = string.Empty;

    public string ProgrammeCode { get; set; } = string.Empty;

    public string ModeOfStudy { get; set; } = string.Empty;

    public DateTime ProposedStartDate { get; set; } =
        new DateTime(DateTime.UtcNow.Year + 1, 10, 1);

    public string ProposedThesisTitle { get; set; } = string.Empty;

    public string? ResearchSummary { get; set; }

    // Nullable so we can detect when the user hasn't picked a radio option yet
    public FundingType? FundingSource { get; set; }

    public string? ProposedSupervisorStaffNumber { get; set; }
}