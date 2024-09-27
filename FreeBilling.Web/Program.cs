var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();

var app = builder.Build();

if (builder.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

// Use Default Files (e.g., index.html as the default)
app.UseDefaultFiles();

// Serve static files from wwwroot
app.UseStaticFiles();

app.MapRazorPages();

app.Run();
