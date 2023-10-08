using Domain.Models;
using Domain.Repositories.Interfaces;

namespace Api.Repositories;

public class UserRepository : IUserRepository {
    public Task CreateUser(User user) {
        return Task.CompletedTask;
    }
}