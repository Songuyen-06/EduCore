using System.ComponentModel.DataAnnotations;

namespace EduCore.BackEnd.Application.DTOs
{
    public  class CategoryDTO
    {
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public List<SubCategoryDTO>? SubCategories { get; set; }
    }
}
