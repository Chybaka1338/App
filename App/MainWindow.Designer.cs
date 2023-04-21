namespace App
{
    partial class MainWindow
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
            saveFileDialog = new SaveFileDialog();
            label1 = new Label();
            buttonAddNewAuthor = new Button();
            comboBoxNameAuthors = new ComboBox();
            label2 = new Label();
            richTextBox = new RichTextBox();
            buttonSaveFileDialog = new Button();
            label5 = new Label();
            label6 = new Label();
            buttonEditAuthor = new Button();
            buttonPrintBooks = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 30);
            label1.Name = "label1";
            label1.Size = new Size(101, 15);
            label1.TabIndex = 18;
            label1.Text = "Добавить Автора";
            // 
            // buttonAddNewAuthor
            // 
            buttonAddNewAuthor.Location = new Point(138, 26);
            buttonAddNewAuthor.Name = "buttonAddNewAuthor";
            buttonAddNewAuthor.Size = new Size(115, 23);
            buttonAddNewAuthor.TabIndex = 19;
            buttonAddNewAuthor.Text = "Добавить";
            buttonAddNewAuthor.UseVisualStyleBackColor = true;
            buttonAddNewAuthor.Click += buttonAddNewAuthor_Click;
            // 
            // comboBoxNameAuthors
            // 
            comboBoxNameAuthors.Enabled = false;
            comboBoxNameAuthors.FormattingEnabled = true;
            comboBoxNameAuthors.Location = new Point(138, 81);
            comboBoxNameAuthors.Name = "comboBoxNameAuthors";
            comboBoxNameAuthors.Size = new Size(200, 23);
            comboBoxNameAuthors.TabIndex = 20;
            comboBoxNameAuthors.SelectedIndexChanged += comboBoxNameAuthors_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 84);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 21;
            label2.Text = "Выбрать Автора";
            // 
            // richTextBox
            // 
            richTextBox.Location = new Point(465, 30);
            richTextBox.Name = "richTextBox";
            richTextBox.ReadOnly = true;
            richTextBox.Size = new Size(249, 276);
            richTextBox.TabIndex = 22;
            richTextBox.Text = "";
            // 
            // buttonSaveFileDialog
            // 
            buttonSaveFileDialog.Enabled = false;
            buttonSaveFileDialog.Location = new Point(138, 128);
            buttonSaveFileDialog.Name = "buttonSaveFileDialog";
            buttonSaveFileDialog.Size = new Size(115, 23);
            buttonSaveFileDialog.TabIndex = 27;
            buttonSaveFileDialog.Text = "Сохранить";
            buttonSaveFileDialog.UseVisualStyleBackColor = true;
            buttonSaveFileDialog.Click += buttonSaveFileDialog_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 132);
            label5.Name = "label5";
            label5.Size = new Size(66, 15);
            label5.TabIndex = 28;
            label5.Text = "Сохранить";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 178);
            label6.Name = "label6";
            label6.Size = new Size(87, 15);
            label6.TabIndex = 30;
            label6.Text = "Редактировать";
            // 
            // buttonEditAuthor
            // 
            buttonEditAuthor.Enabled = false;
            buttonEditAuthor.Location = new Point(138, 174);
            buttonEditAuthor.Name = "buttonEditAuthor";
            buttonEditAuthor.Size = new Size(115, 23);
            buttonEditAuthor.TabIndex = 31;
            buttonEditAuthor.Text = "Редактировать";
            buttonEditAuthor.UseVisualStyleBackColor = true;
            buttonEditAuthor.Click += buttonEditAuthor_Click;
            // 
            // buttonPrintBooks
            // 
            buttonPrintBooks.Enabled = false;
            buttonPrintBooks.Location = new Point(344, 80);
            buttonPrintBooks.Name = "buttonPrintBooks";
            buttonPrintBooks.Size = new Size(115, 23);
            buttonPrintBooks.TabIndex = 32;
            buttonPrintBooks.Text = "Напечатать книги";
            buttonPrintBooks.UseVisualStyleBackColor = true;
            buttonPrintBooks.Click += buttonPrintBooks_Click;
            // 
            // MainWindow
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            ClientSize = new Size(719, 311);
            Controls.Add(buttonPrintBooks);
            Controls.Add(buttonEditAuthor);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(buttonSaveFileDialog);
            Controls.Add(richTextBox);
            Controls.Add(label2);
            Controls.Add(comboBoxNameAuthors);
            Controls.Add(buttonAddNewAuthor);
            Controls.Add(label1);
            Name = "MainWindow";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label5;

        private RichTextBox richTextBox;
        internal ComboBox comboBoxNameAuthors;

        private Button buttonAddNewAuthor;
        internal Button buttonSaveFileDialog;

        private SaveFileDialog saveFileDialog;
        private Button buttonEditAuthor;
        private Label label6;
        private Button buttonPrintBooks;
    }
}