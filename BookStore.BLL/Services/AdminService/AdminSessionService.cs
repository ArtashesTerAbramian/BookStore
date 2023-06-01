using AutoMapper;
using BookStore.BLL.Constants;
using BookStore.BLL.Helpers;
using BookStore.BLL.Models;
using BookStore.DAL;
using BookStore.DAL.Models;
using BookStore.DTO;
using BookStore.DTO.AdminDtos;
using CryptoHelper;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.Net.Http.Headers;

namespace BookStore.BLL.Services.AdminService;

public class AdminSessionService : IAdminSessionService
{
    private readonly AppDbContext _db;
    private readonly AuthOptions _options;
    private readonly ErrorHelper _errorHelper;
    private readonly IMapper _mapper;
    private readonly IHttpContextAccessor _httpContext;
    public Admin CurrentAdmin { get; private set; }

    public AdminSessionService(AppDbContext db,
        IOptions<AuthOptions> options,
        ErrorHelper errorHelper,
        IMapper mapper,
        IHttpContextAccessor httpContext)
    {
        _db = db;
        _options = options.Value;
        _errorHelper = errorHelper;
        _mapper = mapper;
        _httpContext = httpContext;
    }
    public async Task<Admin> GetByToken(string token)
    {
        var adminSession = await _db.AdminSessions
            .Include(x => x.Admin)
            .FirstOrDefaultAsync(x => x.Token == token && !x.IsExpired 
                                                       && x.Admin.IsDeleted != true);

        if (adminSession is null)
        {
            return null;
        }

        if (adminSession.ModifyDate.Value.AddMinutes(_options.TokenExpirationTimeInMinutes) < DateTime.Now)
        {
            adminSession.IsExpired = true;

            await _db.SaveChangesAsync();

            return null;
        }

        CurrentAdmin = adminSession.Admin;

        adminSession.ModifyDate = DateTime.Now;

        await _db.SaveChangesAsync();

        return CurrentAdmin;
    }

    public async Task<ResponseDto<AdminSessionDto>> Add(LoginDto dto)
    {
        var response = new ResponseDto<AdminSessionDto>();

        var dbAdmin = await _db.Admins
            .FirstOrDefaultAsync(x => x.UserName == dto.UserName.ToLower().Replace(" ", ""));

        if (dbAdmin is null || !Crypto.VerifyHashedPassword(dbAdmin.PasswordHash, dto.Password))
        {
            return await _errorHelper.SetError(response, ErrorConstants.IncorrectEnteredData);
        }
        
        var token = Guid.NewGuid().ToString("N") + Guid.NewGuid().ToString("N");

        var session = new AdminSession()
        {
            Token = token,
            AdminId = dbAdmin.Id
        };

        _db.AdminSessions.Add(session);

        await _db.SaveChangesAsync();

        response.Data = _mapper.Map<AdminSessionDto>(await _db.AdminSessions
            .Include(x => x.Admin)
            .FirstOrDefaultAsync(x => x.Id == session.Id));

        return response;
    }

    public ResponseDto<AdminDto> GetUserCurrentInfo() => new ResponseDto<AdminDto>()
    {
        Data = _mapper.Map<AdminDto>(CurrentAdmin)
    };

    public async Task<ResponseDto<bool>> Delete()
    {
        var response = new ResponseDto<bool>();

        _httpContext.HttpContext.Request.Headers.TryGetValue(HeaderNames.Authorization, out var token);

        var session = await _db.AdminSessions.FirstOrDefaultAsync(x => x.Token == token);

        if (session != null)
        {
            session.IsExpired = true;
            session.IsDeleted = true;
        }

        response.Data = true;
        
        return response;
    }
}