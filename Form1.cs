namespace SimpleCompilatorClang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string inputString = "int main() { int k; int sum = 0; for(int i=1; i<=k; i++) {sum = sum + i; } }";
        private void button1_Click(object sender, EventArgs e)
        {
            var groupList = Helper.FirstProcess(inputString);
            textBox1.Text = "";
            foreach (var item in groupList)
                textBox1.Text += item + " - " + Environment.NewLine;
           /* foreach (var item in group)
                    textBox1.Text += item + " - " + *//*group.Key +*//* Environment.NewLine;*/
        }
    }
}