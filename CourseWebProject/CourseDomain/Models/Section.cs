using System;
using System.Collections.Generic;

namespace CourseDomain;

public partial class Section
{
    public int SectionId { get; set; }

    public int? CourseId { get; set; }

    public string Title { get; set; } = null!;

    public TimeSpan? Duration { get; set; }

    public int? Position { get; set; }

    public virtual Course? Course { get; set; }

    public virtual ICollection<Document> Documents { get; set; } = new List<Document>();

    public virtual ICollection<Lecture> Lectures { get; set; } = new List<Lecture>();
}
