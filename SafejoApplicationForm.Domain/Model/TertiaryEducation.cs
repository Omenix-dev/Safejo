using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafejoApplicationForm.Domain.Model
{
    public class TertiaryEducation : BaseEntity
    {
        [Required]
        public string QualificationAward { get; set; }
        [Required]
        public string ClassOfCertification { get; set; }
        [Required]
        public string CourseOfStudy { get; set; }
        public IEnumerable<ApplicantEducation> Educations { get; set; }
    }
}
