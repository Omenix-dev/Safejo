using SafejoApplicationForm.Core.Interface;
using SafejoApplicationForm.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafejoApplicationForm.Repository.Respository
{
    public class TertiaryEducationRepository : GenericRepository<ApplicantBioData>, ITertiaryEducationRepository
    {
        public TertiaryEducationRepository(ApplicationDbContext context):base(context)
        {

        }
    }
}
