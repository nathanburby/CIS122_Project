using System.Collections.Generic;
using System.Linq;

namespace CIS122_Project
{
	public class BookCheckoutSystem
	{
		private HashSet<Book> _checkedOutBooks = new HashSet<Book>();
		private HashSet<Book> _registeredBooks = new HashSet<Book>();

		public void RegisterBook(Book book)
		{
			_registeredBooks.Add(book);
		}

		public bool CheckoutBook(Book book)
		{
			if (!_registeredBooks.Contains(book) || _checkedOutBooks.Contains(book))
				return false;

			_checkedOutBooks.Add(book);
			return true;
		}

		public bool ReturnBook(Book book)
		{
			return _checkedOutBooks.Remove(book);
		}

		public bool IsCheckedOut(Book book)
		{
			return _checkedOutBooks.Contains(book);
		}

		public List<Book> GetCheckedOutBooks()
		{
			return _checkedOutBooks.ToList();
		}
	}
}