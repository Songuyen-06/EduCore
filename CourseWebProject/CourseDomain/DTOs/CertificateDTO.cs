using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;

namespace CourseDomain.DTOs
{
    public  class CertificateDTO
    {
        [Key]
        [JsonPropertyOrder(0)]
        public int CertificateId { get; set; }

        [JsonPropertyOrder(1)]
        public string Title { get; set; }

        [JsonPropertyOrder(2)]
        public string Description { get; set; } = null!;




        [JsonPropertyOrder(3)]
        public string IssuedBy { get; set; } = null!;

        [JsonPropertyOrder(4)]
        public string CertificateUrl { get; set; } = null!;
    }
}
