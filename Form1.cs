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
 

        private void button1_Click(object sender, EventArgs e)
        {
            var groupList = Helper.FirstProcess(inputString, variables);
            textBox1.Text = "";
            foreach (var item in groupList)
                textBox1.Text += item + " - " + Helper.GetStringType(item, variables) + Environment.NewLine;
           /* foreach (var item in group)
                    textBox1.Text += item + " - " + *//*group.Key +*//* Environment.NewLine;*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var list = Helper.SecondProcess(inputString, variables);
            foreach (var group in list)
                if (group.Key == "Literal")
                {
                    var literalList = new List<string>(list.Where(group => group.Key == "Litheral").SelectMany(m => m).ToList());
                    foreach (var item in group)
                        textBox2.Text += item + " - " + group.Key + Environment.NewLine;
                }
                else if(group.Key == "KeyWord")
                    foreach(var item in group)
                        textBox3.Text += item + " - " + group.Key + Environment.NewLine;
                else if(group.Key == "ID")
                    foreach(var item in group)
                        textBox4.Text += item + " - " + group.Key + Environment.NewLine;
                else if(group.Key == "Separator")
                    foreach(var item in group)
                        textBox5.Text += item + " - " + group.Key + Environment.NewLine;
        }
    }
}