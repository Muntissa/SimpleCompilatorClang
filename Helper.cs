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
        public static /*IEnumerable<IGrouping<string, string>>*/List<string> FirstProcess(string inputString)
        {
            Variables variables = new Variables(new string[] { "(", ")", "{", "}", "=", ";" }, new string[] { "<=" });
            return Regex.Matches(inputString, $@"([{String.Join("", variables.doubleSeparators)}])|([{String.Join("", variables.singleSeparators)}])|((_)+[A-z]+[0-9]+)|([A-z]+[0-9]+)|([A-z]+)|([0-9]+)")
                .Cast<Match>()
                .Select(m => m.Value)
                .ToList();
/*                .Select(s => s.ToString())
                .GroupBy(t => GetStringType(t));*/
        }

        public static string GetStringType(string t)
        {
            if (Char.IsDigit(t.First()))
                return "Литерал";
            if (Char.IsLetter(t.First()))
                return "Идентификатор";
            return "Разделитель";
        }
    }
}
