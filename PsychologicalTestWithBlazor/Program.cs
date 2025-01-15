using PsychologicalTestWithBlazor;
using PsychologicalTestWithBlazor.Services;
using PsychologicalTestWithBlazor.Services.Abstractions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<ILoadQuestionsFromFileService, LoadQuestionsFromFileService>();
builder.Services.AddScoped<ICalculateTotalChoiceValueService, CalculateTotalChoiceValueService>();
builder.Services.AddScoped<IDefinePsychotypeService, DefinePsychotypeService>();

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
