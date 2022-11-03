using Microsoft.EntityFrameworkCore;
using SafejoApplicationForm.Domain.Model;


namespace SafejoApplicationForm.Repository
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }
        public DbSet<Applicant> Applicant { get; set; }
        public DbSet<ApplicantBioData> ApplicantBioData { get; set; }
        public DbSet<ApplicantEducation> ApplicantEducations { get; set; }
        public DbSet<ApplicantProfessions> ApplicantProfessions { get; set; }
        public DbSet<JobExperience> JobExperience { get; set; }
        public DbSet<PrimaryEducation> PrimaryEducations { get; set; }
        public DbSet<SecondaryEducation> SecondaryEducations { get; set; }
        public DbSet<TertiaryEducation> TertiaryEducations { get; set; }
    }
}
