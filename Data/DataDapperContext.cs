using System.Data;
using Microsoft.Data.SqlClient;

namespace dotNetCrud.Data {
    public class DataDapperContext {
         
         private readonly IConfiguration _config;
         public DataDapperContext(IConfiguration config){
            _config = config;
         }

         public IDbConnection CreateConnection() => new SqlConnection(_config.GetConnectionString("DefaultConnection"));
    }
}