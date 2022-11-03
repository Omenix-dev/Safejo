using SafejoApplicationForm.Core.Interface;
using SafejoApplicationForm.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafejoApplicationForm.Repository.Respository
{
    public class ApplicantEducationRepository : GenericRepository<ApplicantBioData>, IApplicantEducationRepository
    {
        public ApplicantEducationRepository(ApplicationDbContext context):base(context)
        {

        }
    }
}
