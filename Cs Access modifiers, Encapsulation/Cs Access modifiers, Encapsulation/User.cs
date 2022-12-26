using System;
using System.Collections.Generic;
using System.Text;

namespace Cs_Access_modifiers__public_private_protected___Encapsulation_task
{
    internal class User
    {
        private string _userName;
        private string _password;

        public User(string userName)
        {
            _userName= userName;
        }

        public string UserName 
        {
            get => _userName;
            set
            {
                if (value.Length >= 6 && value.Length <= 25)
                {
                    _userName = value;
                }
                else
                {
                    throw new RangeException("UserName deyeri 6-25 araliginda olmalidi ");
                }
            } 
        }

        public string Password
        {
            get => _password;
            set
            {
                if (value.Length >= 8 && value.Length <= 25 && HasDigit(value) && HasUpper(value) && HasLower(value))
                {
                    _password = value;
                }
                else
                {
                    throw new RangeException("Password deyeri 8-25 araliginda olmalidi ");
                }
            }
        }

        public bool HasDigit(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsDigit(str[i]))
                    return true;
            }
            return false;
            
        }
        
        public bool HasUpper(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsUpper(str[i]))
                    return true;
            }
            return false;
        }

        public bool HasLower(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsLower(str[i]))
                    return true; 
            }
            return false;
        }

        public string ShowInfo()
        {
            return $"UserName: {UserName}";
        }
    }
}
