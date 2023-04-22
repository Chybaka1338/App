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
            StringBuilder message = new StringBuilder();

            using (var reader = new StreamReader(path, Encoding.UTF8))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (!AuthorCard.ValidateNameBook(line))
                    {
                        message.AppendLine($"Не правильно указанное название книги: \"{line}\"\n");
                        missed++;
                        continue;
                    }

                    if (author.AddBook(line))
                    {
                        box.Items.Add(line);
                        continue;
                    }

                    message.Append($"Данная книга уже содержится в коллекции: \"{line}\"\n");
                    missed++;
                    isPassed = false;
                }
            }

            PrintMessage(isPassed, missed, message);
        }

        private static void PrintMessage(bool isPassed, int missed, StringBuilder message)
        {
            if (!isPassed)
            {
                MessageBox.Show(message.ToString(), "Внимание!");
            }
            else
            {
                MessageBox.Show("Книги были добавлены", "Успешно");
            }
        }

        internal static void SaveFile(string path, Author author)
        {
            using (var writer = new StreamWriter(path, true, Encoding.UTF8))
            {
                writer.WriteLine($"ФИО: {author.FullName}\nСписок книг в алфавитном порядке:");
                foreach (var book in author.SortedBooks.EnumeratesNode())
                {
                    writer.WriteLine(book.Item);
                }
            }
            MessageBox.Show("Файл сохранен", "Успешно");
        }
    }
}