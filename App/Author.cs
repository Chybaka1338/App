using DynamicStructure;

namespace App
{
    public class Author
    {
        private LinkedList books;

        public string FullName { get; set; }

        public int NumberBooks => books.Count;

        public LinkedList SortedBooks => books.EnumeratesNode().OrderBy(book => book.Item).Select(book => book).ToLinkedList();

        public Author(string fullName)
        {
            FullName = fullName;
            books = new LinkedList();
        }

        public bool AddBook(string book)
        {
            if(IsContained(book))
            {
                return false;
            }

            books.AddLast(book);
            return true;
        }

        public bool RemoveBook(string book)
        {
            if(!IsContained(book))
            {
                return false;
            }

            books.Delete(book);
            return true;
        }

        private bool IsContained(string book)
        {
            if(books.Find(book) == null)
            {
                return false;
            }

            return true;
        }

        override
        public string ToString()
        {
            return FullName;
        }
    }
}