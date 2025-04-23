using CIS122_Project.CIS122_Project;

namespace CIS122_Project
{
	class Program
	{
		static void Main(string[] args)
		{
			Library library = new Library();
			BookCheckoutSystem checkoutSystem = new BookCheckoutSystem();

			// Create shared book instances
			Book book1 = new Book("The Hobbit", "J.R.R. Tolkien", "ISBN-1111", 1937);
			Book book2 = new Book("1984", "George Orwell", "ISBN-2222", 1949);
			Book book3 = new Book("To Kill a Mockingbird", "Harper Lee", "ISBN-3333", 1960);
			Book book4 = new Book("Brave New World", "Aldous Huxley", "ISBN-4444", 1932);

			Console.WriteLine("=== 📚 Welcome to the Library System Test ===\n");

			Console.WriteLine("1️⃣ Adding books to library...");
			library.AddBook(book1);
			library.AddBook(book2);
			library.AddBook(book3);
			Console.WriteLine("✅ Books added.\n");

			Console.WriteLine("2️⃣ Deleting '1984' from library...");
			bool deleted = library.DeleteBook(book2);
			Console.WriteLine($"✅ Deleted: {deleted} (Expected: True)\n");

			Console.WriteLine("3️⃣ Attempting to delete 'Brave New World' (not in library)...");
			deleted = library.DeleteBook(book4);
			Console.WriteLine($"✅ Deleted: {deleted} (Expected: False)\n");

			Console.WriteLine("4️⃣ Replacing 'The Hobbit' with 'Brave New World'...");
			bool replaced = library.Replace(book1, book4);
			Console.WriteLine($"✅ Replaced: {replaced} (Expected: True)\n");

			Console.WriteLine("5️⃣ Attempting to replace '1984' (already deleted) with 'To Kill a Mockingbird'...");
			replaced = library.Replace(book2, book3);
			Console.WriteLine($"✅ Replaced: {replaced} (Expected: False)\n");

			Console.WriteLine("📦 Registering books to checkout system...");
			checkoutSystem.RegisterBook(book3);
			checkoutSystem.RegisterBook(book4);
			Console.WriteLine("✅ Registered.\n");

			Console.WriteLine("6️⃣ Checking out 'Brave New World'...");
			bool checkedOut = checkoutSystem.CheckoutBook(book4);
			Console.WriteLine($"✅ Checked out: {checkedOut} (Expected: True)\n");

			Console.WriteLine("7️⃣ Attempting to check out 'Brave New World' again...");
			checkedOut = checkoutSystem.CheckoutBook(book4);
			Console.WriteLine($"✅ Checked out: {checkedOut} (Expected: False)\n");

			Console.WriteLine("8️⃣ Returning 'Brave New World'...");
			bool returned = checkoutSystem.ReturnBook(book4);
			Console.WriteLine($"✅ Returned: {returned} (Expected: True)\n");

			Console.WriteLine("9️⃣ Trying to return '1984' (never checked out)...");
			returned = checkoutSystem.ReturnBook(book2);
			Console.WriteLine($"✅ Returned: {returned} (Expected: False)\n");

			Console.WriteLine("🔎 Final checked-out books list:");
			checkoutSystem.CheckoutBook(book3);
			List<Book> outBooks = checkoutSystem.GetCheckedOutBooks();
			foreach (var b in outBooks)
			{
				Console.WriteLine($"📖 {b._title} by {b._author}");
			}

			Console.WriteLine("\n=== ✅ All test cases completed successfully ===");
		}
	}
}