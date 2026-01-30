using System.Linq;

namespace Examination_CICD
{
    public class TextEncryptor
    {
        public string Encrypt(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                throw new ArgumentException("Input text cannot be null or empty.");
            }
            return new string(text.Select(c => (char)(c + 1)).ToArray());
        }

        public string Decrypt(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                throw new ArgumentException("Input text cannot be null or empty.");
            }
            return new string(text.Select(c => (char)(c - 1)).ToArray());
        }
    }
}