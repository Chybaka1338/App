using DynamicStructure;

namespace App
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            InitializeComponent();

            comboBoxNameAuthors.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxNameAuthors.SelectedIndexChanged += comboBoxNameAuthors_SelectedIndexChanged;
            saveFileDialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }

        #region Button
        private void buttonAddNewAuthor_Click(object sender, EventArgs e)
        {
            AuthorCard form = new AuthorCard(this, new Author(""), false);
            form.Show();
        }

        private void buttonEditAuthor_Click(object sender, EventArgs e)
        {
            var form = new AuthorCard(this, comboBoxNameAuthors.SelectedItem as Author, true);
            form.Show();
        }

        private void buttonSaveFileDialog_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel) return;

            var path = saveFileDialog.FileName;
            FileDialog.SaveFile(path, comboBoxNameAuthors.SelectedItem as Author);
            MessageBox.Show("Файл сохранен", "Успешно");
        }

        private void buttonPrintBooks_Click(object sender, EventArgs e)
        {
            var author = comboBoxNameAuthors.SelectedItem as Author;
            richTextBox.Clear();
            richTextBox.AppendText("ФИО: " + author.FullName + "\n");
            richTextBox.AppendText("Список книг:\n");
            foreach (var node in author.SortedBooks.EnumeratesNode())
            {
                richTextBox.AppendText(node.Item + "\n");
            }
        }
        #endregion

        private void comboBoxNameAuthors_SelectedIndexChanged(object sender, EventArgs e)
        {
            var author = comboBoxNameAuthors.SelectedItem as Author;
            buttonEditAuthor.Enabled = true;
            buttonSaveFileDialog.Enabled = author.NumberBooks > 0;
            buttonPrintBooks.Enabled = author.NumberBooks > 0;
        }
    }
}