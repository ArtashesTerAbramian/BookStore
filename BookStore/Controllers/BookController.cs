using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.BLL.Filters.BookFilters;
using BookStore.BLL.Services.BookService;
using BookStore.DTO;
using BookStore.DTO.BookDtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }
        // GET: api/Book
        [HttpGet("get-by-id")]
        public async Task<ResponseDto<BookDto>> Get(int id)
        {
            return await _bookService.GetById(id);
        }

        // GET: api/Book/5
        [HttpGet("get-all")]
        public async Task<ResponseDto<PagedModelDto<BookDto>>> GetAll([FromQuery] BookFilter filter)
        {
            return await _bookService.GetAll(filter);
        }

        // POST: api/Book
        [HttpPost("add")]
        public async Task<ResponseDto<BookDto>> Post([FromBody] AddBookDto dto)
        {
            return await _bookService.Add(dto);
        }

        // PUT: api/Book/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Book/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
