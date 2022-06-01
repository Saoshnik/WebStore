using WebEmptyTemplate.Data.DataBase;
using WebEmptyTemplate.Data.Models.CsModels.Components;

DbManager.Nothing();





var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseStaticFiles();
app.UseStatusCodePages();
// app.UseMvc();
// app.UseMvcWithDefaultRoute();

app.MapGet("/", () => "Hello World!");

app.Run();
