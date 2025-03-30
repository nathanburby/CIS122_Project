using CIS122_Project;

internal class Program
{
	private static void Main(string[] args)
	{
		// Create Library and Checkout System instances
		Library library = new Library();
		CheckoutReturn checkoutSystem = new CheckoutReturn();

		// Create books
		Book book1 = new Book("Book One", "Author A", "ISBN-1111", 2001);
		Book book2 = new Book("Book Two", "Author B", "ISBN-2222", 2002);
		Book book3 = new Book("Book Three", "Author C", "ISBN-3333", 2003);

		Console.WriteLine("==== STARTING LIBRARY & CHECKOUT SYSTEM TESTING ====\n");

		// 🟢 TEST: Add Books
		Console.WriteLine("Adding books...");
		library.AddBook(book1);
		library.AddBook(book2);
		Console.WriteLine("✅ Books added successfully!\n");

		// Register books in the checkout system
		checkoutSystem.RegisterBook(book1);
		checkoutSystem.RegisterBook(book2);

		// 🔴 TEST: Delete an existing book
		Console.WriteLine("Deleting Book Two...");
		bool deleted = library.DeleteBook(book2);
		Console.WriteLine($"✅ Book deleted: {deleted} (Expected: True)\n");

		// 🔴 TEST: Delete a non-existing book
		Console.WriteLine("Deleting Book Three (which was never added)...");
		deleted = library.DeleteBook(book3);
		Console.WriteLine($"✅ Book deleted: {deleted} (Expected: False)\n");

		// 🟡 TEST: Replace a book successfully
		Console.WriteLine("Replacing Book One with Book Three...");
		bool replaced = library.Replace(book1, book3);
		Console.WriteLine($"✅ Book replaced: {replaced} (Expected: True)\n");

		// 🟡 TEST: Replace a non-existing book
		Console.WriteLine("Trying to replace Book Two (which was deleted) with Book One...");
		replaced = library.Replace(book2, book1);
		Console.WriteLine($"✅ Book replaced: {replaced} (Expected: False)\n");

		// 🟠 TEST: Checkout a book successfully
		Console.WriteLine("Checking out Book Three...");
		bool checkedOut = checkoutSystem.CheckoutBook(book3);
		Console.WriteLine($"✅ Book checked out: {checkedOut} (Expected: True)\n");

		// 🟠 TEST: Attempt to checkout a book already checked out
		Console.WriteLine("Trying to check out Book Three again...");
		checkedOut = checkoutSystem.CheckoutBook(book3);
		Console.WriteLine($"✅ Book checked out: {checkedOut} (Expected: False)\n");

		// 🔵 TEST: Return a checked-out book
		Console.WriteLine("Returning Book Three...");
		bool returned = checkoutSystem.ReturnBook(book3);
		Console.WriteLine($"✅ Book returned: {returned} (Expected: True)\n");

		// 🔵 TEST: Attempt to return a book that was never checked out
		Console.WriteLine("Trying to return Book Two (which was deleted)...");
		returned = checkoutSystem.ReturnBook(book2);
		Console.WriteLine($"✅ Book returned: {returned} (Expected: False)\n");

		// 🟣 TEST: Checking if a book is checked out
		Console.WriteLine("Checking out Book Three again...");
		checkoutSystem.CheckoutBook(book3);
		Console.WriteLine("Checking if Book Three is checked out...");
		bool isCheckedOut = checkoutSystem.IsCheckedOut(book3);
		Console.WriteLine($"✅ Book Three checked out status: {isCheckedOut} (Expected: True)\n");

		// 🟤 TEST: Listing checked-out books
		Console.WriteLine("Currently checked out books:");
		List<Book> checkedOutBooks = checkoutSystem.GetCheckedOutBooks();
		foreach (var book in checkedOutBooks)
		{
			Console.WriteLine($"📖 - {book._title}");
		}
		Console.WriteLine("✅ Checked-out books listed successfully!\n");

		Console.WriteLine("==== LIBRARY & CHECKOUT SYSTEM TESTING COMPLETED ====");
	}
}