using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafejoApplicationForm.Core.DTO
{
    public class ApplicantEducationDto
    { 
        public PrimaryEducationDto PrimaryEducationDto { get; set; }
        public PrimaryEducationDto SecondaryEducationDto { get; set; }
        public IEnumerable<TertiaryEducationDto> TertiaryEducationDto { get; set; }
    }
}
