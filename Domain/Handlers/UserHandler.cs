using Domain.Commands.Requests;
using Domain.Commands.Responses;
using Domain.Handle.Interfaces;
using Domain.Models;
using Domain.Repositories.Interfaces;
using MediatR;
using System;

namespace Domain.Handlers;

public class UserHandler : IUserHandler {

    private readonly IUserRepository UserRepository;

    public UserHandler(IUserRepository userRepository) {
        UserRepository = userRepository;
    }

    public Task<CreateUserResponse> Handle(CreateUserRequest req, CancellationToken token) {

        var user = new User {
            Id = Guid.NewGuid(),
            Name = req.Name,
            Username = req.Username,
            Address = req.Address,
            Document = req.Document,
            DateOfBirth = req.DateOfBirth,
            CreateAt = DateTime.Now
        };

        UserRepository.CreateUser(user);

        var response = new CreateUserResponse {
            Id = user.Id
        };

        return Task.FromResult(response);
    }
}