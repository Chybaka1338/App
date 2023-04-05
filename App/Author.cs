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

        private bool IsValidBook(string book)
        {
            if (String.IsNullOrEmpty(book))
            {
                return false;
            }
            else if (books.Find(book).Item.Equals(book))
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