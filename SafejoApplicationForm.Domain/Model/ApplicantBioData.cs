using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SafejoApplicationForm.Domain.Model
{
    public class ApplicantBioData
    {
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string StateOfOrigin { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        [Required]
        public string MaritalStatus { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Emai { get; set; }
        [Required]
        public int PostNYSC { get; set; }
        public Applicant Applicant { get; set; }
    }
}
