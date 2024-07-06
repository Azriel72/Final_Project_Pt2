using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SW_ConsoleApp
{
    public class InputString
    {
        public string Value { get; private set; }

        public InputString(string input)
        {
            if (string.IsNullOrEmpty(input))
            { 
                throw new ArgumentException("The string cannot be null or empty");
            }

            Value = input;
        }
    }
}
