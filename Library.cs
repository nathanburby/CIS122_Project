using System.Collections.Generic;

namespace CIS122_Project
{
	using System.Collections.Generic;

	namespace CIS122_Project
	{
		public class Library
		{
			public List<Book> _books;

			public Library()
			{
				_books = new List<Book>();
			}

			public void AddBook(Book newBook)
			{
				_books.Add(newBook);
			}

			public bool DeleteBook(Book findBook)
			{
				for (int i = _books.Count - 1; i >= 0; i--)
				{
					if (_books[i].Equals(findBook))
					{
						_books.RemoveAt(i);
						return true;
					}
				}
				return false;
			}

			public bool Replace(Book oldBook, Book newBook)
			{
				if (newBook == null) return false;

				int index = _books.IndexOf(oldBook);
				if (index != -1)
				{
					_books[index] = newBook;
					return true;
				}
				return false;
			}
		}
	}
}