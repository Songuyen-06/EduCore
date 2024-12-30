using EduCore.Domain.Models;
using System;
using System.Collections.Generic;

namespace EduCore.Domain;

public partial class Category
{
    public int CategoryId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<SubCategory>? SubCategories { get; set; } = new List<SubCategory>();
}
