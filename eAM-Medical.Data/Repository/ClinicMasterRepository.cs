using eAM_Medical.Data.Models;
using eAM_Medical.Data.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eAM_Medical.Data.Repository
{
    public class ClinicMasterRepository : GenericRepository<TblClinicMaster>, IClinicMasterRepository
    {
        public ClinicMasterRepository(
            eAMMedicalContext context,
              ILogger logger
        ) : base(context, logger)
        {

        }

        public override async Task<IEnumerable<TblClinicMaster>> All()
        {
            try
            {
                _logger.LogDebug("{Repo} All method error", typeof(ClinicMasterRepository));
                return await dbSet.ToListAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} All method error", typeof(ClinicMasterRepository));
                return new List<TblClinicMaster>();
            }
        }

        public override async Task<bool> Upsert(TblClinicMaster entity)
        {
            try
            {
                var existingClinicMaster = await dbSet.Where(x => x.Id == entity.Id)
                                                        .FirstOrDefaultAsync();

                if (existingClinicMaster == null)
                    return await Add(entity);

                //existingEmployee.FirstName = entity.FirstName;
                //existingEmployee.LastName = entity.LastName;
                //existingEmployee.Email = entity.Email;

                return true;
            }
            catch (Exception ex)
            {
                //_logger.LogError(ex, "{Repo} Upsert method error", typeof(EmployeeRepository));
                return false;
            }
        }



        public override async Task<bool> Delete(int id)
        {
            try
            {
                var exist = await dbSet.Where(x => x.Id == id)
                                    .FirstOrDefaultAsync();

                if (exist != null)
                {
                    dbSet.Remove(exist);
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                //_logger.LogError(ex, "{Repo} Delete method error", typeof(EmployeeRepository));
                return false;
            }
        }
    }
}
