namespace SimpleCompilatorClang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string inputString = "int main() { int k; int sum = 0; for(int i=1; i<=k; i++) {sum = sum + i; } }";
        Variables variables = new Variables(new List<string> { "(", ")", "{", "}", "=", ";" }, new List<string> { "<=" }, new List<string> { "for", "int", "main" });
        List<string> listLeteral, listKeyWord, listID, listSeparator;

        private void button3_Click(object sender, EventArgs e)
        {
            var firstList = Helper.FirstProcess(inputString, variables);
            foreach(var word in firstList)
            {
                if (listLeteral.Contains(word))
                    textBox6.Text += "( " + "1" + " : " + listLeteral.IndexOf(word) + " )" + Environment.NewLine;
                else if (listKeyWord.Contains(word))
                    textBox6.Text += "( " + "2" + " : " + listKeyWord.IndexOf(word) + " )" + Environment.NewLine;
                else if (listID.Contains(word))
                    textBox6.Text += "( " + "3" + " : " + listID.IndexOf(word) + " )" + Environment.NewLine;
                else if (listSeparator.Contains(word))
                    textBox6.Text += "( " + "4" + " : " + listSeparator.IndexOf(word) + " )" + Environment.NewLine;
            }
        }

        private void buttonLB1_Click(object sender, EventArgs e)
        {
            var groupList = Helper.FirstProcess(inputString, variables);
            lexicalAnalysisiTB.Text = "";
            foreach (var item in groupList)
                lexicalAnalysisiTB.Text += item + " - " + Helper.GetStringType(item, variables) + Environment.NewLine;
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            var list = Helper.SecondProcess(inputString, variables);
            foreach (var group in list)
                if (group.Key == "Literal")
                {
                    listLeteral = list.Where(group => group.Key == "Literal").SelectMany(m => m).Distinct().ToList();
                    foreach (var item in listLeteral)
                        textBoxLiteral.Text += listLeteral.IndexOf(item) + " - " + item + Environment.NewLine;
                }
                else if (group.Key == "KeyWord")
                {
                    listKeyWord = list.Where(group => group.Key == "KeyWord").SelectMany(m => m).Distinct().ToList();
                    foreach (var item in listKeyWord)
                        textBoxKeyWord.Text += listKeyWord.IndexOf(item) + " - " + item + Environment.NewLine;
                }
                else if (group.Key == "ID")
                {
                    listID = list.Where(group => group.Key == "ID").SelectMany(m => m).Distinct().ToList();
                    foreach (var item in listID)
                        textBox4.Text += listID.IndexOf(item) + " - " + item + Environment.NewLine;
                }
                else if (group.Key == "Separator")
                {
                    listSeparator = list.Where(group => group.Key == "Separator").SelectMany(m => m).Distinct().ToList();
                    foreach (var item in listSeparator)
                        textBox5.Text += listSeparator.IndexOf(item) + " - " + item + Environment.NewLine;
                }
        }
    }
}