using System;
using System.Collections.Generic;

namespace CourseDomain;

public class Certificate
{
    public int CertificateId { get; set; }

    public string Title { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string IssuedBy { get; set; } = null!;

    public string CertificateUrl { get; set; } = null!;

    public int? CourseId { get; set; }

    public virtual Course? Course { get; set; } = null!;

    public virtual ICollection<StudentCertificate> StudentCertificates { get; set; } = new List<StudentCertificate>();
}
