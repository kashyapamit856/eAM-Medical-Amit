using eAM_Medical.Data.Models;
using eAM_Medical.Data.Repository;
using eAM_Medical.Data.Repository.Interfaces;
using eAM_Medical.Data.UnitOfWork.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace eAM_Medical.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly eAMMedicalContext _context;
        private readonly ILogger _logger;

        public IUserRepository Users { get; private set; }
        public IClinicMasterRepository ClinicMaster { get; private set; }

        public UnitOfWork(
            eAMMedicalContext context,
            ILoggerFactory loggerFactory
        )
        {
            _context = context;
            _logger = loggerFactory.CreateLogger("logs");

            Users = new UserRepository(_context, _logger);
            ClinicMaster = new ClinicMasterRepository(_context, _logger); ;
        }

        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
