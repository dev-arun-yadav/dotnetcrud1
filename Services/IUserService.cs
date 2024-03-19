using dotNetCrud.Models;

namespace dotNetCrud.Services{
    public interface IUserService {

        Task<List<User>> GetAllUsers();
        Task<User> GetUser(int id);
    }
}