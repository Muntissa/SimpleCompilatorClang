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
        public List<string> keyWords;
        public Variables(List<string> inSingleSeparators, List<string> inDoubleSeparators, List<string> inKeyWords)
        {
            singleSeparators = inSingleSeparators;
            doubleSeparators = inDoubleSeparators;
            keyWords = inKeyWords;
        }

    }
}
