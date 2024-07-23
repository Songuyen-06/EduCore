using System;
using System.Collections.Generic;

namespace CourseDomain;

public partial class Document
{
    public int DocumentId { get; set; }

    public int? SectionId { get; set; }

    public string Title { get; set; } = null!;

    public string? Url { get; set; }

    public DateTime? CreateDate { get; set; }

    public virtual Section? Section { get; set; }
}
