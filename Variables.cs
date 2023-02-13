using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCompilatorClang
{
    public class Variables
    {
        public List<string> SingleSeparators;
        public List<string> DoubleSeparators;
        public List<string> KeyWords;
        
        public Variables(List<string> inSingleSeparators, List<string> inDoubleSeparators, List<string> inKeyWords)
        {
            SingleSeparators = inSingleSeparators;
            DoubleSeparators = inDoubleSeparators;
            KeyWords = inKeyWords;
        }
    }
}