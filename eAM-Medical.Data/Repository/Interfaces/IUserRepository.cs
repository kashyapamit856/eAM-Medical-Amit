using eAM_Medical.Data.Models;
using System.Threading.Tasks;

namespace eAM_Medical.Data.Repository.Interfaces
{
    public interface IUserRepository : IGenericRepository<TblUser>
    {
        Task<TblUser> UserLogin(TblUser entity);
    }
}
