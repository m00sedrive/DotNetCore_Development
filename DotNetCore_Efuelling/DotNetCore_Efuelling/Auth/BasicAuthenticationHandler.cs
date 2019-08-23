using IdentityServer3.Core.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCore_Efuelling.Auth
{
    public class BasicAuthenticationHandler : AuthenticationHandler
    {
        private readonly IUserService _userService;

        public BasicAuthenticationHandler(
            IOptionsMonitor<AuthenticationSchemeOptions>options,
            ILoggerFactory logger,

            )
        {

        }

    }
}
