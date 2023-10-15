using Domain.Commands.Requests;
using Domain.Commands.Responses;
using MediatR;

namespace Domain.Handle.Interfaces;

public interface IUserHandler : 
        IRequestHandler<CreateUserRequest, CreateUserResponse>
{
}