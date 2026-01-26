var builder = WebApplication.CreateBuilder(args);

// Adding Swagger services which will help in API documentation
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Activate Swagger which provides API documentation
app.UseSwagger();
app.UseSwaggerUI();

// Creating endpoint one which encrypts the input text
app.MapPost("/encrypt", (string text) =>
{
    if (string.IsNullOrEmpty(text))
    {
        return Results.BadRequest("Input text cannot be null or empty.");
    }

    // Simple encryption logic (Caesar cipher with a shift of 3)
    var encryptedText = new string(text.Select(c => (char)(c+1)).ToArray());
    return Results.Ok(new {orginal = text, result = encryptedText}); 
});

// Creating endpoint two which decrypts the input text
app.MapPost("/decrypt", (string text) =>
{
    if (string.IsNullOrEmpty(text))
    {
        return Results.BadRequest("Input text cannot be null or empty.");
    }

    // Simple decryption logic (Caesar cipher with a shift of 3)
    var decryptedText = new string(text.Select(c => (char)(c-1)).ToArray());
    return Results.Ok(new {orginal = text, result = decryptedText}); 
});

app.Run();
