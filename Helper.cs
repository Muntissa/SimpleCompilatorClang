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
                .Matches(inputString, $@"([{String.Join("", variables.DoubleSeparators)}]+)|([{String.Join("", variables.SingleSeparators)}])|((_)+[A-z]+[0-9]+)|([A-z]+[0-9]+)|([A-z]+)|([0-9]+)")
                .Cast<Match>()
                .Select(m => m.Value)
                .ToList();
        }

        public static string GetStringType(string t, Variables variables)
        {
            if (Char.IsDigit(t.First()))
                return "Литерал";
            
            if (variables.KeyWords.Contains(t))
                return "Ключевое слово";
            
            else if (Char.IsLetter(t.First()) || (t.First() == '_'))
                return "Идентификатор";
            
            return "Разделитель";
        }

        public static IEnumerable<IGrouping<string, string>> SecondProcess(string inputString, Variables variables)
        {
            var list = FirstProcess(inputString, variables);
            
            return list
                .Select(s => s.ToString())
                .GroupBy(t => GetStringType(t, variables));
        }
    }
}