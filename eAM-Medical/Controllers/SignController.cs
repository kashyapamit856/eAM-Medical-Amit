using eAM_Medical.AuthenticationManager;
using eAM_Medical.BL.Interfaces;
using eAM_Medical.Data.Models;
using eAM_Medical.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace eAM_Medical.Controllers
{
    public class SignController : Controller
    {
        private readonly ILogger<SignController> _logger;
        private readonly IConfiguration _configuration;
        private readonly string _apiBaseUrl;
        private readonly IUserBL _iUserBL;
        private readonly IJWTAuthenticationManager _jWTAuthenticationManager;
        private readonly ITokenRefresher _tokenRefresher;
        public SignController(ILogger<SignController> logger, IConfiguration configuration, IUserBL iUserBL, IJWTAuthenticationManager jWTAuthenticationManager, ITokenRefresher tokenRefresher)
        {
            _logger = logger;
            _configuration = configuration;
            _apiBaseUrl = _configuration.GetValue<string>("WebAPIBaseUrl");
            _iUserBL = iUserBL;
            _jWTAuthenticationManager = jWTAuthenticationManager;
            _tokenRefresher = tokenRefresher;
        }
        public IActionResult In()
        {
            return View();
        }

        public async Task<IActionResult> SignIn([FromForm] Models.UserCred userCred)
        {
            TblUser user = new TblUser
            {
                UserName = userCred.Username,
                Password = userCred.Password,
            };

            TblUser user1 = await _iUserBL.UserLogin(user);
            AuthenticationManager.AuthenticationResponse token;

            if (user1 != null)
            {
                token = _jWTAuthenticationManager.Authenticate(userCred.Username, userCred.Password);
                token.Id = user1.Id;
                token.FirstName = user1.FirstName;
                token.MiddleName = user1.MiddleName;
                token.LastName = user1.LastName;
                token.UserName = user1.UserName;
                token.Email = user1.Email;
                token.IsActive = user1.IsActive;
                token.IsDeleted = user1.IsDeleted;
                token.CreatedOn = user1.CreatedOn;
                token.ModifiedOn = user1.ModifiedOn;
                token.LastLogin = user1.LastLogin;

                ClaimsIdentity identity = null;

                identity = new ClaimsIdentity(new[] {

                                new Claim(ClaimTypes.NameIdentifier,token.UserName),
                                new Claim(ClaimTypes.Email,token.Email),
                                new Claim(ClaimTypes.Name,token.FirstName),
                                new Claim(ClaimTypes.Role,"Admin")
                            }, CookieAuthenticationDefaults.AuthenticationScheme);

                var principal = new ClaimsPrincipal(identity);
                var login = HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

                return RedirectToAction("ClinicMaster", "Master");
            }
            else
            {
                ModelState.Clear();
                ModelState.AddModelError(string.Empty, "Username or Password is Incorrect");
                return View("In");
            }
        }
    }
}

