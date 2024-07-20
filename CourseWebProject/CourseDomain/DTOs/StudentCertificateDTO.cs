using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CourseDomain.DTOs
{
    public  class StudentCertificateDTO:CertificateDTO
    {
        [JsonPropertyOrder(0)]
        public  int StudentId {  get; set; }

        [JsonPropertyOrder(1)]
        public string StudentName { get; set; }

        [JsonPropertyOrder(7)]
        public DateTime CompletionDate {  get; set; }

        [JsonPropertyOrder(8)]
        public DateTime CompletionTime {  get; set; }
    }
}
