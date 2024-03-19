using dotNetCrud.Services;
using Microsoft.AspNetCore.Mvc;

namespace dotNetCrud.Controllers{

    [ApiController]
    [Route("api/[controller]")]
    public class UsersController: ControllerBase{
         private readonly IUserService _userService;
         public UsersController(IUserService userService){
             _userService = userService;
         }

        [HttpGet("GetAllUsers")]
        public async Task<IActionResult> GetAllUsers(){
            try{
                 var users = await _userService.GetAllUsers();
                 if(users != null){
                    return Ok(users);
                 }
                 return NotFound();
               
            }catch(Exception ex){
                 return StatusCode(500,ex.Message);
            }
        }
         [HttpGet("GetUser/{id}")]
         public async Task<IActionResult> GetUser(int id){
            try{

                var user =  await _userService.GetUser(id);
                if(user != null){
                    return Ok(user);
                }else{
                    return NotFound();
                }
                 
            }catch(Exception ex){
                return StatusCode(500,ex.Message);
            }
         }
    }
}