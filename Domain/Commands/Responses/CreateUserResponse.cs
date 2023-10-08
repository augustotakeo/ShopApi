using MediatR;
using System;

namespace Domain.Commands.Responses;

public class CreateUserResponse {
    public Guid Id { get; set; }
}