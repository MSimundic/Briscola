using Briscola.Model;
using Microsoft.AspNetCore.Mvc;

namespace Briscola.WebApi.Controllers;

[ApiController]
public class UsersController : ControllerBase
{
    private readonly UserRepository _usersRepository;

    public UsersController(UserRepository usersRepository)
    {
        _usersRepository = usersRepository;
    }

   
    [Route("/Login")]
    [HttpGet]
    public async Task<IActionResult> Login()
    {
        return Ok(_usersRepository.GetAllUsers());
    }

    [HttpGet]
    [Route("/Register")]
    public IActionResult CreateUSer(
        [FromRoute] int userId)
    {
        var user = _usersRepository.GetUser(userId);

        return user is null ? NotFound() : Ok(user);
    }    

    [HttpGet]
    [Route("/Logout")]
    public IActionResult Logout(
        [FromRoute] int userId)
    {
        var user = _usersRepository.GetUser(userId);

        return user is null ? NotFound() : Ok(user);
    }    
}