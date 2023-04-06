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
        private string name;

        private string lastName;

        private LinkedList books;

        public string FullName => name + " " + lastName;
        
        public Author(string name, string lastName)
        {
            this.name = name;
            this.lastName = lastName;
            books = new LinkedList();
        }

        public void AddBook(string book)
        {
            if (IsValidBook(book))
            {
                books.AddLast(book);
            }
        }

        public void RemoveBook(string book)
        {
            if (IsValidBook(book))
            {
                books.Delete(book);
            }
        }

        public LinkedList Books => books.EnumeratesNode().OrderBy(book => book.Item).Select(book => book).;

        private bool IsValidBook(string book)
        {
            if (String.IsNullOrEmpty(book) || books.Find(book).Item.Equals(book))
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