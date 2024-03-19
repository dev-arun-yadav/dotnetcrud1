using System.Data;
using Dapper;
using dotNetCrud.Data;

namespace dotNetCrud.Services {
    public class DbService : IDbService {
    
        private readonly DataDapperContext _dapper;
        public DbService(DataDapperContext dapper){
            _dapper  = dapper;
        }

        public async Task<List<T>> GetAll<T>(string command){
            using(IDbConnection connection = _dapper.CreateConnection()){
                var result = await connection.QueryAsync<T>(command);
               return result.ToList();
            }
            
        }
        public async Task<T> GetSingle<T>(string command,int id){
            using(IDbConnection connection = _dapper.CreateConnection()){
                var result = await connection.QuerySingleOrDefaultAsync<T>(command,new {id});
                return result;
            }
        }


    }
}