using System;
using System.Collections.Generic;
using System.Text;

namespace Cs_Access_modifiers__public_private_protected___Encapsulation_task
{
    internal class Human
    {
        public string FullName;
        private int _age;

        public int Age 
        {
            get => _age;
            set
            {
                if (value >= 0)
                {
                    _age = value;
                }
            } 
        }
    }
}
