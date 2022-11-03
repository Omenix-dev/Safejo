﻿using SafejoApplicationForm.Core.Interface;
using SafejoApplicationForm.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafejoApplicationForm.Repository.Respository
{
    public class PrimaryEducationRepository : GenericRepository<ApplicantBioData>, IPrimaryEducationRepository
    {
        public PrimaryEducationRepository(ApplicationDbContext context):base(context)
        {
                
        }
    }
}
