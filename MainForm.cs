using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SimpleCompilatorClang
{
    public partial class TranslatorForm : Form
    {
        public TranslatorForm()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            buttonFourTB.Enabled = false;
            buttonGenerealTB.Enabled = false;
        }

        readonly Variables Variables = new(
            new List<string> { "/", "(", ")", "{", "}", "*", "=", ";", "+", "-", ",", ">", "<" },
            new List<string> { "==", "++", "--", "<=", ">=", "!=" },
            new List<string> { "for", "int", "main", "double, float", "if" }
            );

        List<string>? listLeteral, listKeyWord, listID, listSeparator;

        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPageInput)
            {
                tabControl1.Size = new (260, 572);
                this.Size = new (300, 635);
            }
            else if (tabControl1.SelectedTab == tabPageLexical)
            {
                tabControl1.Size = new (260, 630);
                this.Size = new (294, 685);
            }
            else if (tabControl1.SelectedTab == tabPageLexemClass)
            {
                tabControl1.Size = new (865, 660);
                this.Size = new (900, 715);
            }
        }

        private void OpenBTN_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new();

            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            if (openFileDialog.ShowDialog() == DialogResult.OK)
                inputTB.Text = File.ReadAllText(openFileDialog.FileName);
        }

        private void GeneralListButton_Click(object sender, EventArgs e)
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

        private void LexicalBTN_Click(object sender, EventArgs e)
        {
            if (inputTB.Text == "")
                MessageBox.Show("Редактор кода пуст! Введите фрагмент кода", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            var groupList = Helper.FirstProcess(inputTB.Text, Variables);

            dataGridViewLexical.Rows.Clear();

            foreach (var item in groupList)
            {
                int rowIndex = dataGridViewLexical.Rows.Add();

                DataGridViewRow row = dataGridViewLexical.Rows[rowIndex];

                row.Cells["Value"].Value = item;
                row.Cells["Type"].Value = Helper.GetStringType(item, Variables);
            }

            buttonFourTB.Enabled = true;
        }

        private void FourTableBTN_Click(object sender, EventArgs e)
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

            if (listLeteral is null)
                listLeteral = new() { "Пусто" };

            if (listID is null)
                listID = new() { "Пусто" };

            if (listKeyWord is null)
                listKeyWord = new() { "Пусто" };

            if (listSeparator is null)
                listSeparator = new() { "Пусто" };

            buttonGenerealTB.Enabled = true;
        }
    }
}