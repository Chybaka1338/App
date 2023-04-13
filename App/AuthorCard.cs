using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class AuthorCard : Form
    {
        static Author author;

        public AuthorCard()
        {
            InitializeComponent();

            openFileDialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            //saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";

            buttonConfirmNameBook.Enabled = false;
            buttonOpenFileDialog.Enabled = false;
        }

        private void buttonConfirmNameAuthor_Click(object sender, EventArgs e)
        {
            if (ValidateNameAuthor(textBoxNameAuthor.Text, buttonConfirmNameAuthor))
            {
                author = new Author(textBoxNameAuthor.Text);
                textBoxNameAuthor.Enabled = false;
                buttonConfirmNameBook.Enabled = true;
                buttonOpenFileDialog.Enabled = true;
            }
        }

        private void buttonConfirmNameBook_Click(object sender, EventArgs e)
        {
            if (ValidateNameBook(textBoxNameBook.Text, buttonConfirmNameBook))
            {
                if (author.AddBook(textBoxNameBook.Text))
                {
                    textBoxNameBook.Text = string.Empty;
                    MessageBox.Show("Книга была добавлена!");
                }
                else
                {
                    MessageBox.Show("Данная книга уже содержится в списке!");
                }
            }
        }

        private void buttonOpenFileDialog_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            var path = openFileDialog.FileName;
            FileDialog.ReadFromFile(path, author);
        }

        #region Validating
        internal bool ValidateNameAuthor(string name, Control control)
        {
            if (String.IsNullOrWhiteSpace(name))
            {
                errorProviderNameAuthor.SetError(control, "Имя не указано!");
                return false;
            }

            foreach (var c in name)
            {
                if (!Char.IsLetter(c))
                {
                    errorProviderNameAuthor.SetError(control, "Имя не может содержать цифры или спецсимволы!");
                    return false;
                }
            }

            if (name.Length < 5 || name.Length > 36)
            {
                errorProviderNameAuthor.SetError(control, "Допустимая длина имени от 5 до 36 символов!");
                return false;
            }
            else
            {
                errorProviderNameAuthor.Clear();
                return true;
            }
        }

        internal bool ValidateNameBook(string name, Control control)
        {
            if (String.IsNullOrWhiteSpace(name))
            {
                errorProviderNameBook.SetError(control, "Название книги не указано!");
                return false;
            }
            else if (name.Length > 36)
            {
                errorProviderNameBook.SetError(control, "Допустимая длина от 1 до 36 символов!");
                return false;
            }
            else
            {
                errorProviderNameBook.Clear();
                return true;
            }
        }
        #endregion
    }
}