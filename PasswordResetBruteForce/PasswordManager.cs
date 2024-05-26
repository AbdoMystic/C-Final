using System;
using System.Security.Cryptography;
using System.Text;

public static class PasswordManager
{
    public static string EncryptPassword(string password, string Salt)
    {
        using (var sha256 = SHA256.Create())
        {
            var saltedPassword = password + Salt;
            var saltedPasswordBytes = Encoding.UTF8.GetBytes(saltedPassword);
            var hashBytes = sha256.ComputeHash(saltedPasswordBytes);
            return Convert.ToBase64String(hashBytes);
        }
    }
}
