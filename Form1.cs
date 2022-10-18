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
 

        private void button1_Click(object sender, EventArgs e)
        {
            var groupList = Helper.FirstProcess(inputString, variables);
            textBox1.Text = "";
            foreach (var item in groupList)
                textBox1.Text += item + " - " + Helper.GetStringType(item, variables) + Environment.NewLine;
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            var list = Helper.SecondProcess(inputString, variables);
            foreach (var group in list)
                if (group.Key == "Literal")
                {
                    listLeteral = list.Where(group => group.Key == "Literal").SelectMany(m => m).Distinct().ToList();
                    foreach (var item in listLeteral)
                        textBox2.Text += listLeteral.IndexOf(item) + " - " + item + Environment.NewLine;
                }
                else if (group.Key == "KeyWord")
                {
                    listKeyWord = list.Where(group => group.Key == "KeyWord").SelectMany(m => m).Distinct().ToList();
                    foreach (var item in listKeyWord)
                        textBox3.Text += listKeyWord.IndexOf(item) + " - " + item + Environment.NewLine;
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