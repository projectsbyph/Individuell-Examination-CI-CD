using Examination_CICD; // Så vi hittar din nya kl

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

// Endpoint 1: Encrypt
app.MapPost("/encrypt", (string text) =>
{
    if (string.IsNullOrEmpty(text))
    {
        return Results.BadRequest("Input text cannot be null or empty.");
    }

    var encryptor = new TextEncryptor();
    var encryptedText = encryptor.Encrypt(text);

    return Results.Ok(new { original = text, result = encryptedText });
});

// Endpoint 2: Decrypt
app.MapPost("/decrypt", (string text) =>
{
    if (string.IsNullOrEmpty(text))
    {
        return Results.BadRequest("Input text cannot be null or empty.");
    }

    var encryptor = new TextEncryptor();
    var decryptedText = encryptor.Decrypt(text);

    return Results.Ok(new { original = text, result = decryptedText });
});

app.Run();