using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserCRUD.DATA.DTOs;
using UserCRUD.DATA.Entities;
using UserCRUD.Filters;
using UserCRUD.Service;

namespace UserCRUD.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class UserController : ControllerBase
    {
        private readonly IMapper _mapper;
        public IUserService _userService { get; }

        public UserController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            this._mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            var result = await _userService.GetAsync();

            if (!result.success)
                return BadRequest(result);

            var deneme = _mapper.Map<IEnumerable<User>, IEnumerable<UserDTO>>(result.Model);
            return Ok(deneme);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(int Id)
        {
            var result = await _userService.GetByIdUserAsync(Id);

            if (!result.success)
                return BadRequest(result);

            var deneme = _mapper.Map<User, UserDTO>(result.Model);
            return Ok(deneme);
        }

        [HttpPost]
        [ValidationFilter]
        public async Task<IActionResult> Add(UserDTO userDTO)
        {
            var query = await _userService.AddAsync(_mapper.Map<User>(userDTO));

            return Ok(query);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int Id)
        {
            var result = await _userService.GetByIdUserAsync(Id);

            _userService.Remove(result.Model);

            return NoContent();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete()
        {
            var result = await _userService.GetAsync();

            _userService.RemoveRange(result.Model);

            return NoContent();
        }

    }

}
