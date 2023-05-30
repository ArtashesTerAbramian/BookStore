using System.Security.Cryptography;
using AutoMapper;
using BookStore.BLL.Constants;
using BookStore.BLL.Filters.AdminFilters;
using BookStore.BLL.Helpers;
using BookStore.DAL;
using BookStore.DAL.Models;
using BookStore.DTO;
using BookStore.DTO.AdminDtos;
using CryptoHelper;
using Microsoft.EntityFrameworkCore;

namespace BookStore.BLL.Services.AdminService;

public class AdminService : IAdminService
{
    private readonly AppDbContext _db;
    private readonly IMapper _mapper;
    private readonly ErrorHelper _errorHelper;
    private readonly IAdminSessionService _adminSessionService;

    public AdminService(AppDbContext db, 
        IMapper mapper,
        ErrorHelper errorHelper,
        IAdminSessionService adminSessionService)
    {
        _db = db;
        _mapper = mapper;
        _errorHelper = errorHelper;
        _adminSessionService = adminSessionService;
    }
    public async Task<ResponseDto<AdminDto>> GetById(int id)
    {
        var response = new ResponseDto<AdminDto>();
        var admin = await _db.Admins.FirstOrDefaultAsync(x => x.Id == id);

        if (admin == null)
        {
            return await _errorHelper.SetError(response, ErrorConstants.ItemNotFound);
        }

        response.Data = _mapper.Map<AdminDto>(admin);
        
        return response;
    }

    public async Task<ResponseDto<PagedModelDto<AdminDto>>> GetAll(AdminFilter filter)
    {
        var response = new ResponseDto<PagedModelDto<AdminDto>>();

        var query = _db.Admins.AsQueryable();

        var admins = _mapper.Map<List<AdminDto>>(await filter.FilterObjects(query).ToListAsync());

        response.Data = new PagedModelDto<AdminDto>()
        {
            Entities = admins,
            Count = await filter.CountAsync(query)
        };
        return response;
    }

    public async Task<ResponseDto<AdminDto>> Add(AddAdminDto dto)
    {
        var response = new ResponseDto<AdminDto>();

        if (response.HasError)
            return response;

        if (await _db.Admins.AnyAsync(x => x.UserName == dto.UserName.ToLower().Replace(" ", "")))
            return await _errorHelper.SetError(response, ErrorConstants.UserNameAlreadyTaken);

        if (await _db.Admins.AnyAsync(x => x.Email == dto.Email.ToLower().Replace(" ", "")))
            return await _errorHelper.SetError(response, ErrorConstants.EmailInUse);

        var newAdmin = new Admin()
        {
            Name = dto.Name,
            UserName = dto.UserName,
            Email = dto.Email,
            PasswordHash = Crypto.HashPassword(dto.Password)
        };

        _db.Admins.Add(newAdmin);

        await _db.SaveChangesAsync();

        response.Data = _mapper.Map<AdminDto>(newAdmin);

        return response;
    }

    public Task<ResponseDto<AdminDto>> Update(UpdateAdminDto dto)
    {
        throw new NotImplementedException();
    }

    public async Task<ResponseDto<bool>> Delete(DeleteAdminDto dto)
    {
        throw new NotImplementedException();
    }
}