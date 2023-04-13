using DynamicStructure;
using System.Text;

namespace App
{
    internal static class FileDialog
    {
        internal static void ReadFromFile(string path, Author author)
        {
            int missed = 0;
            bool isPassed = true;
            LinkedList list = new LinkedList();

            using (var reader = new StreamReader(path, Encoding.UTF8))
            {
                string line; 
                while((line = reader.ReadLine()) != null)
                {
                    if (Validate(line))
                    {
                        if (author.AddBook(line) == false)
                        {
                            list.AddLast(line);
                            missed++;
                            isPassed = false;
                        }
                    }
                    else
                    {
                        missed++;
                    }
                }
            }

            if(!isPassed)
            {
                StringBuilder message = new StringBuilder();
                message.AppendLine($"Было пропущено {missed}. {(missed > 1 ? "Они" : "Она")} уже есть в коллекции книг!");
                foreach(var node in list.EnumeratesNode())
                {
                    message.AppendLine("Название: " + node.Item);   
                }
                MessageBox.Show(message.ToString());
            }
        }

        internal static bool Validate(string line)
        {
            if(String.IsNullOrWhiteSpace(line))
            {
                return false;
            }
            else if(line.Length > 36)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}