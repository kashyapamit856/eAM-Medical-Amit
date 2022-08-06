using System.Collections.Generic;
using System.Security.Claims;

namespace eAM_Medical.AuthenticationManager
{
    public interface IJWTAuthenticationManager
    {
        AuthenticationResponse Authenticate(string username, string password);
        IDictionary<string, string> UsersRefreshTokens { get; set; }
        AuthenticationResponse Authenticate(string username, Claim[] claims);
    }
}
