using eAM_Medical.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eAM_Medical.BL.Interfaces
{
    public interface IUserBL
    {
        Task<IEnumerable<TblUser>> All();
        Task<TblUser> UserLogin(TblUser user);
    }
}
