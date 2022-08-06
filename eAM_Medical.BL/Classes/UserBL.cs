using eAM_Medical.BL.Interfaces;
using eAM_Medical.Data.Models;
using eAM_Medical.Data.UnitOfWork.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eAM_Medical.BL.Classes
{
    public class UserBL : IUserBL
    {
        //private readonly ILogger _logger;
        private readonly ILogger<UserBL> _logger;

        private readonly IUnitOfWork _unitOfWork;
        public UserBL(ILogger<UserBL> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<TblUser>> All()
        {
            try
            {
                _logger.LogDebug("{Repo} All method error", typeof(UserBL));
                return await _unitOfWork.Users.All();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} All method error", typeof(UserBL));
                return null;
            }
        }

        public async Task<TblUser> UserLogin(TblUser user)
        {
            try
            {
                _logger.LogDebug("{Repo} All method error", typeof(UserBL));
                return await _unitOfWork.Users.UserLogin(user);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repo} All method error", typeof(UserBL));
                return null;
            }
        }
    }
}
