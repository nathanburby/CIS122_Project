using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS122_Project
{
    class CheckoutReturn
    {
		private Dictionary<Book, bool> _checkoutStatus; // Tracks book availability (true = checked out, false = available)

		public CheckoutReturn()
		{
			_checkoutStatus = new Dictionary<Book, bool>();
		}

		// Register a book in the system (should be called when adding a book to the library)
		public void RegisterBook(Book book)
		{
			if (!_checkoutStatus.ContainsKey(book))
			{
				_checkoutStatus[book] = false; // Default to available
			}
		}

		// Checkout a book
		public bool CheckoutBook(Book book)
		{
			if (_checkoutStatus.ContainsKey(book) && !_checkoutStatus[book])
			{
				_checkoutStatus[book] = true; // Mark as checked out
				return true;
			}
			return false; // Book not available or doesn't exist
		}

		// Return a book
		public bool ReturnBook(Book book)
		{
			if (_checkoutStatus.ContainsKey(book) && _checkoutStatus[book])
			{
				_checkoutStatus[book] = false; // Mark as available
				return true;
			}
			return false; // Book was not checked out or doesn't exist
		}

		// Check if a book is currently checked out
		public bool IsCheckedOut(Book book)
		{
			return _checkoutStatus.ContainsKey(book) && _checkoutStatus[book];
		}

		// List all checked-out books
		public List<Book> GetCheckedOutBooks()
		{
			List<Book> checkedOutBooks = new List<Book>();
			foreach (var entry in _checkoutStatus)
			{
				if (entry.Value) // If the book is checked out
				{
					checkedOutBooks.Add(entry.Key);
				}
			}
			return checkedOutBooks;
		}
	}
}
