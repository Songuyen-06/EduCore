using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseDomain.DTOs
{
    public  class UserDTO
    {
        [Key]
        public int UserId { get; set; }

        public string? FullName { get; set; }

        public string Email { get; set; } = null!;

        public string? Phone { get; set; }

        public string Password { get; set; } = null!;

        public string? Bio { get; set; }

        public string? UrlImage { get; set; }

        public int? RoleId { get; set; }
    }
}
