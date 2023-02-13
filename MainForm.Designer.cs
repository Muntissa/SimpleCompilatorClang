namespace SimpleCompilatorClang
{
    partial class TranslatorForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageInput = new System.Windows.Forms.TabPage();
            this.OpenBTN = new System.Windows.Forms.Button();
            this.inputTB = new System.Windows.Forms.TextBox();
            this.tabPageLexical = new System.Windows.Forms.TabPage();
            this.startLexicalBTN = new System.Windows.Forms.Button();
            this.dataGridViewLexical = new System.Windows.Forms.DataGridView();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageLexemClass = new System.Windows.Forms.TabPage();
            this.dataGridViewGeneral = new System.Windows.Forms.DataGridView();
            this.List = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewSeparators = new System.Windows.Forms.DataGridView();
            this.IndexSeparator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValueSeparator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewKeyWords = new System.Windows.Forms.DataGridView();
            this.IndexKeyWord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValueKeyWord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewID = new System.Windows.Forms.DataGridView();
            this.IndexID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValueID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewLiteral = new System.Windows.Forms.DataGridView();
            this.IndexLiteral = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValueLiteral = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classificationLabel = new System.Windows.Forms.Label();
            this.separatorTB = new System.Windows.Forms.Label();
            this.keyWordTB = new System.Windows.Forms.Label();
            this.idTB = new System.Windows.Forms.Label();
            this.leteralTB = new System.Windows.Forms.Label();
            this.buttonGenerealTB = new System.Windows.Forms.Button();
            this.buttonFourTB = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageInput.SuspendLayout();
            this.tabPageLexical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLexical)).BeginInit();
            this.tabPageLexemClass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGeneral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSeparators)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKeyWords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLiteral)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageInput);
            this.tabControl1.Controls.Add(this.tabPageLexical);
            this.tabControl1.Controls.Add(this.tabPageLexemClass);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(260, 572);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.TabControl_SelectedIndexChanged);
            // 
            // tabPageInput
            // 
            this.tabPageInput.Controls.Add(this.OpenBTN);
            this.tabPageInput.Controls.Add(this.inputTB);
            this.tabPageInput.Location = new System.Drawing.Point(4, 24);
            this.tabPageInput.Name = "tabPageInput";
            this.tabPageInput.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInput.Size = new System.Drawing.Size(252, 544);
            this.tabPageInput.TabIndex = 0;
            this.tabPageInput.Text = "Редактор кода";
            this.tabPageInput.UseVisualStyleBackColor = true;
            // 
            // OpenBTN
            // 
            this.OpenBTN.Location = new System.Drawing.Point(6, 498);
            this.OpenBTN.Name = "OpenBTN";
            this.OpenBTN.Size = new System.Drawing.Size(240, 40);
            this.OpenBTN.TabIndex = 1;
            this.OpenBTN.Text = "Открыть код из файла";
            this.OpenBTN.UseVisualStyleBackColor = true;
            this.OpenBTN.Click += new System.EventHandler(this.OpenBTN_Click);
            // 
            // inputTB
            // 
            this.inputTB.Location = new System.Drawing.Point(6, 6);
            this.inputTB.Multiline = true;
            this.inputTB.Name = "inputTB";
            this.inputTB.Size = new System.Drawing.Size(240, 486);
            this.inputTB.TabIndex = 0;
            // 
            // tabPageLexical
            // 
            this.tabPageLexical.Controls.Add(this.startLexicalBTN);
            this.tabPageLexical.Controls.Add(this.dataGridViewLexical);
            this.tabPageLexical.Location = new System.Drawing.Point(4, 24);
            this.tabPageLexical.Name = "tabPageLexical";
            this.tabPageLexical.Size = new System.Drawing.Size(1006, 544);
            this.tabPageLexical.TabIndex = 2;
            this.tabPageLexical.Text = "Лексический анализ";
            this.tabPageLexical.UseVisualStyleBackColor = true;
            // 
            // startLexicalBTN
            // 
            this.startLexicalBTN.Location = new System.Drawing.Point(0, 549);
            this.startLexicalBTN.Name = "startLexicalBTN";
            this.startLexicalBTN.Size = new System.Drawing.Size(252, 47);
            this.startLexicalBTN.TabIndex = 3;
            this.startLexicalBTN.Text = "Начать лексический анализ";
            this.startLexicalBTN.UseVisualStyleBackColor = true;
            this.startLexicalBTN.Click += new System.EventHandler(this.LexicalBTN_Click);
            // 
            // dataGridViewLexical
            // 
            this.dataGridViewLexical.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLexical.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Type,
            this.Value});
            this.dataGridViewLexical.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewLexical.Name = "dataGridViewLexical";
            this.dataGridViewLexical.RowTemplate.Height = 25;
            this.dataGridViewLexical.Size = new System.Drawing.Size(250, 540);
            this.dataGridViewLexical.TabIndex = 0;
            // 
            // Type
            // 
            this.Type.HeaderText = "Тип";
            this.Type.Name = "Type";
            // 
            // Value
            // 
            this.Value.HeaderText = "Значение";
            this.Value.Name = "Value";
            // 
            // tabPageLexemClass
            // 
            this.tabPageLexemClass.Controls.Add(this.dataGridViewGeneral);
            this.tabPageLexemClass.Controls.Add(this.dataGridViewSeparators);
            this.tabPageLexemClass.Controls.Add(this.dataGridViewKeyWords);
            this.tabPageLexemClass.Controls.Add(this.dataGridViewID);
            this.tabPageLexemClass.Controls.Add(this.dataGridViewLiteral);
            this.tabPageLexemClass.Controls.Add(this.classificationLabel);
            this.tabPageLexemClass.Controls.Add(this.separatorTB);
            this.tabPageLexemClass.Controls.Add(this.keyWordTB);
            this.tabPageLexemClass.Controls.Add(this.idTB);
            this.tabPageLexemClass.Controls.Add(this.leteralTB);
            this.tabPageLexemClass.Controls.Add(this.buttonGenerealTB);
            this.tabPageLexemClass.Controls.Add(this.buttonFourTB);
            this.tabPageLexemClass.Location = new System.Drawing.Point(4, 24);
            this.tabPageLexemClass.Name = "tabPageLexemClass";
            this.tabPageLexemClass.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLexemClass.Size = new System.Drawing.Size(1006, 544);
            this.tabPageLexemClass.TabIndex = 1;
            this.tabPageLexemClass.Text = "Классификация лексем";
            this.tabPageLexemClass.UseVisualStyleBackColor = true;
            // 
            // dataGridViewGeneral
            // 
            this.dataGridViewGeneral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGeneral.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.List});
            this.dataGridViewGeneral.Location = new System.Drawing.Point(356, 169);
            this.dataGridViewGeneral.Name = "dataGridViewGeneral";
            this.dataGridViewGeneral.RowTemplate.Height = 25;
            this.dataGridViewGeneral.Size = new System.Drawing.Size(144, 457);
            this.dataGridViewGeneral.TabIndex = 16;
            // 
            // List
            // 
            this.List.HeaderText = "Общий список";
            this.List.Name = "List";
            // 
            // dataGridViewSeparators
            // 
            this.dataGridViewSeparators.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSeparators.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IndexSeparator,
            this.ValueSeparator});
            this.dataGridViewSeparators.Location = new System.Drawing.Point(610, 337);
            this.dataGridViewSeparators.Name = "dataGridViewSeparators";
            this.dataGridViewSeparators.RowTemplate.Height = 25;
            this.dataGridViewSeparators.Size = new System.Drawing.Size(243, 289);
            this.dataGridViewSeparators.TabIndex = 15;
            // 
            // IndexSeparator
            // 
            this.IndexSeparator.HeaderText = "Индекс";
            this.IndexSeparator.Name = "IndexSeparator";
            // 
            // ValueSeparator
            // 
            this.ValueSeparator.HeaderText = "Значение";
            this.ValueSeparator.Name = "ValueSeparator";
            // 
            // dataGridViewKeyWords
            // 
            this.dataGridViewKeyWords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKeyWords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IndexKeyWord,
            this.ValueKeyWord});
            this.dataGridViewKeyWords.Location = new System.Drawing.Point(610, 25);
            this.dataGridViewKeyWords.Name = "dataGridViewKeyWords";
            this.dataGridViewKeyWords.RowTemplate.Height = 25;
            this.dataGridViewKeyWords.Size = new System.Drawing.Size(243, 289);
            this.dataGridViewKeyWords.TabIndex = 14;
            // 
            // IndexKeyWord
            // 
            this.IndexKeyWord.HeaderText = "Индекс";
            this.IndexKeyWord.Name = "IndexKeyWord";
            // 
            // ValueKeyWord
            // 
            this.ValueKeyWord.HeaderText = "Значение";
            this.ValueKeyWord.Name = "ValueKeyWord";
            // 
            // dataGridViewID
            // 
            this.dataGridViewID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewID.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IndexID,
            this.ValueID});
            this.dataGridViewID.Location = new System.Drawing.Point(6, 337);
            this.dataGridViewID.Name = "dataGridViewID";
            this.dataGridViewID.RowTemplate.Height = 25;
            this.dataGridViewID.Size = new System.Drawing.Size(243, 289);
            this.dataGridViewID.TabIndex = 13;
            // 
            // IndexID
            // 
            this.IndexID.HeaderText = "Индекс";
            this.IndexID.Name = "IndexID";
            // 
            // ValueID
            // 
            this.ValueID.HeaderText = "Значение";
            this.ValueID.Name = "ValueID";
            // 
            // dataGridViewLiteral
            // 
            this.dataGridViewLiteral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLiteral.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IndexLiteral,
            this.ValueLiteral});
            this.dataGridViewLiteral.Location = new System.Drawing.Point(6, 25);
            this.dataGridViewLiteral.Name = "dataGridViewLiteral";
            this.dataGridViewLiteral.RowTemplate.Height = 25;
            this.dataGridViewLiteral.Size = new System.Drawing.Size(243, 289);
            this.dataGridViewLiteral.TabIndex = 12;
            // 
            // IndexLiteral
            // 
            this.IndexLiteral.HeaderText = "Индекс";
            this.IndexLiteral.Name = "IndexLiteral";
            // 
            // ValueLiteral
            // 
            this.ValueLiteral.HeaderText = "Значение";
            this.ValueLiteral.Name = "ValueLiteral";
            // 
            // classificationLabel
            // 
            this.classificationLabel.AutoSize = true;
            this.classificationLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.classificationLabel.Location = new System.Drawing.Point(277, 19);
            this.classificationLabel.Name = "classificationLabel";
            this.classificationLabel.Size = new System.Drawing.Size(302, 37);
            this.classificationLabel.TabIndex = 11;
            this.classificationLabel.Text = "Классификация лексем";
            // 
            // separatorTB
            // 
            this.separatorTB.AutoSize = true;
            this.separatorTB.Location = new System.Drawing.Point(610, 319);
            this.separatorTB.Name = "separatorTB";
            this.separatorTB.Size = new System.Drawing.Size(76, 15);
            this.separatorTB.TabIndex = 10;
            this.separatorTB.Text = "Разделители";
            // 
            // keyWordTB
            // 
            this.keyWordTB.AutoSize = true;
            this.keyWordTB.Location = new System.Drawing.Point(610, 7);
            this.keyWordTB.Name = "keyWordTB";
            this.keyWordTB.Size = new System.Drawing.Size(100, 15);
            this.keyWordTB.TabIndex = 9;
            this.keyWordTB.Text = "Ключевые слова";
            // 
            // idTB
            // 
            this.idTB.AutoSize = true;
            this.idTB.Location = new System.Drawing.Point(6, 319);
            this.idTB.Name = "idTB";
            this.idTB.Size = new System.Drawing.Size(103, 15);
            this.idTB.TabIndex = 8;
            this.idTB.Text = "Идентификаторы";
            // 
            // leteralTB
            // 
            this.leteralTB.AutoSize = true;
            this.leteralTB.Location = new System.Drawing.Point(6, 7);
            this.leteralTB.Name = "leteralTB";
            this.leteralTB.Size = new System.Drawing.Size(62, 15);
            this.leteralTB.TabIndex = 7;
            this.leteralTB.Text = "Литералы";
            // 
            // buttonGenerealTB
            // 
            this.buttonGenerealTB.Location = new System.Drawing.Point(255, 113);
            this.buttonGenerealTB.Name = "buttonGenerealTB";
            this.buttonGenerealTB.Size = new System.Drawing.Size(349, 50);
            this.buttonGenerealTB.TabIndex = 6;
            this.buttonGenerealTB.Text = "Формирование общей таблицы";
            this.buttonGenerealTB.UseVisualStyleBackColor = true;
            this.buttonGenerealTB.Click += new System.EventHandler(this.GeneralListButton_Click);
            // 
            // buttonFourTB
            // 
            this.buttonFourTB.Location = new System.Drawing.Point(255, 59);
            this.buttonFourTB.Name = "buttonFourTB";
            this.buttonFourTB.Size = new System.Drawing.Size(349, 48);
            this.buttonFourTB.TabIndex = 4;
            this.buttonFourTB.Text = "Распределение по таблицам";
            this.buttonFourTB.UseVisualStyleBackColor = true;
            this.buttonFourTB.Click += new System.EventHandler(this.FourTableBTN_Click);
            // 
            // TranslatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 596);
            this.Controls.Add(this.tabControl1);
            this.Name = "TranslatorForm";
            this.Text = "Транслятор C";
            this.tabControl1.ResumeLayout(false);
            this.tabPageInput.ResumeLayout(false);
            this.tabPageInput.PerformLayout();
            this.tabPageLexical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLexical)).EndInit();
            this.tabPageLexemClass.ResumeLayout(false);
            this.tabPageLexemClass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGeneral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSeparators)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKeyWords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLiteral)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private TabControl tabControl1;
        private TabPage tabPageInput;
        private TabPage tabPageLexemClass;
        private Button buttonFourTB;
        private Button buttonGenerealTB;
        private Label leteralTB;
        private Label classificationLabel;
        private Label separatorTB;
        private Label keyWordTB;
        private Label idTB;
        private TabPage tabPageLexical;
        private DataGridView dataGridViewLexical;
        private DataGridViewTextBoxColumn Type;
        private DataGridViewTextBoxColumn Value;
        private Button startLexicalBTN;
        private DataGridView dataGridViewID;
        private DataGridView dataGridViewLiteral;
        private DataGridView dataGridViewGeneral;
        private DataGridView dataGridViewSeparators;
        private DataGridView dataGridViewKeyWords;
        private DataGridViewTextBoxColumn List;
        private DataGridViewTextBoxColumn IndexSeparator;
        private DataGridViewTextBoxColumn ValueSeparator;
        private DataGridViewTextBoxColumn IndexKeyWord;
        private DataGridViewTextBoxColumn ValueKeyWord;
        private DataGridViewTextBoxColumn IndexID;
        private DataGridViewTextBoxColumn ValueID;
        private DataGridViewTextBoxColumn IndexLiteral;
        private DataGridViewTextBoxColumn ValueLiteral;
        private TextBox inputTB;
        private Button OpenBTN;
    }
}