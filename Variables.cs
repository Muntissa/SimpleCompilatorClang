using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCompilatorClang
{
    public class Variables
    {
        public List<string> singleSeparators;
        public List<string> doubleSeparators;
        string[]? keyWords;
        public Variables(string[] inSingleSeparators, string[] inDoubleSeparators)
        {
            singleSeparators = inSingleSeparators.ToList();
            doubleSeparators = inDoubleSeparators.ToList();
        }

    }
}
