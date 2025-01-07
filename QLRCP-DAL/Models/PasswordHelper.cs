using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace QLRCP_DAL.Models
{
    public class PasswordHelper
    {
        public static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                // Chuyển mật khẩu thành mảng byte
                byte[] bytes = Encoding.UTF8.GetBytes(password);

                // Hash mật khẩu
                byte[] hashBytes = sha256.ComputeHash(bytes);

                // Chuyển đổi mảng byte thành chuỗi hex (chuỗi dạng mã hóa)
                StringBuilder hashStringBuilder = new StringBuilder();
                foreach (var byteValue in hashBytes)
                {
                    hashStringBuilder.Append(byteValue.ToString("x2"));
                }

                return hashStringBuilder.ToString();
            }
        }

        // Hàm kiểm tra mật khẩu có khớp với mật khẩu đã mã hóa không
        public static bool VerifyPassword(string enteredPassword, string storedHash)
        {
            // Hash mật khẩu người dùng nhập vào
            string enteredPasswordHash = HashPassword(enteredPassword);

            // So sánh mật khẩu đã nhập với mật khẩu đã mã hóa trong cơ sở dữ liệu
            return enteredPasswordHash.Equals(storedHash, StringComparison.OrdinalIgnoreCase);
        }
        private static readonly byte[] Salt = new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 };
        private const string SecretKey = "SuperSecretKey123!"; // Trong thực tế nên lưu trong configuration
        private const int Iterations = 10000;
        public static string EncryptPassword(string plainText)
        {
            try
            {
                byte[] clearBytes = Encoding.Unicode.GetBytes(plainText);
                using (Aes encryptor = Aes.Create())
                {
                    // Sử dụng constructor mới của Rfc2898DeriveBytes với số lần lặp
                    using (var pdb = new Rfc2898DeriveBytes(SecretKey, Salt, Iterations))
                    {
                        encryptor.Key = pdb.GetBytes(32);
                        encryptor.IV = pdb.GetBytes(16);
                    }

                    using (var ms = new System.IO.MemoryStream())
                    {
                        using (var cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                        {
                            cs.Write(clearBytes, 0, clearBytes.Length);
                        }
                        return Convert.ToBase64String(ms.ToArray());
                    }
                }
            }
            catch (Exception ex)
            {
                // Trong thực tế nên log lỗi
                throw new Exception("Encryption failed: " + ex.Message);
            }
        }

        // Giải mã mật khẩu từ Settings
        public static string DecryptPassword(string cipherText)
        {
            try
            {
                cipherText = cipherText.Replace(" ", "+");
                byte[] cipherBytes = Convert.FromBase64String(cipherText);

                using (Aes encryptor = Aes.Create())
                {
                    // Sử dụng constructor mới của Rfc2898DeriveBytes với số lần lặp
                    using (var pdb = new Rfc2898DeriveBytes(SecretKey, Salt, Iterations))
                    {
                        encryptor.Key = pdb.GetBytes(32);
                        encryptor.IV = pdb.GetBytes(16);
                    }

                    using (var ms = new System.IO.MemoryStream())
                    {
                        using (var cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                        {
                            cs.Write(cipherBytes, 0, cipherBytes.Length);
                        }
                        return Encoding.Unicode.GetString(ms.ToArray());
                    }
                }
            }
            catch (Exception ex)
            {
                // Trong thực tế nên log lỗi
                throw new Exception("Decryption failed: " + ex.Message);
            }
        }
    }

}
