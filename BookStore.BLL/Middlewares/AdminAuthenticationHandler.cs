using System.Text.Encodings.Web;
using BookStore.BLL.Services.AdminService;
using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace BookStore.BLL.Middlewares;

public class AdminAuthenticationHandler : AuthenticationHandler<AuthenticationSchemeOptions>
{
    public AdminAuthenticationHandler(OptionsMonitor<AuthenticationSchemeOptions> options,
        ILoggerFactory logger, 
        UrlEncoder encoder,
        ISystemClock clock,
        IAdminSessionService adminSessionService) 
                            : base(options, logger, encoder, clock)
    {
    }

    protected override Task<AuthenticateResult> HandleAuthenticateAsync()
    {
        return null;
    }
}