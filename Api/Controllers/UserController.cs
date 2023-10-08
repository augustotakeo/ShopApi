using Microsoft.AspNetCore.Mvc;
using MediatR;
using Domain.Commands.Requests;

namespace Api.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase {

    [HttpPost]
    public async Task<IActionResult> CreateUser(
        [FromServices] IMediator mediator,
        [FromBody] CreateUserRequest user
    ) {
        var createdUser = await mediator.Send(user);
        return Ok(createdUser);
    }
}