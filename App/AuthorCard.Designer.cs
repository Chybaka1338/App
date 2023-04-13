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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            buttonConfirmNameAuthor = new Button();
            buttonConfirmNameBook = new Button();
            buttonOpenFileDialog = new Button();
            button4 = new Button();
            textBoxNameAuthor = new TextBox();
            textBoxNameBook = new TextBox();
            button5 = new Button();
            errorProviderNameAuthor = new ErrorProvider(components);
            errorProviderNameBook = new ErrorProvider(components);
            openFileDialog = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)errorProviderNameAuthor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderNameBook).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 41);
            label1.Name = "label1";
            label1.Size = new Size(117, 15);
            label1.TabIndex = 0;
            label1.Text = "Введите имя Автора";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 92);
            label2.Name = "label2";
            label2.Size = new Size(138, 15);
            label2.TabIndex = 1;
            label2.Text = "Введите название книги";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 149);
            label3.Name = "label3";
            label3.Size = new Size(86, 15);
            label3.TabIndex = 2;
            label3.Text = "Выбрать файл";
            // 
            // buttonConfirmNameAuthor
            // 
            buttonConfirmNameAuthor.Location = new Point(340, 37);
            buttonConfirmNameAuthor.Name = "buttonConfirmNameAuthor";
            buttonConfirmNameAuthor.Size = new Size(115, 23);
            buttonConfirmNameAuthor.TabIndex = 3;
            buttonConfirmNameAuthor.Text = "Подтвердить";
            buttonConfirmNameAuthor.UseVisualStyleBackColor = true;
            buttonConfirmNameAuthor.Click += buttonConfirmNameAuthor_Click;
            // 
            // buttonConfirmNameBook
            // 
            buttonConfirmNameBook.Location = new Point(340, 88);
            buttonConfirmNameBook.Name = "buttonConfirmNameBook";
            buttonConfirmNameBook.Size = new Size(115, 23);
            buttonConfirmNameBook.TabIndex = 4;
            buttonConfirmNameBook.Text = "Подтвердить";
            buttonConfirmNameBook.UseVisualStyleBackColor = true;
            buttonConfirmNameBook.Click += buttonConfirmNameBook_Click;
            // 
            // buttonOpenFileDialog
            // 
            buttonOpenFileDialog.Location = new Point(178, 145);
            buttonOpenFileDialog.Name = "buttonOpenFileDialog";
            buttonOpenFileDialog.Size = new Size(115, 23);
            buttonOpenFileDialog.TabIndex = 5;
            buttonOpenFileDialog.Text = "Открыть";
            buttonOpenFileDialog.UseVisualStyleBackColor = true;
            buttonOpenFileDialog.Click += buttonOpenFileDialog_Click;
            // 
            // button4
            // 
            button4.Location = new Point(435, 235);
            button4.Name = "button4";
            button4.Size = new Size(115, 23);
            button4.TabIndex = 6;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // textBoxNameAuthor
            // 
            textBoxNameAuthor.Location = new Point(178, 38);
            textBoxNameAuthor.Name = "textBoxNameAuthor";
            textBoxNameAuthor.Size = new Size(156, 23);
            textBoxNameAuthor.TabIndex = 7;
            // 
            // textBoxNameBook
            // 
            textBoxNameBook.Location = new Point(178, 89);
            textBoxNameBook.Name = "textBoxNameBook";
            textBoxNameBook.Size = new Size(156, 23);
            textBoxNameBook.TabIndex = 8;
            // 
            // button5
            // 
            button5.Location = new Point(314, 235);
            button5.Name = "button5";
            button5.Size = new Size(115, 23);
            button5.TabIndex = 9;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // errorProviderNameAuthor
            // 
            errorProviderNameAuthor.ContainerControl = this;
            // 
            // errorProviderNameBook
            // 
            errorProviderNameBook.ContainerControl = this;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog1";
            // 
            // AuthorCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 270);
            Controls.Add(button5);
            Controls.Add(textBoxNameBook);
            Controls.Add(textBoxNameAuthor);
            Controls.Add(button4);
            Controls.Add(buttonOpenFileDialog);
            Controls.Add(buttonConfirmNameBook);
            Controls.Add(buttonConfirmNameAuthor);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AuthorCard";
            ((System.ComponentModel.ISupportInitialize)errorProviderNameAuthor).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderNameBook).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button5;
        private TextBox textBoxNameBook;
        private TextBox textBoxNameAuthor;
        private Button button4;
        private Button buttonOpenFileDialog;
        private Button buttonConfirmNameBook;
        private Button buttonConfirmNameAuthor;
        private Label label3;
        private Label label2;
        private Label label1;
        private ErrorProvider errorProviderNameAuthor;
        private ErrorProvider errorProviderNameBook;
        private OpenFileDialog openFileDialog;
    }
}