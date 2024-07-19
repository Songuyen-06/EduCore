using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;


namespace CourseDomain.DTOs
{
    public class UserDTO
    {
        [Key]
        [JsonPropertyOrder(1)]
        public int UserId { get; set; }

        [JsonPropertyOrder(2)]
        public string? FullName { get; set; }

        [JsonPropertyOrder(3)]
        public string Email { get; set; } = null!;

        [JsonPropertyOrder(4)]
        public string? Phone { get; set; }

        [JsonPropertyOrder(5)]
        public string Password { get; set; } = null!;

        [JsonPropertyOrder(6)]
        public string? Bio { get; set; }

        [JsonPropertyOrder(7)]
        public string? UrlImage { get; set; }

        [JsonPropertyOrder(8)]
        public int? RoleId { get; set; }
    }
}
