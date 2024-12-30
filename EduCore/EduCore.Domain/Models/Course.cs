using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using EduCore.Domain.Models;

namespace EduCore.Domain;

public partial class Course
{
   
    public int CourseId { get; set; }

    public string Title { get; set; } = null!;

    public int? InstructorId { get; set; }

    public string? Description { get; set; }

    public string? Level { get; set; }

    public string? Duration { get; set; }

    public decimal? Price { get; set; }

    public decimal? Rating { get; set; }

    public int? SubCategoryId { get; set; }

    public string? Url { get; set; }

    public int Sale { get; set; }

    public virtual SubCategory? SubCategory { get; set; }



    public virtual ICollection<Checkout> Checkouts { get; set; } = new List<Checkout>();

    public virtual ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();

    public virtual User? Instructor { get; set; }

    public virtual ICollection<Review> Reviews { get; set; } = new List<Review>();

    public virtual ICollection<Section> Sections { get; set; } = new List<Section>();

    public virtual ICollection<StudentCourse> StudentCourses { get; set; } = new List<StudentCourse>();
}
