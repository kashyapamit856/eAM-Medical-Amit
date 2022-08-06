using eAM_Medical.Data.Repository.Interfaces;
using System;
using System.Threading.Tasks;

namespace eAM_Medical.Data.UnitOfWork.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository Users { get; }
        IClinicMasterRepository ClinicMaster { get; }
        Task CompleteAsync();
    }
}
