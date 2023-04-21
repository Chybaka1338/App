namespace App
{
    partial class AuthorCard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            openFileDialog = new OpenFileDialog();
            textBoxFullNameAuthor = new TextBox();
            textBoxTitleBook = new TextBox();
            buttonConfirmAuthor = new Button();
            buttonConfirmTitleBook = new Button();
            label1 = new Label();
            label2 = new Label();
            buttonAccept = new Button();
            buttonCancel = new Button();
            errorProvider = new ErrorProvider(components);
            comboBoxBookTitles = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            buttonOpenFileDialog = new Button();
            buttonRemoveBook = new Button();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            // 
            // textBoxFullNameAuthor
            // 
            textBoxFullNameAuthor.Location = new Point(117, 12);
            textBoxFullNameAuthor.Name = "textBoxFullNameAuthor";
            textBoxFullNameAuthor.Size = new Size(200, 23);
            textBoxFullNameAuthor.TabIndex = 0;
            // 
            // textBoxTitleBook
            // 
            textBoxTitleBook.Enabled = false;
            textBoxTitleBook.Location = new Point(117, 63);
            textBoxTitleBook.Name = "textBoxTitleBook";
            textBoxTitleBook.Size = new Size(200, 23);
            textBoxTitleBook.TabIndex = 1;
            // 
            // buttonConfirmAuthor
            // 
            buttonConfirmAuthor.Location = new Point(337, 12);
            buttonConfirmAuthor.Name = "buttonConfirmAuthor";
            buttonConfirmAuthor.Size = new Size(115, 23);
            buttonConfirmAuthor.TabIndex = 2;
            buttonConfirmAuthor.Text = "Подтвердить";
            buttonConfirmAuthor.UseVisualStyleBackColor = true;
            buttonConfirmAuthor.Click += buttonConfirmAuthor_Click;
            // 
            // buttonConfirmTitleBook
            // 
            buttonConfirmTitleBook.Enabled = false;
            buttonConfirmTitleBook.Location = new Point(337, 63);
            buttonConfirmTitleBook.Name = "buttonConfirmTitleBook";
            buttonConfirmTitleBook.Size = new Size(115, 23);
            buttonConfirmTitleBook.TabIndex = 3;
            buttonConfirmTitleBook.Text = "Добавить";
            buttonConfirmTitleBook.UseVisualStyleBackColor = true;
            buttonConfirmTitleBook.Click += buttonConfirmBookTitle_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 16);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 4;
            label1.Text = "ФИО Автора";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 67);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 5;
            label2.Text = "Название книги";
            // 
            // buttonAccept
            // 
            buttonAccept.Enabled = false;
            buttonAccept.Location = new Point(314, 235);
            buttonAccept.Name = "buttonAccept";
            buttonAccept.Size = new Size(115, 23);
            buttonAccept.TabIndex = 6;
            buttonAccept.Text = "Принять";
            buttonAccept.UseVisualStyleBackColor = true;
            buttonAccept.Click += buttonAccept_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(435, 235);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(115, 23);
            buttonCancel.TabIndex = 7;
            buttonCancel.Text = "Отменить";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // comboBoxBookTitles
            // 
            comboBoxBookTitles.Enabled = false;
            comboBoxBookTitles.FormattingEnabled = true;
            comboBoxBookTitles.Location = new Point(117, 114);
            comboBoxBookTitles.Name = "comboBoxBookTitles";
            comboBoxBookTitles.Size = new Size(200, 23);
            comboBoxBookTitles.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 117);
            label3.Name = "label3";
            label3.Size = new Size(85, 15);
            label3.TabIndex = 9;
            label3.Text = "Удалить книгу";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 171);
            label4.Name = "label4";
            label4.Size = new Size(86, 15);
            label4.TabIndex = 10;
            label4.Text = "Открыть файл";
            // 
            // buttonOpenFileDialog
            // 
            buttonOpenFileDialog.Enabled = false;
            buttonOpenFileDialog.Location = new Point(117, 167);
            buttonOpenFileDialog.Name = "buttonOpenFileDialog";
            buttonOpenFileDialog.Size = new Size(115, 23);
            buttonOpenFileDialog.TabIndex = 11;
            buttonOpenFileDialog.Text = "Открыть";
            buttonOpenFileDialog.UseVisualStyleBackColor = true;
            buttonOpenFileDialog.Click += buttonOpenFileDialog_Click;
            // 
            // buttonRemoveBook
            // 
            buttonRemoveBook.Enabled = false;
            buttonRemoveBook.Location = new Point(337, 113);
            buttonRemoveBook.Name = "buttonRemoveBook";
            buttonRemoveBook.Size = new Size(115, 23);
            buttonRemoveBook.TabIndex = 12;
            buttonRemoveBook.Text = "Удалить";
            buttonRemoveBook.UseVisualStyleBackColor = true;
            buttonRemoveBook.Click += buttonRemoveBook_Click;
            // 
            // AuthorCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 270);
            Controls.Add(buttonRemoveBook);
            Controls.Add(buttonOpenFileDialog);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(comboBoxBookTitles);
            Controls.Add(buttonCancel);
            Controls.Add(buttonAccept);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonConfirmTitleBook);
            Controls.Add(buttonConfirmAuthor);
            Controls.Add(textBoxTitleBook);
            Controls.Add(textBoxFullNameAuthor);
            Name = "AuthorCard";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private OpenFileDialog openFileDialog;
        private TextBox textBoxFullNameAuthor;
        private TextBox textBoxTitleBook;
        private Button buttonConfirmAuthor;
        private Button buttonConfirmTitleBook;
        private Label label1;
        private Label label2;
        private Button buttonAccept;
        private Button buttonCancel;
        private ErrorProvider errorProvider;
        private ComboBox comboBoxBookTitles;
        private Label label3;
        private Button buttonOpenFileDialog;
        private Label label4;
        private Button buttonRemoveBook;
    }
}