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
    }
}
