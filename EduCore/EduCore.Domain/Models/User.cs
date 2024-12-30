using System;
using System.Collections.Generic;

namespace EduCore.Domain;

public partial class User
{
    public int UserId { get; set; }

    public string? FullName { get; set; }

    public string Email { get; set; } = null!;

    public string? Phone { get; set; }

    public string Password { get; set; } = null!;

    public string? Bio { get; set; }

    public string? UrlImage {  get; set; }

    public int? RoleId { get; set; }

    public virtual ICollection<Checkout> Checkouts { get; set; } = new List<Checkout>();

    public virtual ICollection<Course> Courses { get; set; } = new List<Course>();

    public virtual ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();

    public virtual ICollection<Review> Reviews { get; set; } = new List<Review>();

    public virtual Role? Role { get; set; }

    public virtual ICollection<StudentCourse> StudentCourses { get; set; } = new List<StudentCourse>();

    public virtual ICollection<SystemSetting> SystemSettings { get; set; } = new List<SystemSetting>();


    public virtual ICollection<StudentCertificate> StudentCertificates { get; set; } = new List<StudentCertificate>();

}
