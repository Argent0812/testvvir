var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();

// Serve default files and static files
app.UseDefaultFiles(); // Ensures index.html is served by default
app.UseStaticFiles();  // Serves all static files in wwwroot

app.Run();
