using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace CourseDomain.DTOs
{
    public  class CertificateDTO
    {
        [JsonPropertyOrder(2)]
        public int CertificateId { get; set; }

        [JsonPropertyOrder(3)]
        public string Title { get; set; }

        [JsonPropertyOrder(4)]
        public string Description { get; set; } = null!;




        [JsonPropertyOrder(5)]
        public string IssuedBy { get; set; } = null!;

        [JsonPropertyOrder(6)]
        public string CertificateUrl { get; set; } = null!;
    }
}
