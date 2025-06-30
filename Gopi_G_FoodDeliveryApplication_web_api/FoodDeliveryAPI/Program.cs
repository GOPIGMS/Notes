
var builder = WebApplication.CreateBuilder(args);

//reveal our end point
builder.Services.AddEndpointsApiExplorer();
//testing  like postman visual demo for endpoint only for developement mode 
builder.Services.AddSwaggerGen();
//add the controllers 
builder.Services.AddControllers();

var app = builder.Build();

//setting the environment

//configure the http request pipeline
if (app.Environment.IsDevelopment())
{
    //dont use thing in production

    //shows the error in the page
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.UseRouting();
//we dont use this thing same we need to modify in production
app.UseCors(policy => policy.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());

//mostly we use the page connecting the page
app.MapGet("/", () => "Contacts page application");

app.Run();