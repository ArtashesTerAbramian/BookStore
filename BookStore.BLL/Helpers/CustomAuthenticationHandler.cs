using System.Security.Claims;
using System.Text.Encodings.Web;
using BookStore.BLL.Services.AdminService;
using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace BookStore.BLL.Helpers;

public class CustomAuthenticationHandler : AuthenticationHandler<AuthenticationSchemeOptions>
{
    private readonly IAdminSessionService _adminSessionService;

    public CustomAuthenticationHandler(IOptionsMonitor<AuthenticationSchemeOptions> options,
        ILoggerFactory logger, 
        UrlEncoder encoder,
        ISystemClock clock,
        IAdminSessionService adminSessionService) 
                            : base(options, logger, encoder, clock)
    {
        _adminSessionService = adminSessionService;
    }

    protected override async Task<AuthenticateResult> HandleAuthenticateAsync()
    {
        string token = null;

        token = Request.Headers["Authorization"].ToString();

        if (string.IsNullOrEmpty(token))
        {
            return AuthenticateResult.Fail("Authorization not provided");
        }

        var admin = await _adminSessionService.GetByToken(token);

        if (admin == null)
        {
            return AuthenticateResult.Fail("User not fount");
        }

        var clains = new[]
        {
            new Claim(ClaimTypes.NameIdentifier, admin.UserName),
            new Claim(ClaimTypes.Name, admin.Id.ToString())
        };

        var Identity = new ClaimsIdentity(clains, Scheme.Name);
        var Principal = new ClaimsPrincipal(Identity);
        var ticket = new AuthenticationTicket(Principal, Scheme.Name);

        return AuthenticateResult.Success(ticket);
    }
}