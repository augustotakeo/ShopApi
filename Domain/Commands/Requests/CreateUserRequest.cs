using Domain.Commands.Responses;
using MediatR;
using System;

namespace Domain.Commands.Requests;

public class CreateUserRequest : IRequest<CreateUserResponse> {
    public string Name { get; set; }
    public string Username { get; set; }
    public string Document { get; set; }
    public string Address { get; set; }
    public DateTime DateOfBirth { get; set; }
}