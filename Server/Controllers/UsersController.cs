using DatingApp.Data;
using DatingApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.Controllers;

<<<<<<< HEAD
public class UsersController(DataContext context) : BaseApiController
=======
[ApiController]
[Route("api/[controller]")]
public class UsersController(DataContext context) : ControllerBase
>>>>>>> f9829163edd5e20a41c80cd411859614f34cd189
{

    [HttpGet]
    public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
    {
        var users = await context.Users.ToListAsync();

        return users;
    }
    [HttpGet("{id:int}")] // api/users/1
    public async Task<ActionResult<AppUser>> GetUser(int id)
    {
        var user = await context.Users.FindAsync(id);

        if(user == null) return NotFound();      
        return user;
    }

}
