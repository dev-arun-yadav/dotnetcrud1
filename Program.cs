using dotNetCrud.Data;
using dotNetCrud.Services;

var builder = WebApplication.CreateBuilder(args);
 
builder.Services.AddControllers();
builder.Services.AddSingleton<DataDapperContext>();
builder.Services.AddScoped<IDbService,DbService>();
builder.Services.AddScoped<IUserService,UserService>();

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}else{
app.UseHttpsRedirection();
}
app.MapControllers();


app.Run();

