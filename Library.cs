using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
			bool removed = false;
			for (int i = _books.Count - 1; i >= 0; i--)
			{
				if (_books[i] == findBook)
				{
					_books.RemoveAt(i);
					removed = true;
					break;
				}
			}
			return removed;
		}

		public bool Replace(Book oldBook, Book newBook)
		{
			if (newBook == null || oldBook == newBook) return false;

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
