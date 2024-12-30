using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace EduCore.Domain.DTOs
{
    public class CertificateDetailDTO:CertificateDTO
    {
        [JsonPropertyOrder(5)]
        public DateTime CompletionDate { get; set; }

        [JsonPropertyOrder(6)]
        public DateTime CompletionTime { get; set; }
    }
}
