﻿using MyBase.BLL.Dto;
using MyBase.BLL.Services.UserService;
using MyBase.WEB.Controllers.Api.Models;
using System.Threading.Tasks;
using System.Web.Http;

namespace MyBase.WEB.Controllers.Api
{
    [RoutePrefix("api/users")]
    public class UsersController : ApiController 
    {
        readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        // GET: api/Users
        [Route("")]
        public async Task<Page> Get([FromUri]int? page, [FromUri]int? size)
        {
            var pageSize = size ?? 10;
            var pageNumber = page ?? 1;
            var users = await _userService.GetUsersAsync(pageSize, pageNumber);

            var result = new Page
            {
                PageNumber = pageNumber,
                PageSize = pageSize,
                TotalItems = await _userService.GetUsersCountAsync(),
                Users = users
            };
            return result;
        }

        // GET: api/Users/8
        [Route("{id}")]
        public async Task<UserDto> Get(int id)
        {
            var userDto = await _userService.GetUserByIdAsync(id);

            return userDto;
        }

        // POST: api/Users
        [HttpPost]
        [Route("")]
        public async Task<int> Create([FromBody]UserDto user)
        {
            return await _userService.CreateUserAsync(user);
        }

        // PUT: api/Users/5
        [HttpPut]
        [Route("")]
        public async Task Edit([FromBody]UserDto user)
        {
            await _userService.UpdateUserAsync(user);
        }

        // DELETE: api/Users/5
        [Route("{id}")]
        public async Task Delete(int id)
        {
            await _userService.DeleteUserByIdAsync(id);
        }
    }
}
