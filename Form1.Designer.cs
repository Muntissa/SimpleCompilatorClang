namespace SimpleCompilatorClang
{
    partial class Form1
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
            this.lexicalAnalysisiTB = new System.Windows.Forms.TextBox();
            this.buttonLB1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageLB1 = new System.Windows.Forms.TabPage();
            this.lexicalAnalysisLabel = new System.Windows.Forms.Label();
            this.tabPageLB2 = new System.Windows.Forms.TabPage();
            this.leteralTB = new System.Windows.Forms.Label();
            this.buttonGenerealTB = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.buttonFourTB = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBoxKeyWord = new System.Windows.Forms.TextBox();
            this.textBoxLiteral = new System.Windows.Forms.TextBox();
            this.idTB = new System.Windows.Forms.Label();
            this.keyWordTB = new System.Windows.Forms.Label();
            this.separatorTB = new System.Windows.Forms.Label();
            this.classificationLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPageLB1.SuspendLayout();
            this.tabPageLB2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lexicalAnalysisiTB
            // 
            this.lexicalAnalysisiTB.Location = new System.Drawing.Point(6, 42);
            this.lexicalAnalysisiTB.Multiline = true;
            this.lexicalAnalysisiTB.Name = "lexicalAnalysisiTB";
            this.lexicalAnalysisiTB.Size = new System.Drawing.Size(354, 625);
            this.lexicalAnalysisiTB.TabIndex = 0;
            // 
            // buttonLB1
            // 
            this.buttonLB1.Location = new System.Drawing.Point(366, 626);
            this.buttonLB1.Name = "buttonLB1";
            this.buttonLB1.Size = new System.Drawing.Size(136, 41);
            this.buttonLB1.TabIndex = 1;
            this.buttonLB1.Text = "Start";
            this.buttonLB1.UseVisualStyleBackColor = true;
            this.buttonLB1.Click += new System.EventHandler(this.buttonLB1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageLB1);
            this.tabControl1.Controls.Add(this.tabPageLB2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1151, 701);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPageLB1
            // 
            this.tabPageLB1.Controls.Add(this.lexicalAnalysisLabel);
            this.tabPageLB1.Controls.Add(this.lexicalAnalysisiTB);
            this.tabPageLB1.Controls.Add(this.buttonLB1);
            this.tabPageLB1.Location = new System.Drawing.Point(4, 24);
            this.tabPageLB1.Name = "tabPageLB1";
            this.tabPageLB1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLB1.Size = new System.Drawing.Size(1143, 673);
            this.tabPageLB1.TabIndex = 0;
            this.tabPageLB1.Text = "LB1";
            this.tabPageLB1.UseVisualStyleBackColor = true;
            // 
            // lexicalAnalysisLabel
            // 
            this.lexicalAnalysisLabel.AutoSize = true;
            this.lexicalAnalysisLabel.Location = new System.Drawing.Point(18, 15);
            this.lexicalAnalysisLabel.Name = "lexicalAnalysisLabel";
            this.lexicalAnalysisLabel.Size = new System.Drawing.Size(120, 15);
            this.lexicalAnalysisLabel.TabIndex = 2;
            this.lexicalAnalysisLabel.Text = "Лексический анализ";
            // 
            // tabPageLB2
            // 
            this.tabPageLB2.Controls.Add(this.classificationLabel);
            this.tabPageLB2.Controls.Add(this.separatorTB);
            this.tabPageLB2.Controls.Add(this.keyWordTB);
            this.tabPageLB2.Controls.Add(this.idTB);
            this.tabPageLB2.Controls.Add(this.leteralTB);
            this.tabPageLB2.Controls.Add(this.buttonGenerealTB);
            this.tabPageLB2.Controls.Add(this.textBox6);
            this.tabPageLB2.Controls.Add(this.buttonFourTB);
            this.tabPageLB2.Controls.Add(this.textBox5);
            this.tabPageLB2.Controls.Add(this.textBox4);
            this.tabPageLB2.Controls.Add(this.textBoxKeyWord);
            this.tabPageLB2.Controls.Add(this.textBoxLiteral);
            this.tabPageLB2.Location = new System.Drawing.Point(4, 24);
            this.tabPageLB2.Name = "tabPageLB2";
            this.tabPageLB2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLB2.Size = new System.Drawing.Size(1143, 673);
            this.tabPageLB2.TabIndex = 1;
            this.tabPageLB2.Text = "LB2";
            this.tabPageLB2.UseVisualStyleBackColor = true;
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
            this.buttonGenerealTB.Location = new System.Drawing.Point(365, 113);
            this.buttonGenerealTB.Name = "buttonGenerealTB";
            this.buttonGenerealTB.Size = new System.Drawing.Size(417, 50);
            this.buttonGenerealTB.TabIndex = 6;
            this.buttonGenerealTB.Text = "Общий список";
            this.buttonGenerealTB.UseVisualStyleBackColor = true;
            this.buttonGenerealTB.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(540, 169);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(76, 474);
            this.textBox6.TabIndex = 5;
            // 
            // buttonFourTB
            // 
            this.buttonFourTB.Location = new System.Drawing.Point(365, 59);
            this.buttonFourTB.Name = "buttonFourTB";
            this.buttonFourTB.Size = new System.Drawing.Size(417, 48);
            this.buttonFourTB.TabIndex = 4;
            this.buttonFourTB.Text = "Распределить по спискам";
            this.buttonFourTB.UseVisualStyleBackColor = true;
            this.buttonFourTB.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(788, 337);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(339, 306);
            this.textBox5.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(6, 337);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(344, 306);
            this.textBox4.TabIndex = 2;
            // 
            // textBoxKeyWord
            // 
            this.textBoxKeyWord.Location = new System.Drawing.Point(788, 25);
            this.textBoxKeyWord.Multiline = true;
            this.textBoxKeyWord.Name = "textBoxKeyWord";
            this.textBoxKeyWord.Size = new System.Drawing.Size(339, 289);
            this.textBoxKeyWord.TabIndex = 1;
            // 
            // textBoxLiteral
            // 
            this.textBoxLiteral.Location = new System.Drawing.Point(6, 25);
            this.textBoxLiteral.Multiline = true;
            this.textBoxLiteral.Name = "textBoxLiteral";
            this.textBoxLiteral.Size = new System.Drawing.Size(344, 289);
            this.textBoxLiteral.TabIndex = 0;
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
            // keyWordTB
            // 
            this.keyWordTB.AutoSize = true;
            this.keyWordTB.Location = new System.Drawing.Point(788, 7);
            this.keyWordTB.Name = "keyWordTB";
            this.keyWordTB.Size = new System.Drawing.Size(100, 15);
            this.keyWordTB.TabIndex = 9;
            this.keyWordTB.Text = "Ключевые слова";
            // 
            // separatorTB
            // 
            this.separatorTB.AutoSize = true;
            this.separatorTB.Location = new System.Drawing.Point(788, 319);
            this.separatorTB.Name = "separatorTB";
            this.separatorTB.Size = new System.Drawing.Size(76, 15);
            this.separatorTB.TabIndex = 10;
            this.separatorTB.Text = "Разделители";
            // 
            // classificationLabel
            // 
            this.classificationLabel.AutoSize = true;
            this.classificationLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.classificationLabel.Location = new System.Drawing.Point(426, 10);
            this.classificationLabel.Name = "classificationLabel";
            this.classificationLabel.Size = new System.Drawing.Size(302, 37);
            this.classificationLabel.TabIndex = 11;
            this.classificationLabel.Text = "Классификация лексем";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 725);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPageLB1.ResumeLayout(false);
            this.tabPageLB1.PerformLayout();
            this.tabPageLB2.ResumeLayout(false);
            this.tabPageLB2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox lexicalAnalysisiTB;
        private Button buttonLB1;
        private TabControl tabControl1;
        private TabPage tabPageLB1;
        private TabPage tabPageLB2;
        private Button buttonFourTB;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBoxKeyWord;
        private TextBox textBoxLiteral;
        private TextBox textBox6;
        private Button buttonGenerealTB;
        private Label lexicalAnalysisLabel;
        private Label leteralTB;
        private Label classificationLabel;
        private Label separatorTB;
        private Label keyWordTB;
        private Label idTB;
    }
}