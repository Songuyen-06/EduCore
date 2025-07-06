using System.Text.Json.Serialization;

namespace EduCore.BackEnd.Application.DTOs
{
    public class CertificateDetailDTO:CertificateDTO
    {
        [JsonPropertyOrder(5)]
        public DateTime CompletionDate { get; set; }

        [JsonPropertyOrder(6)]
        public DateTime CompletionTime { get; set; }
    }
}
