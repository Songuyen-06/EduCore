using System;
using System.Collections.Generic;

namespace EduCore.BackEnd.Domain.Entities
{
    public partial class Category
    {
        public Category()
        {
            SubCategories = new HashSet<SubCategory>();
        }

        public int CategoryId { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<SubCategory> SubCategories { get; set; }
    }
}
