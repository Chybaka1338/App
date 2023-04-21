using DynamicStructure;
using System.Text.RegularExpressions;

namespace App
{
    public partial class AuthorCard : Form
    {
        private static Author author;

        private static MainWindow parrentWindow;

        private static Regex regex = new Regex("(^[А-Я]{1}[а-я]{3,11} {1}([А-Я]{1}[а-яА-Я]{3,11} ?){2})");

        private bool editMode = false;

        public AuthorCard(MainWindow form, Author currentAuthor, bool editMode)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            InitializeComponent();
            this.editMode = editMode;
            comboBoxBookTitles.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxBookTitles.DataSourceChanged += comboBoxBookTitles_DataSourceChanged;
            openFileDialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";

            parrentWindow = form;
            author = currentAuthor;

            if (editMode) SetControls();
        }

        #region Buttons
        private void buttonConfirmAuthor_Click(object sender, EventArgs e)
        {
            if (!ValidateNameAuthor(textBoxFullNameAuthor.Text))
            {
                errorProvider.SetError(sender as Control, "ФИО указано не верно!");
                return;
            }
            errorProvider.Clear();

            author.FullName = textBoxFullNameAuthor.Text;
            SetControls();
        }

        private void buttonConfirmBookTitle_Click(object sender, EventArgs e)
        {
            if (!ValidateNameBook(textBoxTitleBook.Text))
            {
                errorProvider.SetError(sender as Control, "Название книги указано не верно!");
                return;
            }

            if (!author.AddBook(textBoxTitleBook.Text))
            {
                textBoxTitleBook.Clear();
                errorProvider.SetError(sender as Control, "Данная книга уже содержится коллекции!");
                return;
            }
            errorProvider.Clear();

            comboBoxBookTitles.Items.Add(textBoxTitleBook.Text);
            comboBoxBookTitles_DataSourceChanged(sender, e);
            textBoxTitleBook.Clear();
        }

        private void buttonRemoveBook_Click(object sender, EventArgs e)
        {
            if (comboBoxBookTitles.SelectedItem == null)
            {
                errorProvider.SetError(sender as Control, "Выберите книгу");
                return;
            }
            errorProvider.Clear();

            author.RemoveBook(comboBoxBookTitles.SelectedItem.ToString());
            comboBoxBookTitles.Items.Remove(comboBoxBookTitles.SelectedItem);
            comboBoxBookTitles_DataSourceChanged(sender, e);
        }

        private void buttonOpenFileDialog_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel) return;

            var path = openFileDialog.FileName;
            FileDialog.ReadFromFile(path, author, comboBoxBookTitles);

            comboBoxBookTitles_DataSourceChanged(sender, e);
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            if (!editMode)
            {
                parrentWindow.comboBoxNameAuthors.Items.Add(author);
                parrentWindow.comboBoxNameAuthors.Enabled = true;
            }
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Validating
        private static bool ValidateNameAuthor(string name)
        {
            return regex.IsMatch(name);
        }

        internal static bool ValidateNameBook(string title)
        {
            return !(String.IsNullOrWhiteSpace(title) | title.Length > 36);
        }
        #endregion

        #region Controls
        private void SetControls()
        {
            textBoxFullNameAuthor.Text = author.FullName;
            textBoxFullNameAuthor.Enabled = false;
            buttonConfirmAuthor.Enabled = false;

            textBoxTitleBook.Enabled = true;
            buttonConfirmTitleBook.Enabled = true;
            buttonOpenFileDialog.Enabled = true;
            buttonAccept.Enabled = true;
            if (comboBoxBookTitles.Enabled = (author.NumberBooks != 0))
            {
                foreach (var node in author.SortedBooks.EnumeratesNode())
                {
                    comboBoxBookTitles.Items.Add(node.Item);
                }
                buttonRemoveBook.Enabled = true;
            }
        }

        private void comboBoxBookTitles_DataSourceChanged(object sender, EventArgs e)
        {
            if(comboBoxBookTitles.Enabled = (comboBoxBookTitles.Items.Count > 0))
            {
                comboBoxBookTitles.Update();
                buttonRemoveBook.Enabled = true;
            }
            else
            {
                comboBoxBookTitles.Update();
                buttonRemoveBook.Enabled = false;
            }
        }
        #endregion
    }
}