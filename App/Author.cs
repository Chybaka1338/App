using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DynamicStructure;

namespace App
{
    internal class Author
    {
        private LinkedList books;

        private string fullName;

        public string FullName => fullName;

        public LinkedList SortedBooks => books.EnumeratesNode().OrderBy(book => book.Item).Select(book => book).ToLinkedList();

        public Author(string fullName)
        {
            this.fullName = fullName;
            books = new LinkedList();
        }

        public Author(string fullName, string path)
        {
            this.fullName = fullName;
            books = new LinkedList();
            using (var reader = new StreamReader(path, Encoding.UTF8))
            {
                string line;
                while((line = reader.ReadLine()) != null)
                {
                    books.AddLast(line);
                }
            }
        }

        public bool AddBook(string book)
        {
            if (Validate(book))
            {
                books.AddLast(book);
                return true;
            }
            return false;
        }

        public bool RemoveBook(string book)
        {
            if (Validate(book))
            {
                books.Delete(book);
                return true;
            }
            return false;
        }

        private bool Validate(string book)
        {
            try
            {
                if(String.IsNullOrWhiteSpace(book) || books.Find(book) != null)
                {
                    return false;
                }
            } 
            catch (Exception ex)
            {
                books.AddLast(book);
            }
            return true;
        }
    }
}