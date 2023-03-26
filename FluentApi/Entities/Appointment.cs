using System;
using System.Collections.Generic;

namespace FluentApi.Entities;

public partial class Appointment
{
    public int Id { get; set; }

    public string? Reason { get; set; }

    public string? Date { get; set; }

    public int? Acceptance { get; set; }

    public int? PatientId { get; set; }

    public string? PhysicianEmail { get; set; }

    public string? SubmissionDate { get; set; }
}
