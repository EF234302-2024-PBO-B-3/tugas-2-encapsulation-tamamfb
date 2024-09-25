using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation.Extra
{
    public class UserAccount
    {
        private string username;
        private string password;
        public string Email { get; set; }

        public UserAccount(string username, string email, string password)
        {
            this.username = username;
            this.Email = email;
            SetPassword(password);
        }

        private void SetPassword(string password)
        {
            if (IsValidPassword(password))
            {
                this.password = password;
            }
            else
            {
                throw new ArgumentException("Password does not meet the requirements.");
            }
        }

        public bool ChangePassword(string oldPassword, string newPassword)
        {
            if (this.password == oldPassword && IsValidPassword(newPassword))
            {
                this.password = newPassword;
                return true;
            }
            return false;
        }

        private bool IsValidPassword(string password)
        {
            bool hasUpperCase = password.Any(char.IsUpper);
            bool hasLowerCase = password.Any(char.IsLower);
            bool hasNumbers = password.Any(char.IsDigit);
            return password.Length >= 8 && hasUpperCase && hasLowerCase && hasNumbers;
        }
    }
}
