using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SimpleCompilatorClang
{
    public partial class TranslatorForm : Form
    {
        public TranslatorForm()
        {
            InitializeComponent();
        }

        /*main()
        {
            int a, b;
            c = 0;
            for (b = 1; b < 5; b++)
            {
                b = 5;
                c = c + b * 3;
            }
        }*/

/*        int main() 
        { 
            int k; 
            int sum = 0; 
            for (int i = 1; i <= k; i++) 
            {
                sum = sum + i; 
            } 
        }*/
        Variables Variables = new Variables(
            new List<string> { "/", "(", ")", "{", "}", "*", "=", ";", "+", "-", ",", ">", "<"},
            new List<string> { "==", "++", "--", "<=", ">=", "!=" }, 
            new List<string> { "for", "int", "main", "double, float" }
            );
        
        List<string> listLeteral, listKeyWord, listID, listSeparator;

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPageInput)
            {
                tabControl1.Size = new Size(260, 574);
                this.Size = new Size(300, 635);
            }
            else if(tabControl1.SelectedTab == tabPageLexical)
            {
                tabControl1.Size = new Size(260, 630);
                this.Size = new Size(294, 685);
            }
            else if(tabControl1.SelectedTab == tabPageLexemClass)
            {
                tabControl1.Size = new Size(865, 660);
                this.Size = new Size(900, 715);
            } 
        }

        private void generalListButton_Click(object sender, EventArgs e)
        {
            var firstList = Helper.FirstProcess(inputTB.Text, Variables);
            
            dataGridViewGeneral.Rows.Clear();


            foreach (var word in firstList)
            {
                int rowIndex = dataGridViewGeneral.Rows.Add();

                DataGridViewRow row = dataGridViewGeneral.Rows[rowIndex];

                if (listLeteral.Contains(word))
                {
                    row.Cells["List"].Value = "1" + " : " + listLeteral.IndexOf(word);
                }    
                else if (listKeyWord.Contains(word))
                {
                    row.Cells["List"].Value = "2" + " : " + listKeyWord.IndexOf(word);
                }
                else if (listID.Contains(word))
                {
                    row.Cells["List"].Value = "3" + " : " + listID.IndexOf(word);
                }
                else if (listSeparator.Contains(word))
                {
                    row.Cells["List"].Value = "4" + " : " + listSeparator.IndexOf(word);
                } 
            }
        }

        private void buttonLB1_Click(object sender, EventArgs e)
        {
            var groupList = Helper.FirstProcess(inputTB.Text, Variables);
            
            dataGridViewLexical.Rows.Clear();
            
            foreach (var item in groupList)
            {
                int rowIndex = dataGridViewLexical.Rows.Add();
                
                DataGridViewRow row = dataGridViewLexical.Rows[rowIndex];
                
                row.Cells["Value"].Value = item;
                row.Cells["Type"].Value = Helper.GetStringType(item, Variables);
            }
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            var list = Helper.SecondProcess(inputTB.Text, Variables);

            dataGridViewLiteral.Rows.Clear();
            dataGridViewKeyWords.Rows.Clear();
            dataGridViewID.Rows.Clear();
            dataGridViewSeparators.Rows.Clear();

            foreach (var group in list)
                if (group.Key == "Литерал")
                {
                    listLeteral = list.Where(group => group.Key == "Литерал").SelectMany(m => m).Distinct().ToList();

                    foreach (var item in listLeteral)
                    {
                        int rowIndex = dataGridViewLiteral.Rows.Add();

                        DataGridViewRow row = dataGridViewLiteral.Rows[rowIndex];
                        
                        row.Cells["IndexLiteral"].Value = listLeteral.IndexOf(item);
                        row.Cells["ValueLiteral"].Value = item;
                    }
                }
                else if (group.Key == "Ключевое слово")
                {
                    listKeyWord = list.Where(group => group.Key == "Ключевое слово").SelectMany(m => m).Distinct().ToList();
                    foreach (var item in listKeyWord)
                    {
                        int rowIndex = dataGridViewKeyWords.Rows.Add();

                        DataGridViewRow row = dataGridViewKeyWords.Rows[rowIndex];
                        
                        row.Cells["IndexKeyWord"].Value = listKeyWord.IndexOf(item);
                        row.Cells["ValueKeyWord"].Value = item;
                    }
                }
                else if (group.Key == "Идентификатор")
                {
                    listID = list.Where(group => group.Key == "Идентификатор").SelectMany(m => m).Distinct().ToList();
                    foreach (var item in listID)
                    {
                        int rowIndex = dataGridViewID.Rows.Add();

                        DataGridViewRow row = dataGridViewID.Rows[rowIndex];
                        
                        row.Cells["IndexID"].Value = listID.IndexOf(item);
                        row.Cells["ValueID"].Value = item;
                    }
                }
                else if (group.Key == "Разделитель")
                {
                    listSeparator = list.Where(group => group.Key == "Разделитель").SelectMany(m => m).Distinct().ToList();
                    foreach (var item in listSeparator)
                    {
                        int rowIndex = dataGridViewSeparators.Rows.Add();

                        DataGridViewRow row = dataGridViewSeparators.Rows[rowIndex];
                        row.Cells["IndexSeparator"].Value = listSeparator.IndexOf(item);
                        row.Cells["ValueSeparator"].Value = item;
                    }
                }
        }
    }
}