using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafejoApplicationForm.Domain.Model
{
    public class SecondaryEducation : BaseEntity
    {
        [Required]
        public string CertificateTitle { get; set; }
        public IEnumerable<ApplicantEducation> Education { get; set; }
    }
}
