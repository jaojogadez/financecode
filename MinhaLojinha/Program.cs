using MinhaLojinha.Data;
var builder = WebAppLocation.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// 1. Adicionamos nosso DB
builder.Services.AddDbContext<AppDbContext>();

var app = builder.Build();

// 2. Cria o arquivo de banco automaticamente se não existir
using (var escopo = app.Services.CreateScope())
{
    var db = escopo.ServiceProvider.GetRequiredService<AppDbContext>();
    db.Database.EnsureCreated();
}

if(app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();