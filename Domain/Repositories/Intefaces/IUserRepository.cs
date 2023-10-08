using Domain.Models;

namespace Domain.Repositories.Interfaces;

public interface IUserRepository
{
    Task CreateUser(User user);
}