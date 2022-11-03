using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SafejoApplicationForm.Domain.Model
{
    public class ApplicantProfessions
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        [Required]
        public string QualificationAward { get; set; }
        [Required]
        public string ProfessionalBody { get; set; }
        public IEnumerable<Applicant> Applicant { get; set; }
    }
}
