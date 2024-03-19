using dotNetCrud.Models;

namespace dotNetCrud.Services{
    public class UserService : IUserService{
        private readonly IDbService _dbService;

        public UserService(IDbService dbService){
            _dbService = dbService;
        }

       public async Task<List<User>> GetAllUsers(){
          string query = "SELECT Users.Id,Users.Name,Users.LastName,Users.Email,Users.Gender,Users.Active FROM UserSchema.Users AS Users";
           var result = await _dbService.GetAll<User>(query);
           return result;
       }

        public async Task<User> GetUser(int id)
        {
            string query = "SELECT Users.Id,Users.Name,Users.LastName,Users.Email,Users.Gender,Users.Active FROM UserSchema.Users AS Users WHERE Id = @Id";
            var user = await _dbService.GetSingle<User>(query,id);
            return user;
           
        }
    }
}