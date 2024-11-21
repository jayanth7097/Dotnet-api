//using System;
//using System.Threading.Tasks;
//using api1.Dtos.Account;
//using api1.Models;
//using Microsoft.AspNetCore.Identity;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore.Internal;

//namespace api1.Controllers
//{
//    [Route("api/account")]
//    [ApiController]
//    public class AccountController : ControllerBase
//    {
//        private readonly UserManager<AppUser> _userManager;
//        public AccountController(UserManager<AppUser> userManager)
//        {
//            _userManager = userManager;
            
//        }
//        [HttpPost("register")]
//        public async Task<IActionResult> Register([FromBody] RegisterDto registerDto)
//        {
//            try
//            {
//                if (!ModelState.IsValid) 
//                return BadRequest(ModelState);

//                var appUser = new AppUser
//                {
//                    UserName = registerDto.Username,
//                    Email = registerDto.Email,
//                };

//                var createdUser = await _userManager.CreateAsync(appUser, registerDto.Password);
                 
//                if (createdUser.Succeeded)
//                {
//                    var roleResult = await _userManager.AddToRoleAsync(appUser, "User");
//                    if(roleResult.Succeeded)
//                    {
//                        return Ok("User created");
//                    }
//                    else
//                    {
//                        return StatusCode(500, roleResult.Errors);
//                    }
//                }
//                else
//                {
//                    return StatusCode(500, createdUser.Errors);
//                }
//            } catch(Exception e)
//            {
//                return StatusCode(500, e);
//            }
//        }
//    }
//}
