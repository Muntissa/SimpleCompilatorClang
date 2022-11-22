using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SimpleCompilatorClang
{
    public static class Helper
    {
        public static List<string> FirstProcess(string inputString, Variables variables)
        {
            return Regex
                .Matches(inputString, $@"([{String.Join("", variables.doubleSeparators)}]+)|([{String.Join("", variables.singleSeparators)}])|((_)+[A-z]+[0-9]+)|([A-z]+[0-9]+)|([A-z]+)|([0-9]+)")
                .Cast<Match>()
                .Select(m => m.Value)
                .ToList();
        }

        public static string GetStringType(string t, Variables variables)
        {
            if (Char.IsDigit(t.First()))
                return "Literal";
            if (variables.keyWords.Contains(t))
                return "KeyWord";
            else if (Char.IsLetter(t.First()))
                return "ID";
            return "Separator";
        }

        public static IEnumerable<IGrouping<string, string>> SecondProcess(string inputString, Variables variables)
        {
            var list = FirstProcess(inputString, variables);
            return list.Select(s => s.ToString()).GroupBy(t => GetStringType(t, variables));
        }
    }
}
