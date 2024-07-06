using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SW_ConsoleApp
{
    public class InputService
    {
        public List<string> SeperatedByComas(InputString input)
        {
            var values = input.Value.Split(',').Select(v => v.Trim()).ToList();
            return values;
        }
    }
}
