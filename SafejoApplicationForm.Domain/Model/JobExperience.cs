using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafejoApplicationForm.Domain.Model
{
    public class JobExperience
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        [Required]
        public string JobTitle { get; set; }
        [Required]
        public string BriefDescription { get; set; }
        public IEnumerable<Applicant> Applicants { get; set; }
    }
}
