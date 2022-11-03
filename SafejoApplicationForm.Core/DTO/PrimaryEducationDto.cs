using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafejoApplicationForm.Core.DTO
{
    public class PrimaryEducationDto
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string NameOfInstitute { get; set; }
        public string CertificateTitle { get; set; }
    }
}
