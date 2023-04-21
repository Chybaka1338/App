using DynamicStructure;
using System.Text;

namespace App
{
    internal static class FileDialog
    {
        internal static void ReadFromFile(string path, Author author, ComboBox box)
        {
            int missed = 0;
            bool isPassed = true;
            LinkedList list = new LinkedList();

            using (var reader = new StreamReader(path, Encoding.UTF8))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (!AuthorCard.ValidateNameBook(line))
                    {
                        continue;
                    }

                    if (author.AddBook(line))
                    {
                        box.Items.Add(line);
                        continue;
                    }

                    list.AddLast(line);
                    missed++;
                    isPassed = false;
                }
            }

            PrintMessage(isPassed, missed, list);
        }

        private static void PrintMessage(bool isPassed, int missed, LinkedList list)
        {
            if (!isPassed)
            {
                StringBuilder message = new StringBuilder();
                message.AppendLine("Часть или вся коллекция книг не была добавлена");
                message.AppendLine($"Было пропущено {missed}. {(missed > 1 ? "Они" : "Она")} уже есть в коллекции книг!");
                foreach (var node in list.EnumeratesNode())
                {
                    message.AppendLine("Название: " + node.Item);
                }
                MessageBox.Show(message.ToString(), "Внимание!");
            }
            else
            {
                MessageBox.Show("Книги были добавлены", "Успешно");
            }
        }

        internal static void SaveFile(string path, Author author)
        {
            if (!File.Exists(path))
            {
                MessageBox.Show("Файл не найден!");
                return;
            }

            bool append = File.ReadAllLines(path, Encoding.UTF8).Length > 0;
            using (var writer = new StreamWriter(path, append, Encoding.UTF8))
            {
                writer.WriteLine($"ФИО: {author.FullName}\nСписок книг в алфавитном порядке:");
                foreach (var book in author.SortedBooks.EnumeratesNode())
                {
                    writer.WriteLine(book.Item);
                }
            }
        }
    }
}