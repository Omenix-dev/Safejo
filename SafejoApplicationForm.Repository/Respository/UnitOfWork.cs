using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.DependencyInjection;
using SafejoApplicationForm.Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafejoApplicationForm.Repository.Respository
{
    public class UnitOfWork : IUnitOfWork , IDisposable
    {
        private readonly ApplicationDbContext _context;
        private bool _disposedValue;
        private IDbContextTransaction _objTransaction;
        private IApplicantProfessionsRepository _professionsRepository;
        private IApplicantRepository _applicantRepository;
        private IApplicantEducationRepository _educationRepository;
        private IApplicantBioDataRepository _bioDataRepository;
        private IJobExperienceRepository _jobExperienceRepository;
        private IPrimaryEducationRepository _primaryEducationRepository;
        private ISecondaryEducationRepository _secondaryEducationRepository;
        private ITertiaryEducationRepository _tertiaryEducationRepository;
        public UnitOfWork(IServiceProvider serviceProvider)
        {
            _context = serviceProvider.GetRequiredService<ApplicationDbContext>();
            _professionsRepository = serviceProvider.GetRequiredService<IApplicantProfessionsRepository>();

        }

        public IApplicantProfessionsRepository professionsRepository => _professionsRepository ??= new ApplicantProfessionsRepository(_context);
        public IApplicantRepository applicantRepository => _applicantRepository ??= new ApplicantRepository(_context);
        public IApplicantEducationRepository educationRepository => _educationRepository ??= new ApplicantEducationRepository(_context);
        public IApplicantBioDataRepository bioDataRepository => _bioDataRepository ??= new ApplicantBioDataRepository(_context);
        public IJobExperienceRepository jobExperienceRepository => _jobExperienceRepository ??= new JobExperienceRepository(_context);
        public IPrimaryEducationRepository primaryEducationRepository => _primaryEducationRepository ??= new PrimaryEducationRepository(_context);
        public ISecondaryEducationRepository secondaryEducationRepository => _secondaryEducationRepository ??= new SecondaryEducationRepository(_context);
        public ITertiaryEducationRepository tertiaryEducationRepository => _tertiaryEducationRepository ??= new TertiaryEducationRepository(_context);

        public async Task CreateTransaction()
        {
            _objTransaction = await _context.Database.BeginTransactionAsync();
        }

        public async Task Commit()
        {
            await _objTransaction.CommitAsync();
        }

        public async Task Rollback()
        {
            await _objTransaction?.RollbackAsync();
            await _objTransaction.DisposeAsync();
        }

        public virtual void Dispose(bool disposing)
        {
            if (!_disposedValue)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            _disposedValue = true;
        }

        public void Dispose()
        {
            Dispose(disposing :true);
            GC.SuppressFinalize(this);
        }
    }
}
