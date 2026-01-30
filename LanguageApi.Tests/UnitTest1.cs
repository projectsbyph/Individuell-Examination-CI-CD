using Xunit;
using Examination_CICD; 

namespace LanguageApi.Tests;

public class CryptoTests
{
    [Fact]
    public void Encrypt_ShouldReturnShiftedText()
    {
        // 1. Arrange (Förbered)
        var encryptor = new TextEncryptor();
        string input = "hello";
        string expected = "ifmmp";

        // 2. Act (Utför)
        string result = encryptor.Encrypt(input);

        // 3. Assert (Kontrollera)
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Decrypt_ShouldReturnOriginalText()
    {
        // 1. Arrange
        var encryptor = new TextEncryptor();
        string input = "ifmmp";
        string expected = "hello";

        // 2. Act
        string result = encryptor.Decrypt(input);

        // 3. Assert
        Assert.Equal(expected, result);
    }
}