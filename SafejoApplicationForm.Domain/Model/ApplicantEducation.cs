using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SafejoApplicationForm.Domain.Model
{
    public class ApplicantEducation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        public string PrimaryEducationId { get; set; }
        public PrimaryEducation PrimaryEducation { get; set; }
        public string secondaryEducationId { get; set; }
        public SecondaryEducation SecondaryEducation { get; set; }
        public IEnumerable<TertiaryEducation> TertiaryEducation { get; set; }
    }
}
