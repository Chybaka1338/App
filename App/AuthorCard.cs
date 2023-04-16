using System.Text.RegularExpressions;

namespace App
{
    public partial class AuthorCard : Form
    {
        static Author author;
        static MainWindow parrentWindow;
        string pattern = @"(^[а-яА-Я]{3,12} {1}([а-яА-Я]{5,12} ?){2})";

        public AuthorCard(MainWindow form)
        {
            InitializeComponent();

            parrentWindow = form;
            parrentWindow.Hide();

            openFileDialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            //saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";

            buttonConfirmNameBook.Enabled = false;
            buttonOpenFileDialog.Enabled = false;
            buttonAccept.Enabled = false;
        }

        private void buttonConfirmNameAuthor_Click(object sender, EventArgs e)
        {
            if (ValidateNameAuthor(textBoxNameAuthor.Text, buttonConfirmNameAuthor))
            {
                author = new Author(textBoxNameAuthor.Text);
                textBoxNameAuthor.Enabled = false;
                buttonConfirmNameBook.Enabled = true;
                buttonOpenFileDialog.Enabled = true;
                buttonAccept.Enabled = true;
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

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            if (author != null)
            {
                parrentWindow.comboBoxNameAuthors.Items.Add(author);
                parrentWindow.comboBoxNameAuthors.Enabled = true;
                parrentWindow.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            parrentWindow.Show();
            this.Close();
        }

        #region Validating
        internal bool ValidateNameAuthor(string name, Control control)
        {
            if(Regex.IsMatch(name, pattern, RegexOptions.IgnoreCase))
            {
                return true;
            }
            return false;

            //if (String.IsNullOrWhiteSpace(name))
            //{
            //    errorProviderNameAuthor.SetError(control, "Имя не указано!");
            //    return false;
            //}

            //foreach (var c in name)
            //{
            //    if (!Char.IsLetter(c))
            //    {
            //        errorProviderNameAuthor.SetError(control, "Имя не может содержать цифры или спецсимволы!");
            //        return false;
            //    }
            //}

            //if (name.Length < 5 || name.Length > 36)
            //{
            //    errorProviderNameAuthor.SetError(control, "Допустимая длина имени от 5 до 36 символов!");
            //    return false;
            //}
            //else
            //{
            //    errorProviderNameAuthor.Clear();
            //    return true;
            //}
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