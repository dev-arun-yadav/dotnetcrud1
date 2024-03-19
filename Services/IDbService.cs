
namespace dotNetCrud.Services {
    public interface IDbService {
        
        Task<List<T>> GetAll<T>(string command);

        Task<T> GetSingle<T>(string command,int id);
    }

   
}