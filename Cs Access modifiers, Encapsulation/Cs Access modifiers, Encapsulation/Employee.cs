using System;
using System.Collections.Generic;
using System.Text;

namespace Cs_Access_modifiers__public_private_protected___Encapsulation_task
{
    internal class Employee:Human
    {
        public double Salary;
        private string _position;

        public string Position
        {
            get => _position;
            set
            {
                if (ContainsOnlyLetter(value)) 
                    _position = value;
            }
        }

        private bool ContainsOnlyLetter(string str)
        {
            if (!string.IsNullOrWhiteSpace(str))
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (!char.IsLetter(str[i]))
                        return false;
                }
                return true;
            }
            return false;
        }

    }
}
