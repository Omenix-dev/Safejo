using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SafejoApplicationForm.Domain.Model
{
    public class Applicant
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        [Required]
        public string Department { get; set; }
        [Required]
        public string JobRole { get; set; }
        [Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreatedAt { get; set; }
        public string ApplicantBioDataId { get; set; }
        public ApplicantBioData ApplicationBioData { get; set; }
        public string ApplicantEducationId { get; set; }
        public ApplicantEducation ApplicantEdacation { get; set; }
        public IEnumerable<ApplicantProfessions> ApplicantProfessions { get; set; }
        public IEnumerable<JobExperience> JobExperience { get; set; }
    }
}
